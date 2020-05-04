using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Customer
{
    public partial class PasswordRecoveryConfirmModel : BaseSmiModel
    {
        [DataType(DataType.Password)]
        [NoTrim]
        [SmiResourceDisplayName("Account.PasswordRecovery.NewPassword")]
        public string NewPassword { get; set; }
        
        [NoTrim]
        [DataType(DataType.Password)]
        [SmiResourceDisplayName("Account.PasswordRecovery.ConfirmNewPassword")]
        public string ConfirmNewPassword { get; set; }

        public bool DisablePasswordChanging { get; set; }
        public string Result { get; set; }
    }
}