using System.Collections.Generic;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Catalog
{
    public partial class CategoryNavigationModel : BaseSmiModel
    {
        public CategoryNavigationModel()
        {
            Categories = new List<CategorySimpleModel>();
        }

        public int CurrentCategoryId { get; set; }
        public List<CategorySimpleModel> Categories { get; set; }

        #region Nested classes

        public class CategoryLineModel : BaseSmiModel
        {
            public int CurrentCategoryId { get; set; }
            public CategorySimpleModel Category { get; set; }
        }

        #endregion
    }
}