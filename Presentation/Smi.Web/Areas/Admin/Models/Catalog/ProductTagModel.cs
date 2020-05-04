using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product tag model
    /// </summary>
    public partial class ProductTagModel : BaseSmiEntityModel, ILocalizedModel<ProductTagLocalizedModel>
    {
        #region Ctor

        public ProductTagModel()
        {
            Locales = new List<ProductTagLocalizedModel>();
        }
        
        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.ProductTags.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductTags.Fields.ProductCount")]
        public int ProductCount { get; set; }

        public IList<ProductTagLocalizedModel> Locales { get; set; }

        #endregion
    }

    public partial class ProductTagLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.ProductTags.Fields.Name")]
        public string Name { get; set; }
    }
}