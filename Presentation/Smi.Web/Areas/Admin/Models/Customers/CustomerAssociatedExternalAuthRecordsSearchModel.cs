using System.Collections.Generic;
using Smi.Web.Framework.Models;
using Smi.Web.Framework.Mvc.ModelBinding;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a associated external auth records search model
    /// </summary>
    public class CustomerAssociatedExternalAuthRecordsSearchModel : BaseSearchModel
    {
        #region Properties

        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth")]
        public IList<CustomerAssociatedExternalAuthModel> AssociatedExternalAuthRecords { get; set; } = new List<CustomerAssociatedExternalAuthModel>();
        
        #endregion
    }
}
