using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    public partial class SystemWarningModel : BaseSmiModel
    {
        public SystemWarningLevel Level { get; set; }

        public string Text { get; set; }

        public bool DontEncode { get; set; }
    }

    public enum SystemWarningLevel
    {
        Pass,
        Recommendation,
        CopyrightRemovalKey,
        Warning,
        Fail
    }
}