using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a specification attribute model
    /// </summary>
    public partial class SpecificationAttributeModel : BaseSmiEntityModel, ILocalizedModel<SpecificationAttributeLocalizedModel>
    {
        #region Ctor

        public SpecificationAttributeModel()
        {
            Locales = new List<SpecificationAttributeLocalizedModel>();
            SpecificationAttributeOptionSearchModel = new SpecificationAttributeOptionSearchModel();
            SpecificationAttributeProductSearchModel = new SpecificationAttributeProductSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder {get;set;}

        public IList<SpecificationAttributeLocalizedModel> Locales { get; set; }

        public SpecificationAttributeOptionSearchModel SpecificationAttributeOptionSearchModel { get; set; }

        public SpecificationAttributeProductSearchModel SpecificationAttributeProductSearchModel { get; set; }

        #endregion
    }
}