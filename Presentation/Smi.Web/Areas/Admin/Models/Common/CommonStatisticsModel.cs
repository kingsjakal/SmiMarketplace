using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    public partial class CommonStatisticsModel : BaseSmiModel
    {
        public int NumberOfOrders { get; set; }

        public int NumberOfCustomers { get; set; }

        public int NumberOfPendingReturnRequests { get; set; }

        public int NumberOfLowStockProducts { get; set; }
    }
}