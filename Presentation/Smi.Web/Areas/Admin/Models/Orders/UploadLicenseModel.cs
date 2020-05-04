using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Orders
{
    /// <summary>
    /// Represents an upload license model
    /// </summary>
    public partial class UploadLicenseModel : BaseSmiModel
    {
        #region Properties

        public int OrderId { get; set; }

        public int OrderItemId { get; set; }

        [UIHint("Download")]
        public int LicenseDownloadId { get; set; }

        #endregion
    }
}