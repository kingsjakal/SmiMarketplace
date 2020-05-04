using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Settings
{
    /// <summary>
    /// Represents an address settings model
    /// </summary>
    public partial class AddressSettingsModel : BaseSmiModel, ISettingsModel
    {
        #region Properties

        public int ActiveStoreScopeConfiguration { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CompanyEnabled")]
        public bool CompanyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CompanyRequired")]
        public bool CompanyRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddressEnabled")]
        public bool StreetAddressEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddressRequired")]
        public bool StreetAddressRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddress2Enabled")]
        public bool StreetAddress2Enabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.StreetAddress2Required")]
        public bool StreetAddress2Required { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.ZipPostalCodeEnabled")]
        public bool ZipPostalCodeEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.ZipPostalCodeRequired")]
        public bool ZipPostalCodeRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CityEnabled")]
        public bool CityEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CityRequired")]
        public bool CityRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CountyEnabled")]
        public bool CountyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CountyRequired")]
        public bool CountyRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.CountryEnabled")]
        public bool CountryEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.StateProvinceEnabled")]
        public bool StateProvinceEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.PhoneEnabled")]
        public bool PhoneEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.PhoneRequired")]
        public bool PhoneRequired { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.FaxEnabled")]
        public bool FaxEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.Settings.CustomerUser.AddressFormFields.FaxRequired")]
        public bool FaxRequired { get; set; }

        #endregion
    }
}