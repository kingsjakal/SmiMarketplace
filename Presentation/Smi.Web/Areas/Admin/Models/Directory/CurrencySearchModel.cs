using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a currency search model
    /// </summary>
    public partial class CurrencySearchModel : BaseSearchModel
    {
        #region Ctor

        public CurrencySearchModel()
        {
            ExchangeRateProviderModel = new CurrencyExchangeRateProviderModel();
        }

        #endregion

        #region Properties
        
        public CurrencyExchangeRateProviderModel ExchangeRateProviderModel { get; set; }

        #endregion
    }
}