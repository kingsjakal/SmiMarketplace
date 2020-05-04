using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount category model
    /// </summary>
    public partial class DiscountCategoryModel : BaseSmiEntityModel
    {
        #region Properties

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        #endregion
    }
}