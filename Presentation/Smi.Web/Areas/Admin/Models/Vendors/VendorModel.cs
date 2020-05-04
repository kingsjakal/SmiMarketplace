using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Smi.Core.Domain.Catalog;
using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Vendors
{
    /// <summary>
    /// Represents a vendor model
    /// </summary>
    public partial class VendorModel : BaseSmiEntityModel, ILocalizedModel<VendorLocalizedModel>
    {
        #region Ctor

        public VendorModel()
        {
            if (PageSize < 1)
                PageSize = 5;

            Address = new AddressModel();
            VendorAttributes = new List<VendorAttributeModel>();
            Locales = new List<VendorLocalizedModel>();
            AssociatedCustomers = new List<VendorAssociatedCustomerModel>();
            VendorNoteSearchModel = new VendorNoteSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Vendors.Fields.Name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.Vendors.Fields.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.Description")]
        public string Description { get; set; }

        [UIHint("Picture")]
        [SmiResourceDisplayName("Admin.Vendors.Fields.Picture")]
        public int PictureId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.AdminComment")]
        public string AdminComment { get; set; }

        public AddressModel Address { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.Active")]
        public bool Active { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }        

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.SeName")]
        public string SeName { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.PageSize")]
        public int PageSize { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        public List<VendorAttributeModel> VendorAttributes { get; set; }

        public IList<VendorLocalizedModel> Locales { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.AssociatedCustomerEmails")]
        public IList<VendorAssociatedCustomerModel> AssociatedCustomers { get; set; }

        //vendor notes
        [SmiResourceDisplayName("Admin.Vendors.VendorNotes.Fields.Note")]
        public string AddVendorNoteMessage { get; set; }

        public VendorNoteSearchModel VendorNoteSearchModel { get; set; }

        #endregion

        #region Nested classes
        
        public partial class VendorAttributeModel : BaseSmiEntityModel
        {
            public VendorAttributeModel()
            {
                Values = new List<VendorAttributeValueModel>();
            }

            public string Name { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<VendorAttributeValueModel> Values { get; set; }
        }

        public partial class VendorAttributeValueModel : BaseSmiEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }

        #endregion
    }

    public partial class VendorLocalizedModel : ILocalizedLocaleModel
    {
        public int LanguageId { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.Name")]
        public string Name { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.Description")]
        public string Description { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [SmiResourceDisplayName("Admin.Vendors.Fields.SeName")]
        public string SeName { get; set; }
    }
}