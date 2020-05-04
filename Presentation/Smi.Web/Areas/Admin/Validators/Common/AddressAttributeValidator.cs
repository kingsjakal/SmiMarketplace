using FluentValidation;
using Smi.Core.Domain.Common;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Common
{
    public partial class AddressAttributeValidator : BaseSmiValidator<AddressAttributeModel>
    {
        public AddressAttributeValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Address.AddressAttributes.Fields.Name.Required"));

            SetDatabaseValidationRules<AddressAttribute>(dataProvider);
        }
    }
}