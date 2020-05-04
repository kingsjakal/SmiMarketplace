using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class LanguageSelectorModel : BaseSmiModel
    {
        public LanguageSelectorModel()
        {
            AvailableLanguages = new List<LanguageModel>();
        }

        public IList<LanguageModel> AvailableLanguages { get; set; }

        public int CurrentLanguageId { get; set; }

        public bool UseImages { get; set; }
    }
}