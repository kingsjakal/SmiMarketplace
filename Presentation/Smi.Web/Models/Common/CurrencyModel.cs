using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class CurrencyModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }
    }
}