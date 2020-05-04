using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Discounts
{
    /// <summary>
    /// Represents a category search model to add to the discount
    /// </summary>
    public partial class AddCategoryToDiscountSearchModel : BaseSearchModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Categories.List.SearchCategoryName")]
        public string SearchCategoryName { get; set; }

        #endregion
    }
}