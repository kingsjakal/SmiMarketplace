using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Plugins
{
    /// <summary>
    /// Represents a plugin model
    /// </summary>
    public partial class PluginModel : BaseSmiModel, IAclSupportedModel, ILocalizedModel<PluginLocalizedModel>, IPluginModel, IStoreMappingSupportedModel
    {
        #region Ctor

        public PluginModel()
        {
            Locales = new List<PluginLocalizedModel>();

            SelectedStoreIds = new List<int>();
            AvailableStores = new List<SelectListItem>();
            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Group")]
        public string Group { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.FriendlyName")]
        public string FriendlyName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.SystemName")]
        public string SystemName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Version")]
        public string Version { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Author")]
        public string Author { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Configure")]
        public string ConfigurationUrl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Installed")]
        public bool Installed { get; set; }
        
        public string Description { get; set; }

        public bool CanChangeEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.IsEnabled")]
        public bool IsEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.Logo")]
        public string LogoUrl { get; set; }

        public IList<PluginLocalizedModel> Locales { get; set; }

        //ACL (customer roles)
        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.AclCustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        //store mapping
        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.LimitedToStores")]
        public IList<int> SelectedStoreIds { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }

    public partial class PluginLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Plugins.Fields.FriendlyName")]
        public string FriendlyName { get; set; }
    }
}