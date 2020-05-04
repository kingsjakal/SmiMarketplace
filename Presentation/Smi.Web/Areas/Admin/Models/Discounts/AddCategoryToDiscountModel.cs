using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a category model to add to the discount
    /// </summary>
    public partial class AddCategoryToDiscountModel : BaseSmiModel
    {
        #region Ctor

        public AddCategoryToDiscountModel()
        {
            SelectedCategoryIds = new List<int>();
        }
        #endregion

        #region Properties

        public int DiscountId { get; set; }

        public IList<int> SelectedCategoryIds { get; set; }

        #endregion
    }
}