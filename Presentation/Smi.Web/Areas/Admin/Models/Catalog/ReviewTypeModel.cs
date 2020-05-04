using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a review type model
    /// </summary>
    public partial class ReviewTypeModel : BaseSmiEntityModel, ILocalizedModel<ReviewTypeLocalizedModel>
    {
        #region Ctor

        public ReviewTypeModel()
        {
            Locales = new List<ReviewTypeLocalizedModel>();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [SmiResourceDisplayName("Admin.Settings.ReviewType.Fields.VisibleToAllCustomers")]
        public bool VisibleToAllCustomers { get; set; }

        public IList<ReviewTypeLocalizedModel> Locales { get; set; }

        #endregion
    }
}
