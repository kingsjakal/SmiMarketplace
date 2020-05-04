using FluentValidation;
using Smi.Core.Domain.Common;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Common
{
    public partial class AddressAttributeValueValidator : BaseSmiValidator<AddressAttributeValueModel>
    {
        public AddressAttributeValueValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Address.AddressAttributes.Values.Fields.Name.Required"));

            SetDatabaseValidationRules<AddressAttributeValue>(dataProvider);
        }
    }
}