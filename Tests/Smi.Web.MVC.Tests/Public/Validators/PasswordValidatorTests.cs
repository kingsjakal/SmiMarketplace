﻿using FluentValidation.TestHelper;
using Moq;
using Smi.Core.Domain.Customers;
using Smi.Services.Directory;
using Smi.Web.Framework.Validators;
using Smi.Web.Models.Customer;
using Smi.Web.Validators.Customer;
using NUnit.Framework;

namespace Smi.Web.MVC.Tests.Public.Validators
{
    [TestFixture]
    public class PasswordValidatorTests : BaseValidatorTests
    {
        private TestValidator _validator;
        private Person _person;
        private ChangePasswordValidator _changePasswordValidator;
        private PasswordRecoveryConfirmValidator _passwordRecoveryConfirmValidator;
        private RegisterValidator _registerValidator;
        private Mock<IStateProvinceService> _stateProvinceService;
        private CustomerSettings _customerSettings;

        [SetUp]
        public new void Setup()
        {
            _customerSettings = new CustomerSettings
            {
                PasswordMinLength = 8,
                PasswordRequireUppercase = true,
                PasswordRequireLowercase = true,
                PasswordRequireDigit = true,
                PasswordRequireNonAlphanumeric = true
            };
            _changePasswordValidator = new ChangePasswordValidator(_localizationService, _customerSettings);
            _stateProvinceService = new Mock<IStateProvinceService>();
            _registerValidator = new RegisterValidator(_localizationService, _stateProvinceService.Object, _customerSettings);
            _passwordRecoveryConfirmValidator = new PasswordRecoveryConfirmValidator(_localizationService, _customerSettings);

            _validator = new TestValidator();
            _person = new Person();
        }

        [Test]
        public void Is_valid_tests_lowercase()
        {
            var cs = new CustomerSettings
            {
                PasswordMinLength = 3,
                PasswordRequireLowercase = true
            };

            _validator.RuleFor(x => x.Password).IsPassword(_localizationService, cs);

            //ShouldHaveValidationError
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "Smi123");

            //ShouldNotHaveValidationError
            _validator.ShouldNotHaveValidationErrorFor(x => x.Password, _person.Password = "Smi123");
        }

        [Test]
        public void Is_valid_tests_uppercase()
        {
            var cs = new CustomerSettings
            {
                PasswordMinLength = 3,
                PasswordRequireUppercase = true                
            };

            _validator.RuleFor(x => x.Password).IsPassword(_localizationService, cs);

            //ShouldHaveValidationError
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "Smi");           

            //ShouldNotHaveValidationError
            _validator.ShouldNotHaveValidationErrorFor(x => x.Password, _person.Password = "Smi");
        }

        [Test]
        public void Is_valid_tests_digit()
        {
            var cs = new CustomerSettings
            {
                PasswordMinLength = 3,
                PasswordRequireDigit = true
            };

            _validator.RuleFor(x => x.Password).IsPassword(_localizationService, cs);

            //ShouldHaveValidationError
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "Smi");

            //ShouldNotHaveValidationError
            _validator.ShouldNotHaveValidationErrorFor(x => x.Password, _person.Password = "Smi1");
        }

        [Test]
        public void Is_valid_tests_NonAlphanumeric()
        {
            var cs = new CustomerSettings
            {
                PasswordMinLength = 3,
                PasswordRequireNonAlphanumeric = true
            };

            _validator.RuleFor(x => x.Password).IsPassword(_localizationService, cs);
            
            //ShouldHaveValidationError
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "Smi");

            //ShouldNotHaveValidationError
            _validator.ShouldNotHaveValidationErrorFor(x => x.Password, _person.Password = "Smi#");
        }

        [Test]
        public void Is_valid_tests_all_rules()
        {
            //Example:  (?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,}$
            _validator.RuleFor(x => x.Password).IsPassword(_localizationService, _customerSettings);

            //ShouldHaveValidationError
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "123");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "12345678");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123$");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123$");
            _validator.ShouldHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123~");

            //ShouldNotHaveValidationError
            _validator.ShouldNotHaveValidationErrorFor(x => x.Password, _person.Password = "SmiMarketplace123$");            
        }
        
        [Test]
        public void Should_validate_on_ChangePasswordModel_is_all_rule()
        {            
            _changePasswordValidator = new ChangePasswordValidator(_localizationService, _customerSettings);

            var model = new ChangePasswordModel
            {
                NewPassword = "1234"
            };
            //we know that new password should equal confirmation password
            model.ConfirmNewPassword = model.NewPassword;
            _changePasswordValidator.ShouldHaveValidationErrorFor(x => x.NewPassword, model);
            model.NewPassword = "SmiMarketplace123$";
            //we know that new password should equal confirmation password
            model.ConfirmNewPassword = model.NewPassword;
            _changePasswordValidator.ShouldNotHaveValidationErrorFor(x => x.NewPassword, model);
        }

        [Test]
        public void Should_validate_on_PasswordRecoveryConfirmModel_is_all_rule()
        {            
            _passwordRecoveryConfirmValidator = new PasswordRecoveryConfirmValidator(_localizationService, _customerSettings);

            var model = new PasswordRecoveryConfirmModel
            {
                NewPassword = "1234"
            };
            //we know that new password should equal confirmation password
            model.ConfirmNewPassword = model.NewPassword;
            _passwordRecoveryConfirmValidator.ShouldHaveValidationErrorFor(x => x.NewPassword, model);
            model.NewPassword = "SmiMarketplace123$";
            //we know that new password should equal confirmation password
            model.ConfirmNewPassword = model.NewPassword;
            _passwordRecoveryConfirmValidator.ShouldNotHaveValidationErrorFor(x => x.NewPassword, model);
        }

        [Test]
        public void Should_validate_on_RegisterModel_is_all_rule()
        {            
            _registerValidator = new RegisterValidator(_localizationService, _stateProvinceService.Object, _customerSettings);

            var model = new RegisterModel
            {
                Password = "1234"
            };
            //we know that password should equal confirmation password
            model.ConfirmPassword = model.Password;
            _registerValidator.ShouldHaveValidationErrorFor(x => x.Password, model);
            model.Password = "SmiMarketplace123$";
            //we know that password should equal confirmation password
            model.ConfirmPassword = model.Password;
            _registerValidator.ShouldNotHaveValidationErrorFor(x => x.Password, model);
        }        
    }
}
