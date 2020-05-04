using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class CurrencySelectorModel : BaseSmiModel
    {
        public CurrencySelectorModel()
        {
            AvailableCurrencies = new List<CurrencyModel>();
        }

        public IList<CurrencyModel> AvailableCurrencies { get; set; }

        public int CurrentCurrencyId { get; set; }
    }
}