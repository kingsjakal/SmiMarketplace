using FluentValidation;
using Smi.Core.Domain.Topics;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Web.Areas.Admin.Models.Topics;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Topics
{
    public partial class TopicValidator : BaseSmiValidator<TopicModel>
    {
        public TopicValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.SeName).Length(0, SmiSeoDefaults.ForumTopicLength)
                .WithMessage(string.Format(localizationService.GetResource("Admin.SEO.SeName.MaxLengthValidation"), SmiSeoDefaults.ForumTopicLength));

            SetDatabaseValidationRules<Topic>(dataProvider);
        }
    }
}
