using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer search model
    /// </summary>
    public partial class CustomerSearchModel : BaseSearchModel, IAclSupportedModel
    {
        #region Ctor

        public CustomerSearchModel()
        {
            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Customers.Customers.List.CustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchEmail")]
        public string SearchEmail { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchUsername")]
        public string SearchUsername { get; set; }

        public bool UsernamesEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchFirstName")]
        public string SearchFirstName { get; set; }
        public bool FirstNameEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchLastName")]
        public string SearchLastName { get; set; }
        public bool LastNameEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchDateOfBirth")]
        public string SearchDayOfBirth { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchDateOfBirth")]
        public string SearchMonthOfBirth { get; set; }

        public bool DateOfBirthEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchCompany")]
        public string SearchCompany { get; set; }

        public bool CompanyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchPhone")]
        public string SearchPhone { get; set; }

        public bool PhoneEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchZipCode")]
        public string SearchZipPostalCode { get; set; }

        public bool ZipPostalCodeEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.List.SearchIpAddress")]
        public string SearchIpAddress { get; set; }

        public bool AvatarEnabled { get; internal set; }

        #endregion
    }
}