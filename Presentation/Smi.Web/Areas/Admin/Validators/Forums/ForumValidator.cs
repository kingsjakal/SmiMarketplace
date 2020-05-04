using FluentValidation;
using Smi.Core.Domain.Forums;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Forums;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Forums
{
    public partial class ForumValidator : BaseSmiValidator<ForumModel>
    {
        public ForumValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.Forum.Fields.Name.Required"));
            RuleFor(x => x.ForumGroupId).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.Forum.Fields.ForumGroupId.Required"));

            SetDatabaseValidationRules<Forum>(dataProvider);
        }
    }
}