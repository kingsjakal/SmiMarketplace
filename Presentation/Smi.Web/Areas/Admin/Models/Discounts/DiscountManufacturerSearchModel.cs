using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount manufacturer search model
    /// </summary>
    public partial class DiscountManufacturerSearchModel : BaseSearchModel
    {
        #region Properties

        public int DiscountId { get; set; }

        #endregion
    }
}