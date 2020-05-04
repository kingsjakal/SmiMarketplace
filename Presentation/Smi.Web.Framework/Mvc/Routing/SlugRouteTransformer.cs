using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Smi.Core.Domain.Localization;
using Smi.Services.Localization;
using Smi.Services.Seo;

namespace Smi.Web.Framework.Mvc.Routing
{
    /// <summary>
    /// Represents slug route transformer
    /// </summary>
    public class SlugRouteTransformer : DynamicRouteValueTransformer
    {
        private readonly ILanguageService _languageService;
        private readonly LocalizationSettings _localizationSettings;
        private readonly IUrlRecordService _urlRecordService;

        public SlugRouteTransformer(ILanguageService languageService,
            LocalizationSettings localizationSettings,
            IUrlRecordService urlRecordService)
        {
            _languageService = languageService;
            _localizationSettings = localizationSettings;
            _urlRecordService = urlRecordService;
        }

        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            if (values == null)
                return new ValueTask<RouteValueDictionary>(values);

            if (!values.TryGetValue("SeName", out var slugValue) || string.IsNullOrEmpty(slugValue as string))
                return new ValueTask<RouteValueDictionary>(values);

            var slug = slugValue as string;

            //performance optimization, we load a cached verion here. It reduces number of SQL requests for each page load
            var urlRecord = _urlRecordService.GetBySlug(slug);

            //no URL record found
            if (urlRecord == null)
                return new ValueTask<RouteValueDictionary>(values);

            //virtual directory path
            var pathBase = httpContext.Request.PathBase;
            
            //if URL record is not active let's find the latest one
            if (!urlRecord.IsActive)
            {
                var activeSlug = _urlRecordService.GetActiveSlug(urlRecord.EntityId, urlRecord.EntityName, urlRecord.LanguageId);
                if (string.IsNullOrEmpty(activeSlug))
                    return new ValueTask<RouteValueDictionary>(values);

                //redirect to active slug if found
                values[SmiPathRouteDefaults.ControllerFieldKey] = "Common";
                values[SmiPathRouteDefaults.ActionFieldKey] = "InternalRedirect";
                values[SmiPathRouteDefaults.UrlFieldKey] = $"{pathBase}/{activeSlug}{httpContext.Request.QueryString}";
                values[SmiPathRouteDefaults.PermanentRedirectFieldKey] = true;
                httpContext.Items["Smi.RedirectFromGenericPathRoute"] = true;

                return new ValueTask<RouteValueDictionary>(values);
            }

            //Ensure that the slug is the same for the current language, 
            //otherwise it can cause some issues when customers choose a new language but a slug stays the same
            if (_localizationSettings.SeoFriendlyUrlsForLanguagesEnabled)
            {
                var urllanguage = values["language"];
                if (urllanguage != null && !string.IsNullOrEmpty(urllanguage.ToString()))
                {
                    var language = _languageService.GetAllLanguages().FirstOrDefault(x => x.UniqueSeoCode.ToLowerInvariant() == urllanguage.ToString().ToLowerInvariant());
                    if (language == null)
                        language = _languageService.GetAllLanguages().FirstOrDefault();

                    var slugForCurrentLanguage = _urlRecordService.GetActiveSlug(urlRecord.EntityId, urlRecord.EntityName, language.Id);
                    if (!string.IsNullOrEmpty(slugForCurrentLanguage) && !slugForCurrentLanguage.Equals(slug, StringComparison.InvariantCultureIgnoreCase))
                    {
                        //we should make validation above because some entities does not have SeName for standard (Id = 0) language (e.g. news, blog posts)

                        //redirect to the page for current language
                        values[SmiPathRouteDefaults.ControllerFieldKey] = "Common";
                        values[SmiPathRouteDefaults.ActionFieldKey] = "InternalRedirect";
                        values[SmiPathRouteDefaults.UrlFieldKey] = $"{pathBase}/{language.UniqueSeoCode}/{slugForCurrentLanguage}{httpContext.Request.QueryString}";
                        values[SmiPathRouteDefaults.PermanentRedirectFieldKey] = false;
                        httpContext.Items["Smi.RedirectFromGenericPathRoute"] = true;

                        return new ValueTask<RouteValueDictionary>(values);
                    }
                }
            }

            //since we are here, all is ok with the slug, so process URL
            switch (urlRecord.EntityName.ToLowerInvariant())
            {
                case "product":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Product";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "ProductDetails";
                    values[SmiPathRouteDefaults.ProductIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "producttag":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Catalog";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "ProductsByTag";
                    values[SmiPathRouteDefaults.ProducttagIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "category":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Catalog";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "Category";
                    values[SmiPathRouteDefaults.CategoryIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "manufacturer":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Catalog";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "Manufacturer";
                    values[SmiPathRouteDefaults.ManufacturerIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "vendor":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Catalog";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "Vendor";
                    values[SmiPathRouteDefaults.VendorIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "newsitem":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "News";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "NewsItem";
                    values[SmiPathRouteDefaults.NewsItemIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "blogpost":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Blog";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "BlogPost";
                    values[SmiPathRouteDefaults.BlogPostIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                case "topic":
                    values[SmiPathRouteDefaults.ControllerFieldKey] = "Topic";
                    values[SmiPathRouteDefaults.ActionFieldKey] = "TopicDetails";
                    values[SmiPathRouteDefaults.TopicIdFieldKey] = urlRecord.EntityId;
                    values[SmiPathRouteDefaults.SeNameFieldKey] = urlRecord.Slug;
                    break;
                default:
                    //no record found, thus generate an event this way developers could insert their own types
                    break;
            }

            return new ValueTask<RouteValueDictionary>(values);
        }
    }
}