using Smi.Web.Areas.Admin.Models.Common;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Affiliates
{
    /// <summary>
    /// Represents an affiliate model
    /// </summary>
    public partial class AffiliateModel : BaseSmiEntityModel
    {
        #region Ctor

        public AffiliateModel()
        {
            Address = new AddressModel();
            AffiliatedOrderSearchModel= new AffiliatedOrderSearchModel();
            AffiliatedCustomerSearchModel = new AffiliatedCustomerSearchModel();
        }

        #endregion

        #region Properties

        [SmiResourceDisplayName("Admin.Affiliates.Fields.URL")]
        public string Url { get; set; }
        
        [SmiResourceDisplayName("Admin.Affiliates.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [SmiResourceDisplayName("Admin.Affiliates.Fields.FriendlyUrlName")]
        public string FriendlyUrlName { get; set; }
        
        [SmiResourceDisplayName("Admin.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        public AffiliatedOrderSearchModel AffiliatedOrderSearchModel { get; set; }

        public AffiliatedCustomerSearchModel AffiliatedCustomerSearchModel { get; set; }

        #endregion
    }
}