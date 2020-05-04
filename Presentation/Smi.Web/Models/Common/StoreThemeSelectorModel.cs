using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Common
{
    public partial class StoreThemeSelectorModel : BaseSmiModel
    {
        public StoreThemeSelectorModel()
        {
            AvailableStoreThemes = new List<StoreThemeModel>();
        }

        public IList<StoreThemeModel> AvailableStoreThemes { get; set; }

        public StoreThemeModel CurrentStoreTheme { get; set; }
    }
}