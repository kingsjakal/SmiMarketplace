using FluentValidation;
using Smi.Core.Domain.Blogs;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Services.Seo;
using Smi.Web.Areas.Admin.Models.Blogs;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Blogs
{
    public partial class BlogPostValidator : BaseSmiValidator<BlogPostModel>
    {
        public BlogPostValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogPosts.Fields.Title.Required"));

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogPosts.Fields.Body.Required"));

            //blog tags should not contain dots
            //current implementation does not support it because it can be handled as file extension
            RuleFor(x => x.Tags)
                .Must(x => x == null || !x.Contains("."))
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogPosts.Fields.Tags.NoDots"));

            RuleFor(x => x.SeName).Length(0, SmiSeoDefaults.SearchEngineNameLength)
                .WithMessage(string.Format(localizationService.GetResource("Admin.SEO.SeName.MaxLengthValidation"), SmiSeoDefaults.SearchEngineNameLength));

            SetDatabaseValidationRules<BlogPost>(dataProvider);
        }
    }
}