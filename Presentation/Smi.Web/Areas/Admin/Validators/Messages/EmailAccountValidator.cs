using FluentValidation;
using Smi.Core.Domain.Messages;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class EmailAccountValidator : BaseSmiValidator<EmailAccountModel>
    {
        public EmailAccountValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));

            RuleFor(x => x.DisplayName).NotEmpty();

            SetDatabaseValidationRules<EmailAccount>(dataProvider);
        }
    }
}