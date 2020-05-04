using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents a customer user settings model
    /// </summary>
    public partial class CustomerUserSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Ctor

        public CustomerUserSettingsModel()
        {
            CustomerSettings = new CustomerSettingsModel();
            AddressSettings = new AddressSettingsModel();
            DateTimeSettings = new DateTimeSettingsModel();
            ExternalAuthenticationSettings = new ExternalAuthenticationSettingsModel();
            CustomerAttributeSearchModel = new CustomerAttributeSearchModel();
            AddressAttributeSearchModel = new AddressAttributeSearchModel();
        }

        #endregion

        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        public CustomerSettingsModel CustomerSettings { get; set; }

        public AddressSettingsModel AddressSettings { get; set; }

        public DateTimeSettingsModel DateTimeSettings { get; set; }

        public ExternalAuthenticationSettingsModel ExternalAuthenticationSettings { get; set; }

        public CustomerAttributeSearchModel CustomerAttributeSearchModel { get; set; }

        public AddressAttributeSearchModel AddressAttributeSearchModel { get; set; }

        #endregion
    }
}