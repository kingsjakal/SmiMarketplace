using Smi.Services.Caching;
using Smi.Services.Customers;
using Smi.Services.Plugins;

namespace Smi.Services.Discounts
{
    /// <summary>
    /// Represents a discount requirement plugin manager implementation
    /// </summary>
    public partial class DiscountPluginManager : PluginManager<IDiscountRequirementRule>, IDiscountPluginManager
    {
        #region Ctor

        public DiscountPluginManager(ICacheKeyService cacheKeyService,
            ICustomerService customerService, 
            IPluginService pluginService) : base(cacheKeyService, customerService, pluginService)
        {
        }

        #endregion
    }
}