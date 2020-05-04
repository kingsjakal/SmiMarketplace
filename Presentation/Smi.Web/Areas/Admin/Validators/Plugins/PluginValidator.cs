using FluentValidation;
using Smi.Services.Localization;
using Smi.Web.Areas.Admin.Models.Plugins;
using Smi.Web.Framework.Validators;

namespace Smi.Web.Areas.Admin.Validators.Plugins
{
    public partial class PluginValidator : BaseSmiValidator<PluginModel>
    {
        public PluginValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.FriendlyName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}