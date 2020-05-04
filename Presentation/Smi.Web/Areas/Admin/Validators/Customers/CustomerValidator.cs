﻿using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Smi.Core.Domain.Customers;
using Smi.Data;
using Smi.Services.Customers;
using Smi.Services.Directory;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Customers;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Customers
{
    public partial class CustomerValidator : BaseSmiValidator<CustomerModel>
    {
        public CustomerValidator(CustomerSettings customerSettings,
            ICustomerService customerService,
            ILocalizationService localizationService,
            ISmiDataProvider dataProvider,
            IStateProvinceService stateProvinceService)
        {
            //ensure that valid email address is entered if Registered role is checked to avoid registered customers with empty email address
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                //.WithMessage("Valid Email is required for customer to be in 'Registered' role")
                .WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"))
                //only for registered users
                .When(x => IsRegisteredCustomerRoleChecked(x, customerService));

            //form fields
            if (customerSettings.CountryEnabled && customerSettings.CountryRequired)
            {
                RuleFor(x => x.CountryId)
                    .NotEqual(0)
                    .WithMessage(localizationService.GetResource("Account.Fields.Country.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.CountryEnabled &&
                customerSettings.StateProvinceEnabled &&
                customerSettings.StateProvinceRequired)
            {
                RuleFor(x => x.StateProvinceId).Must((x, context) =>
                {
                    //does selected country have states?
                    var hasStates = stateProvinceService.GetStateProvincesByCountryId(x.CountryId).Any();
                    if (hasStates)
                    {
                        //if yes, then ensure that a state is selected
                        if (x.StateProvinceId == 0)
                            return false;
                    }

                    return true;
                }).WithMessage(localizationService.GetResource("Account.Fields.StateProvince.Required"));
            }
            if (customerSettings.CompanyRequired && customerSettings.CompanyEnabled)
            {
                RuleFor(x => x.Company)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.Company.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.StreetAddressRequired && customerSettings.StreetAddressEnabled)
            {
                RuleFor(x => x.StreetAddress)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.StreetAddress.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.StreetAddress2Required && customerSettings.StreetAddress2Enabled)
            {
                RuleFor(x => x.StreetAddress2)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.StreetAddress2.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.ZipPostalCodeRequired && customerSettings.ZipPostalCodeEnabled)
            {
                RuleFor(x => x.ZipPostalCode)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.ZipPostalCode.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.CityRequired && customerSettings.CityEnabled)
            {
                RuleFor(x => x.City)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.City.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.CountyRequired && customerSettings.CountyEnabled)
            {
                RuleFor(x => x.County)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.County.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.PhoneRequired && customerSettings.PhoneEnabled)
            {
                RuleFor(x => x.Phone)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.Phone.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }
            if (customerSettings.FaxRequired && customerSettings.FaxEnabled)
            {
                RuleFor(x => x.Fax)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Customers.Customers.Fields.Fax.Required"))
                    //only for registered users
                    .When(x => IsRegisteredCustomerRoleChecked(x, customerService));
            }

            SetDatabaseValidationRules<Customer>(dataProvider);
        }

        private bool IsRegisteredCustomerRoleChecked(CustomerModel model, ICustomerService customerService)
        {
            var allCustomerRoles = customerService.GetAllCustomerRoles(true);
            var newCustomerRoles = new List<CustomerRole>();
            foreach (var customerRole in allCustomerRoles)
                if (model.SelectedCustomerRoleIds.Contains(customerRole.Id))
                    newCustomerRoles.Add(customerRole);

            var isInRegisteredRole = newCustomerRoles.FirstOrDefault(cr => cr.SystemName == SmiCustomerDefaults.RegisteredRoleName) != null;
            return isInRegisteredRole;
        }
    }
}