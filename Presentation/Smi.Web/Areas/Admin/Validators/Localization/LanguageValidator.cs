using System.Globalization;
using FluentValidation;
using Smi.Core.Domain.Localization;
using Smi.Data;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Localization;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Localization
{
    public partial class LanguageValidator : BaseSmiValidator<LanguageModel>
    {
        public LanguageValidator(ILocalizationService localizationService, ISmiDataProvider dataProvider)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Fields.Name.Required"));
            RuleFor(x => x.LanguageCulture)
                .Must(x =>
                          {
                              try
                              {
                                  //let's try to create a CultureInfo object
                                  //if "DisplayLocale" is wrong, then exception will be thrown
                                  var unused = new CultureInfo(x);
                                  return true;
                              }
                              catch
                              {
                                  return false;
                              }
                          })
                .WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Fields.LanguageCulture.Validation"));

            RuleFor(x => x.UniqueSeoCode).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Fields.UniqueSeoCode.Required"));
            RuleFor(x => x.UniqueSeoCode).Length(2).WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Fields.UniqueSeoCode.Length"));

            SetDatabaseValidationRules<Language>(dataProvider, "UniqueSeoCode");
        }
    }
}