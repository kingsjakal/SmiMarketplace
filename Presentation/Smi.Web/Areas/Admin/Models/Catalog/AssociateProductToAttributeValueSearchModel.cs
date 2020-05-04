using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Catalog
{
    /// <summary>
    /// Represents a product search model to associate to the product attribute value
    /// </summary>
    public partial class AssociateProductToAttributeValueSearchModel : BaseSearchModel
    {
        #region Ctor

        public AssociateProductToAttributeValueSearchModel()
        {
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableProductTypes = new List<SelectListItem>();
            AssociateProductToAttributeValueModel = new AssociateProductToAttributeValueModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
        public string SearchProductName { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
        public int SearchCategoryId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
        public int SearchManufacturerId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
        public int SearchStoreId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
        public int SearchVendorId { get; set; }

        [SmiResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
        public int SearchProductTypeId { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }

        public IList<SelectListItem> AvailableManufacturers { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }

        public IList<SelectListItem> AvailableVendors { get; set; }

        public IList<SelectListItem> AvailableProductTypes { get; set; }
        
        public bool IsLoggedInAsVendor { get; set; }
        
        public AssociateProductToAttributeValueModel AssociateProductToAttributeValueModel { get; set; }

        #endregion
    }
}