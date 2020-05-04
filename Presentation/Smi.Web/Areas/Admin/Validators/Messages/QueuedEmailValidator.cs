using FluentValidation;
using Smi.Core.Domain.Messages;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class QueuedEmailValidator : BaseSmiValidator<QueuedEmailModel>
    {
        public QueuedEmailValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.From).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.QueuedEmails.Fields.From.Required"));
            RuleFor(x => x.To).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.QueuedEmails.Fields.To.Required"));

            RuleFor(x => x.SentTries).NotNull().WithMessage(localizationService.GetResource("Admin.System.QueuedEmails.Fields.SentTries.Required"))
                                    .InclusiveBetween(0, 99999).WithMessage(localizationService.GetResource("Admin.System.QueuedEmails.Fields.SentTries.Range"));

            SetDatabaseValidationRules<QueuedEmail>(dataProvider);

        }
    }
}