
namespace Smi.Web.Framework.Models
{
    /// <summary>
    /// Represents base SmiMarketplace entity model
    /// </summary>
    public partial class BaseSmiEntityModel : BaseSmiModel
    {
        /// <summary>
        /// Gets or sets model identifier
        /// </summary>
        public virtual int Id { get; set; }
    }
}