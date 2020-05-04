using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Customer
{
    public partial class PasswordRecoveryModel : BaseSmiModel
    {
        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Account.PasswordRecovery.Email")]
        public string Email { get; set; }

        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}