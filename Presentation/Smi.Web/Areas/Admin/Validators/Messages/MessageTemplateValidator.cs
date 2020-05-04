using FluentValidation;
using Smi.Core.Domain.Messages;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Messages;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Messages
{
    public partial class MessageTemplateValidator : BaseSmiValidator<MessageTemplateModel>
    {
        public MessageTemplateValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.MessageTemplates.Fields.Subject.Required"));
            RuleFor(x => x.Body).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.MessageTemplates.Fields.Body.Required"));

            SetDatabaseValidationRules<MessageTemplate>(dataProvider);
        }
    }
}