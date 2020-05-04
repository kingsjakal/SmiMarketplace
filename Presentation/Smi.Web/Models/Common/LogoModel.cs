using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class LogoModel : BaseSmiModel
    {
        public string StoreName { get; set; }

        public string LogoPath { get; set; }
    }
}