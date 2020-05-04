using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Common
{
    /// <summary>
    /// Represents a backup file model
    /// </summary>
    public partial class BackupFileModel : BaseSmiModel
    {
        #region Properties
        
        public string Name { get; set; }
        
        public string Length { get; set; }
        
        public string Link { get; set; }
        
        #endregion
    }
}