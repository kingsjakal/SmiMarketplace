using System;
using System.Linq;
using Smi.Core;
using Smi.Core.Caching;
using Smi.Core.Domain.Common;
using Smi.Services.Caching;
using Smi.Services.Common;
using Smi.Services.Configuration;
using Smi.Services.Logging;
using Smi.Web.Areas.Admin.Infrastructure.Cache;
using Smi.Web.Areas.Admin.Models.Home;

namespace Smi.Web.Areas.Admin.Factories
{
    /// <summary>
    /// Represents the home models factory implementation
    /// </summary>
    public partial class HomeModelFactory : IHomeModelFactory
    {
        #region Fields

        private readonly AdminAreaSettings _adminAreaSettings;
        private readonly ICacheKeyService _cacheKeyService;
        private readonly ICommonModelFactory _commonModelFactory;
        private readonly ILogger _logger;
        private readonly IOrderModelFactory _orderModelFactory;
        private readonly ISettingService _settingService;
        private readonly IStaticCacheManager _staticCacheManager;
        private readonly IWorkContext _workContext;
        private readonly SmiHttpClient _smiHttpClient;

        #endregion

        #region Ctor

        public HomeModelFactory(AdminAreaSettings adminAreaSettings,
            ICacheKeyService cacheKeyService,
            ICommonModelFactory commonModelFactory,
            ILogger logger,
            IOrderModelFactory orderModelFactory,
            ISettingService settingService,
            IStaticCacheManager staticCacheManager,
            IWorkContext workContext,
            SmiHttpClient smiHttpClient)
        {
            _adminAreaSettings = adminAreaSettings;
            _cacheKeyService = cacheKeyService;
            _commonModelFactory = commonModelFactory;
            _logger = logger;
            _orderModelFactory = orderModelFactory;
            _settingService = settingService;
            _staticCacheManager = staticCacheManager;
            _workContext = workContext;
            _smiHttpClient = smiHttpClient;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare dashboard model
        /// </summary>
        /// <param name="model">Dashboard model</param>
        /// <returns>Dashboard model</returns>
        public virtual DashboardModel PrepareDashboardModel(DashboardModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            model.IsLoggedInAsVendor = _workContext.CurrentVendor != null;

            //prepare nested search models
            _commonModelFactory.PreparePopularSearchTermSearchModel(model.PopularSearchTerms);
            _orderModelFactory.PrepareBestsellerBriefSearchModel(model.BestsellersByAmount);
            _orderModelFactory.PrepareBestsellerBriefSearchModel(model.BestsellersByQuantity);

            return model;
        }

        /// <summary>
        /// Prepare SmiMarketplace news model
        /// </summary>
        /// <returns>SmiMarketplace news model</returns>
        public virtual SmiMarketplaceNewsModel PrepareSmiMarketplaceNewsModel()
        {
            var model = new SmiMarketplaceNewsModel
            {
                HideAdvertisements = _adminAreaSettings.HideAdvertisementsOnAdminArea
            };

            try
            {
                //try to get news RSS feed
                var rssData = _staticCacheManager.Get(_cacheKeyService.PrepareKeyForDefaultCache(SmiModelCacheDefaults.OfficialNewsModelKey), () =>
                {
                    try
                    {
                        return _smiHttpClient.GetNewsRssAsync().Result;
                    }
                    catch (AggregateException exception)
                    {
                        //rethrow actual excepion
                        throw exception.InnerException;
                    }
                });

                for (var i = 0; i < rssData.Items.Count; i++)
                {
                    var item = rssData.Items.ElementAt(i);
                    var newsItem = new SmiMarketplaceNewsDetailsModel
                    {
                        Title = item.TitleText,
                        Summary = item.ContentText,
                        Url = item.Url.OriginalString,
                        PublishDate = item.PublishDate
                    };
                    model.Items.Add(newsItem);

                    //has new items?
                    if (i != 0)
                        continue;

                    var firstRequest = string.IsNullOrEmpty(_adminAreaSettings.LastNewsTitleAdminArea);
                    if (_adminAreaSettings.LastNewsTitleAdminArea == newsItem.Title)
                        continue;

                    _adminAreaSettings.LastNewsTitleAdminArea = newsItem.Title;
                    _settingService.SaveSetting(_adminAreaSettings);

                    //new item
                    if (!firstRequest)
                        model.HasNewItems = true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error("No access to the news. Website www.SmiMarketplace.com is not available.", ex);
            }

            return model;
        }

        #endregion
    }
}