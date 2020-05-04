using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Core.Domain.Catalog;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer model
    /// </summary>
    public partial class CustomerModel : BaseSmiEntityModel, IAclSupportedModel
    {
        #region Ctor

        public CustomerModel()
        {
            AvailableTimeZones = new List<SelectListItem>();
            SendEmail = new SendEmailModel() { SendImmediately = true };
            SendPm = new SendPmModel();

            SelectedCustomerRoleIds = new List<int>();
            AvailableCustomerRoles = new List<SelectListItem>();

            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            CustomerAttributes = new List<CustomerAttributeModel>();
            AvailableNewsletterSubscriptionStores = new List<SelectListItem>();
            SelectedNewsletterSubscriptionStoreIds = new List<int>();
            AddRewardPoints = new AddRewardPointsToCustomerModel();
            CustomerRewardPointsSearchModel = new CustomerRewardPointsSearchModel();
            CustomerAddressSearchModel = new CustomerAddressSearchModel();
            CustomerOrderSearchModel = new CustomerOrderSearchModel();
            CustomerShoppingCartSearchModel = new CustomerShoppingCartSearchModel();
            CustomerActivityLogSearchModel = new CustomerActivityLogSearchModel();
            CustomerBackInStockSubscriptionSearchModel = new CustomerBackInStockSubscriptionSearchModel();
            CustomerAssociatedExternalAuthRecordsSearchModel = new CustomerAssociatedExternalAuthRecordsSearchModel();
        }

        #endregion

        #region Properties

        public bool UsernamesEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Username")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Password")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string Password { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Vendor")]
        public int VendorId { get; set; }

        public IList<SelectListItem> AvailableVendors { get; set; }

        //form fields & properties
        public bool GenderEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Gender")]
        public string Gender { get; set; }

        public bool FirstNameEnabled { get; set; }
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.FirstName")]
        public string FirstName { get; set; }

        public bool LastNameEnabled { get; set; }
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.LastName")]
        public string LastName { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.FullName")]
        public string FullName { get; set; }

        public bool DateOfBirthEnabled { get; set; }

        [UIHint("DateNullable")]
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        public bool CompanyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Company")]
        public string Company { get; set; }

        public bool StreetAddressEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress")]
        public string StreetAddress { get; set; }

        public bool StreetAddress2Enabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress2")]
        public string StreetAddress2 { get; set; }

        public bool ZipPostalCodeEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        public bool CityEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.City")]
        public string City { get; set; }

        public bool CountyEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.County")]
        public string County { get; set; }

        public bool CountryEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Country")]
        public int CountryId { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        public bool StateProvinceEnabled { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.StateProvince")]
        public int StateProvinceId { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; }

        public bool PhoneEnabled { get; set; }

        [DataType(DataType.PhoneNumber)]
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Phone")]
        public string Phone { get; set; }

        public bool FaxEnabled { get; set; }

        [DataType(DataType.PhoneNumber)]
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Fax")]
        public string Fax { get; set; }

        public List<CustomerAttributeModel> CustomerAttributes { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.RegisteredInStore")]
        public string RegisteredInStore { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Active")]
        public bool Active { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public int AffiliateId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public string AffiliateName { get; set; }

        //time zone
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.TimeZoneId")]
        public string TimeZoneId { get; set; }

        public bool AllowCustomersToSetTimeZone { get; set; }

        public IList<SelectListItem> AvailableTimeZones { get; set; }

        //EU VAT
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.VatNumber")]
        public string VatNumber { get; set; }

        public string VatNumberStatusNote { get; set; }

        public bool DisplayVatNumber { get; set; }

        public bool DisplayRegisteredInStore { get; set; }

        //registration date
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.LastActivityDate")]
        public DateTime LastActivityDate { get; set; }

        //IP address
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.IPAddress")]
        public string LastIpAddress { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.LastVisitedPage")]
        public string LastVisitedPage { get; set; }

        //customer roles
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.CustomerRoles")]
        public string CustomerRoleNames { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.CustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }

        //newsletter subscriptions (per store)
        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public IList<SelectListItem> AvailableNewsletterSubscriptionStores { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public IList<int> SelectedNewsletterSubscriptionStoreIds { get; set; }

        //reward points history
        public bool DisplayRewardPointsHistory { get; set; }

        public AddRewardPointsToCustomerModel AddRewardPoints { get; set; }

        public CustomerRewardPointsSearchModel CustomerRewardPointsSearchModel { get; set; }

        //send email model
        public SendEmailModel SendEmail { get; set; }

        //send PM model
        public SendPmModel SendPm { get; set; }

        //send a private message
        public bool AllowSendingOfPrivateMessage { get; set; }

        //send the welcome message
        public bool AllowSendingOfWelcomeMessage { get; set; }

        //re-send the activation message
        public bool AllowReSendingOfActivationMessage { get; set; }

        //GDPR enabled
        public bool GdprEnabled { get; set; }
        
        public string AvatarUrl { get; internal set; }

        public CustomerAddressSearchModel CustomerAddressSearchModel { get; set; }

        public CustomerOrderSearchModel CustomerOrderSearchModel { get; set; }

        public CustomerShoppingCartSearchModel CustomerShoppingCartSearchModel { get; set; }

        public CustomerActivityLogSearchModel CustomerActivityLogSearchModel { get; set; }

        public CustomerBackInStockSubscriptionSearchModel CustomerBackInStockSubscriptionSearchModel { get; set; }

        public CustomerAssociatedExternalAuthRecordsSearchModel CustomerAssociatedExternalAuthRecordsSearchModel { get; set; }

        #endregion

        #region Nested classes

        public partial class SendEmailModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.Customers.Customers.SendEmail.Subject")]
            public string Subject { get; set; }

            [SmiResourceDisplayName("Admin.Customers.Customers.SendEmail.Body")]
            public string Body { get; set; }

            [SmiResourceDisplayName("Admin.Customers.Customers.SendEmail.SendImmediately")]
            public bool SendImmediately { get; set; }

            [SmiResourceDisplayName("Admin.Customers.Customers.SendEmail.DontSendBeforeDate")]
            [UIHint("DateTimeNullable")]
            public DateTime? DontSendBeforeDate { get; set; }
        }

        public partial class SendPmModel : BaseSmiModel
        {
            [SmiResourceDisplayName("Admin.Customers.Customers.SendPM.Subject")]
            public string Subject { get; set; }

            [SmiResourceDisplayName("Admin.Customers.Customers.SendPM.Message")]
            public string Message { get; set; }
        }

        public partial class CustomerAttributeModel : BaseSmiEntityModel
        {
            public CustomerAttributeModel()
            {
                Values = new List<CustomerAttributeValueModel>();
            }

            public string Name { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<CustomerAttributeValueModel> Values { get; set; }
        }

        public partial class CustomerAttributeValueModel : BaseSmiEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }

        #endregion
    }
}