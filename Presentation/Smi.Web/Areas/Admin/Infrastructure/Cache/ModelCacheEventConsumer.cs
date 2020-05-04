using Smi.Core.Caching;
using Smi.Core.Domain.Catalog;
using Smi.Core.Domain.Configuration;
using Smi.Core.Domain.Vendors;
using Smi.Core.Events;
using Smi.Services.Events;
using Smi.Services.Plugins;

namespace Smi.Web.Areas.Admin.Infrastructure.Cache
{
    /// <summary>
    /// Model cache event consumer (used for caching of presentation layer models)
    /// </summary>
    public partial class ModelCacheEventConsumer :
        //settings
        IConsumer<EntityUpdatedEvent<Setting>>,
        //categories
        IConsumer<EntityInsertedEvent<Category>>,
        IConsumer<EntityUpdatedEvent<Category>>,
        IConsumer<EntityDeletedEvent<Category>>,
        //manufacturers
        IConsumer<EntityInsertedEvent<Manufacturer>>,
        IConsumer<EntityUpdatedEvent<Manufacturer>>,
        IConsumer<EntityDeletedEvent<Manufacturer>>,
        //vendors
        IConsumer<EntityInsertedEvent<Vendor>>,
        IConsumer<EntityUpdatedEvent<Vendor>>,
        IConsumer<EntityDeletedEvent<Vendor>>,

        IConsumer<PluginUpdatedEvent>
    {
        #region Fields

        private readonly IStaticCacheManager _staticCacheManager;

        #endregion

        #region Ctor

        public ModelCacheEventConsumer(IStaticCacheManager staticCacheManager)
        {
            _staticCacheManager = staticCacheManager;
        }

        #endregion

        #region Methods

        public void HandleEvent(EntityUpdatedEvent<Setting> eventMessage)
        {
            //clear models which depend on settings
            _staticCacheManager.Remove(SmiModelCacheDefaults.OfficialNewsModelKey); //depends on AdminAreaSettings.HideAdvertisementsOnAdminArea
        }

        //categories
        public void HandleEvent(EntityInsertedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoriesListPrefixCacheKey);
        }
        public void HandleEvent(EntityUpdatedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoriesListPrefixCacheKey);
        }
        public void HandleEvent(EntityDeletedEvent<Category> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.CategoriesListPrefixCacheKey);
        }

        //manufacturers
        public void HandleEvent(EntityInsertedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturersListPrefixCacheKey);
        }
        public void HandleEvent(EntityUpdatedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturersListPrefixCacheKey);
        }
        public void HandleEvent(EntityDeletedEvent<Manufacturer> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.ManufacturersListPrefixCacheKey);
        }

        //vendors
        public void HandleEvent(EntityInsertedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.VendorsListPrefixCacheKey);
        }
        public void HandleEvent(EntityUpdatedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.VendorsListPrefixCacheKey);
        }
        public void HandleEvent(EntityDeletedEvent<Vendor> eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiModelCacheDefaults.VendorsListPrefixCacheKey);
        }

        /// <summary>
        /// Handle plugin updated event
        /// </summary>
        /// <param name="eventMessage">Event</param>
        public void HandleEvent(PluginUpdatedEvent eventMessage)
        {
            _staticCacheManager.RemoveByPrefix(SmiPluginDefaults.AdminNavigationPluginsPrefixCacheKey);
        }

        #endregion
    }
}