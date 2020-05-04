using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Tax
{
    /// <summary>
    /// Represents a tax provider model
    /// </summary>
    public partial class TaxProviderModel : BaseSmiModel, IPluginModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Tax.Providers.Fields.IsPrimaryTaxProvider")]
        public bool IsPrimaryTaxProvider { get; set; }
        
        [SmiResourceDisplayName("Admin.Configuration.Tax.Providers.Configure")]
        public string ConfigurationUrl { get; set; }

        public string LogoUrl { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }
}