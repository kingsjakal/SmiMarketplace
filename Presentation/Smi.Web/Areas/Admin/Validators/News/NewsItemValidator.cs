using FluentValidation;
using Smi.Core.Domain.News;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Web.Areas.Admin.Models.News;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.News
{
    public partial class NewsItemValidator : BaseSmiValidator<NewsItemModel>
    {
        public NewsItemValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.News.NewsItems.Fields.Title.Required"));

            RuleFor(x => x.Short).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.News.NewsItems.Fields.Short.Required"));

            RuleFor(x => x.Full).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.News.NewsItems.Fields.Full.Required"));

            RuleFor(x => x.SeName).Length(0, SmiSeoDefaults.SearchEngineNameLength)
                .WithMessage(string.Format(localizationService.GetResource("Admin.SEO.SeName.MaxLengthValidation"), SmiSeoDefaults.SearchEngineNameLength));

            SetDatabaseValidationRules<NewsItem>(dataProvider);
        }
    }
}