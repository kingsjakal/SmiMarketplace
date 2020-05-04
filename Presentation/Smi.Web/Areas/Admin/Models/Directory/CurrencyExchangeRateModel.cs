using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Directory
{
    /// <summary>
    /// Represents a currency exchange rate model
    /// </summary>
    public partial class CurrencyExchangeRateModel : BaseSmiModel
    {
        #region Properties

        public string CurrencyCode { get; set; }

        public decimal Rate { get; set; }

        #endregion
    }
}