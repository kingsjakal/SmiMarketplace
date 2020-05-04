using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a discount product model
    /// </summary>
    public partial class DiscountProductModel : BaseSmiEntityModel
    {
        #region Properties

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        #endregion
    }
}