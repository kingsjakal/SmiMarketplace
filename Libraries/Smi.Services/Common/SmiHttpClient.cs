﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Smi.Core;
using Smi.Core.Domain.Common;
using Smi.Core.Rss;
using Smi.Services.Localization;

namespace Smi.Services.Common
{
    /// <summary>
    /// Represents the HTTP client to request SmiMarketplace official site
    /// </summary>
    public partial class SmiHttpClient
    {
        #region Fields

        private readonly AdminAreaSettings _adminAreaSettings;
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILanguageService _languageService;
        private readonly IStoreContext _storeContext;
        private readonly IWebHelper _webHelper;
        private readonly IWorkContext _workContext;

        #endregion

        #region Ctor

        public SmiHttpClient(AdminAreaSettings adminAreaSettings,
            HttpClient client,
            IHttpContextAccessor httpContextAccessor,
            ILanguageService languageService,
            IStoreContext storeContext,
            IWebHelper webHelper,
            IWorkContext workContext)
        {
            //configure client
            client.BaseAddress = new Uri("https://www.SmiMarketplace.com/");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.Add(HeaderNames.UserAgent, $"SmiMarketplace-{SmiVersion.CurrentVersion}");

            _adminAreaSettings = adminAreaSettings;
            _httpClient = client;
            _httpContextAccessor = httpContextAccessor;
            _languageService = languageService;
            _storeContext = storeContext;
            _webHelper = webHelper;
            _workContext = workContext;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check whether the site is available
        /// </summary>
        /// <returns>The asynchronous task whose result determines that request is completed</returns>
        public virtual async Task PingAsync()
        {
            await _httpClient.GetStringAsync("/");
        }

        /// <summary>
        /// Check the current store for the copyright removal key
        /// </summary>
        /// <returns>The asynchronous task whose result contains the warning text</returns>
        public virtual async Task<string> GetCopyrightWarningAsync()
        {
            //prepare URL to request
            var language = _languageService.GetTwoLetterIsoLanguageName(_workContext.WorkingLanguage);
            var url = string.Format(SmiCommonDefaults.SmiCopyrightWarningPath,
                _storeContext.CurrentStore.Url,
                _webHelper.IsLocalRequest(_httpContextAccessor.HttpContext.Request),
                language).ToLowerInvariant();

            //get the message
            return await _httpClient.GetStringAsync(url);
        }

        /// <summary>
        /// Get official news RSS
        /// </summary>
        /// <returns>The asynchronous task whose result contains news RSS feed</returns>
        public virtual async Task<RssFeed> GetNewsRssAsync()
        {
            //prepare URL to request
            var language = _languageService.GetTwoLetterIsoLanguageName(_workContext.WorkingLanguage);
            var url = string.Format(SmiCommonDefaults.SmiNewsRssPath,
                SmiVersion.CurrentVersion,
                _webHelper.IsLocalRequest(_httpContextAccessor.HttpContext.Request),
                _adminAreaSettings.HideAdvertisementsOnAdminArea,
                _webHelper.GetStoreLocation(),
                language).ToLowerInvariant();

            //get news feed
            using var stream = await _httpClient.GetStreamAsync(url);
            return await RssFeed.LoadAsync(stream);
        }

        /// <summary>
        /// Notification about the successful installation
        /// </summary>
        /// <param name="email">Admin email</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>The asynchronous task whose result determines that request is completed</returns>
        public virtual async Task InstallationCompletedAsync(string email, string languageCode)
        {
            //prepare URL to request
            var url = string.Format(SmiCommonDefaults.SmiInstallationCompletedPath,
                SmiVersion.CurrentVersion,
                _webHelper.IsLocalRequest(_httpContextAccessor.HttpContext.Request),
                WebUtility.UrlEncode(email),
                _webHelper.GetStoreLocation(),
                languageCode)
                .ToLowerInvariant();

            await _httpClient.GetStringAsync(url);
        }

        /// <summary>
        /// Get a response regarding available categories of marketplace extensions
        /// </summary>
        /// <returns>The asynchronous task whose result contains the result string</returns>
        public virtual async Task<string> GetExtensionsCategoriesAsync()
        {
            //prepare URL to request
            var language = _languageService.GetTwoLetterIsoLanguageName(_workContext.WorkingLanguage);
            var url = string.Format(SmiCommonDefaults.SmiExtensionsCategoriesPath, language).ToLowerInvariant();

            //get XML response
            return await _httpClient.GetStringAsync(url);
        }

        /// <summary>
        /// Get a response regarding available versions of marketplace extensions
        /// </summary>
        /// <returns>The asynchronous task whose result contains the result string</returns>
        public virtual async Task<string> GetExtensionsVersionsAsync()
        {
            //prepare URL to request
            var language = _languageService.GetTwoLetterIsoLanguageName(_workContext.WorkingLanguage);
            var url = string.Format(SmiCommonDefaults.SmiExtensionsVersionsPath, language).ToLowerInvariant();

            //get XML response
            return await _httpClient.GetStringAsync(url);
        }

        /// <summary>
        /// Get a response regarding marketplace extensions
        /// </summary>
        /// <param name="categoryId">Category identifier</param>
        /// <param name="versionId">Version identifier</param>
        /// <param name="price">Price; 0 - all, 10 - free, 20 - paid</param>
        /// <param name="searchTerm">Search term</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>The asynchronous task whose result contains the result string</returns>
        public virtual async Task<string> GetExtensionsAsync(int categoryId = 0,
            int versionId = 0, int price = 0, string searchTerm = null,
            int pageIndex = 0, int pageSize = int.MaxValue)
        {
            //prepare URL to request
            var language = _languageService.GetTwoLetterIsoLanguageName(_workContext.WorkingLanguage);
            var url = string.Format(SmiCommonDefaults.SmiExtensionsPath,
                categoryId, versionId, price, WebUtility.UrlEncode(searchTerm), pageIndex, pageSize, language).ToLowerInvariant();

            //get XML response
            return await _httpClient.GetStringAsync(url);
        }

        #endregion
    }
}