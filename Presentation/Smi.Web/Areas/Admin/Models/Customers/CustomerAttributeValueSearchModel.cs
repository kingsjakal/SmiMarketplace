using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Customers
{
    /// <summary>
    /// Represents a customer attribute value search model
    /// </summary>
    public partial class CustomerAttributeValueSearchModel : BaseSearchModel
    {
        #region Properties

        public int CustomerAttributeId { get; set; }

        #endregion
    }
}