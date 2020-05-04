using System.Linq;
using Smi.Core.Caching;
using Smi.Core.Domain.Tax;
using Smi.Core.Events;
using Smi.Plugin.Tax.FixedOrByCountryStateZip.Domain;
using Smi.Plugin.Tax.FixedOrByCountryStateZip.Services;
using Smi.Services.Configuration;
using Smi.Services.Events;

namespace Smi.Plugin.Tax.FixedOrByCountryStateZip.Infrastructure.Cache
{
    /// <summary>
    /// Model cache event consumer (used for caching of presentation layer models)
    /// </summary>
    public partial class ModelCacheEventConsumer : 
        //tax rates
        IConsumer<EntityInsertedEvent<TaxRate>>,
        IConsumer<EntityUpdatedEvent<TaxRate>>,
        IConsumer<EntityDeletedEvent<TaxRate>>,
        //tax category
        IConsumer<EntityDeletedEvent<TaxCategory>>
    {
        #region Constants

        /// <summary>
        /// Key for caching all tax rates
        /// </summary>
        public static CacheKey ALL_TAX_RATES_MODEL_KEY = new CacheKey("Smi.plugins.tax.fixedorbycountrystateziptaxrate.all", TAXRATE_PATTERN_KEY);
        public static CacheKey TAXRATE_ALL_KEY = new CacheKey("Smi.plugins.tax.fixedorbycountrystateziptaxrate.taxrate.all", TAXRATE_PATTERN_KEY);
        
        public const string TAXRATE_PATTERN_KEY = "Smi.plugins.tax.fixedorbycountrystateziptaxrate.";

        #endregion

        #region Fields

        private readonly ICountryStateZipService _taxRateService;
        private readonly ISettingService _settingService;
        private readonly IStaticCacheManager _staticCacheManager;

        #endregion

        #region Ctor

        public ModelCacheEventConsumer(ICountryStateZipService taxRateService,
            ISettingService settingService,
            IStaticCacheManager staticCacheManager)
        {
            _taxRateService = taxRateService;
            _settingService = settingService;
            _staticCacheManager = staticCacheManager;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handle tax rate inserted event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(EntityInsertedEvent<TaxRate> eventMessage)
        {
            //clear cache
            _staticCacheManager.RemoveByPrefix(TAXRATE_PATTERN_KEY);
        }

        /// <summary>
        /// Handle tax rate updated event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(EntityUpdatedEvent<TaxRate> eventMessage)
        {
            //clear cache
            _staticCacheManager.RemoveByPrefix(TAXRATE_PATTERN_KEY);
        }

        /// <summary>
        /// Handle tax rate deleted event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(EntityDeletedEvent<TaxRate> eventMessage)
        {
            //clear cache
            _staticCacheManager.RemoveByPrefix(TAXRATE_PATTERN_KEY);
        }

        /// <summary>
        /// Handle tax category deleted event
        /// </summary>
        /// <param name="eventMessage">Event message</param>
        public void HandleEvent(EntityDeletedEvent<TaxCategory> eventMessage)
        {
            var taxCategory = eventMessage?.Entity;
            if (taxCategory == null)
                return;

            //delete an appropriate record when tax category is deleted
            var recordsToDelete = _taxRateService.GetAllTaxRates().Where(taxRate => taxRate.TaxCategoryId == taxCategory.Id).ToList();
            foreach (var taxRate in recordsToDelete)
            {
                _taxRateService.DeleteTaxRate(taxRate);
            }

            //delete saved fixed rate if exists
            var setting = _settingService.GetSetting(string.Format(FixedOrByCountryStateZipDefaults.FixedRateSettingsKey, taxCategory.Id));
            if (setting != null)
                _settingService.DeleteSetting(setting);
        }

        #endregion
    }
}