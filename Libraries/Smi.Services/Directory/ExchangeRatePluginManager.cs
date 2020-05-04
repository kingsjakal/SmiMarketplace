using System.Collections.Generic;
using Smi.Core.Domain.Customers;
using Smi.Core.Domain.Directory;
using Smi.Services.Caching;
using Smi.Services.Customers;
using Smi.Services.Plugins;

namespace Smi.Services.Directory
{
    /// <summary>
    /// Represents an exchange rate plugin manager implementation
    /// </summary>
    public partial class ExchangeRatePluginManager : PluginManager<IExchangeRateProvider>, IExchangeRatePluginManager
    {
        #region Fields

        private readonly CurrencySettings _currencySettings;

        #endregion

        #region Ctor

        public ExchangeRatePluginManager(CurrencySettings currencySettings,
            ICacheKeyService cacheKeyService,
            ICustomerService customerService,
            IPluginService pluginService) : base(cacheKeyService, customerService, pluginService)
        {
            _currencySettings = currencySettings;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load primary active exchange rate provider
        /// </summary>
        /// <param name="customer">Filter by customer; pass null to load all plugins</param>
        /// <param name="storeId">Filter by store; pass 0 to load all plugins</param>
        /// <returns>Exchange rate provider</returns>
        public virtual IExchangeRateProvider LoadPrimaryPlugin(Customer customer = null, int storeId = 0)
        {
            return LoadPrimaryPlugin(_currencySettings.ActiveExchangeRateProviderSystemName, customer, storeId);
        }

        /// <summary>
        /// Check whether the passed exchange rate provider is active
        /// </summary>
        /// <param name="exchangeRateProvider">Exchange rate provider to check</param>
        /// <returns>Result</returns>
        public virtual bool IsPluginActive(IExchangeRateProvider exchangeRateProvider)
        {
            return IsPluginActive(exchangeRateProvider, new List<string> { _currencySettings.ActiveExchangeRateProviderSystemName });
        }

        #endregion
    }
}