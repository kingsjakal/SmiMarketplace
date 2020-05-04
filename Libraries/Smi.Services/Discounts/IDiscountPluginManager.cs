using Smi.Services.Plugins;

namespace Smi.Services.Discounts
{
    /// <summary>
    /// Represents a discount requirement plugin manager
    /// </summary>
    public partial interface IDiscountPluginManager : IPluginManager<IDiscountRequirementRule>
    {
    }
}