using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class LanguageModel : BaseSmiEntityModel
    {
        public string Name { get; set; }

        public string FlagImageFileName { get; set; }
    }
}