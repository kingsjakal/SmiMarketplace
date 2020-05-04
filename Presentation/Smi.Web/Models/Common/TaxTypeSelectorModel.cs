using Smi.Core.Domain.Tax;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class TaxTypeSelectorModel : BaseSmiModel
    {
        public TaxDisplayType CurrentTaxType { get; set; }
    }
}