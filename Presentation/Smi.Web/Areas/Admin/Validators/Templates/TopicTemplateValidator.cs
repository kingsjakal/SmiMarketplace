using FluentValidation;
using Smi.Core.Domain.Topics;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Templates;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Templates
{
    public partial class TopicTemplateValidator : BaseSmiValidator<TopicTemplateModel>
    {
        public TopicTemplateValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.ViewPath.Required"));

            SetDatabaseValidationRules<TopicTemplate>(dataProvider);
        }
    }
}