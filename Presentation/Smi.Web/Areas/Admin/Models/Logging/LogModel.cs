using System;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Logging
{
    /// <summary>
    /// Represents a log model
    /// </summary>
    public partial class LogModel : BaseSmiEntityModel
    {
        #region Properties

        [SmiResourceDisplayName("Admin.System.Log.Fields.LogLevel")]
        public string LogLevel { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.ShortMessage")]
        public string ShortMessage { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.FullMessage")]
        public string FullMessage { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.IPAddress")]
        public string IpAddress { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.Customer")]
        public int? CustomerId { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.PageURL")]
        public string PageUrl { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.ReferrerURL")]
        public string ReferrerUrl { get; set; }

        [SmiResourceDisplayName("Admin.System.Log.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #endregion
    }
}