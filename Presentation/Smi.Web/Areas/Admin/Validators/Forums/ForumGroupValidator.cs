using FluentValidation;
using Smi.Core.Domain.Forums;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Forums;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Forums
{
    public partial class ForumGroupValidator : BaseSmiValidator<ForumGroupModel>
    {
        public ForumGroupValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Forums.ForumGroup.Fields.Name.Required"));

            SetDatabaseValidationRules<ForumGroup>(dataProvider);
        }
    }
}