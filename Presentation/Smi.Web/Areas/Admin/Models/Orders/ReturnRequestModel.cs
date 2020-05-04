using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents a return request model
    /// </summary>
    public partial class ReturnRequestModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.CustomNumber")]
        public string CustomNumber { get; set; }
        
        public int OrderId { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.CustomOrderNumber")]
        public string CustomOrderNumber { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public int CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerInfo { get; set; }

        public int ProductId { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Product")]
        public string ProductName { get; set; }

        public string AttributeInfo { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Quantity")]
        public int Quantity { get; set; }
        
        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.ReasonForReturn")]
        public string ReasonForReturn { get; set; }
        
        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.RequestedAction")]
        public string RequestedAction { get; set; }
        
        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.CustomerComments")]
        public string CustomerComments { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.UploadedFile")]
        public Guid UploadedFileGuid { get; set; }
        
        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.StaffNotes")]
        public string StaffNotes { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public int ReturnRequestStatusId { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public string ReturnRequestStatusStr { get; set; }

        [SmiResourceDisplayName("Admin.ReturnRequests.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}