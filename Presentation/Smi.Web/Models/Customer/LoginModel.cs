using System.ComponentModel.DataAnnotations;
using Smi.Core.Domain.Customers;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Customer
{
    public partial class LoginModel : BaseSmiModel
    {
        public bool CheckoutAsGuest { get; set; }

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Account.Login.Fields.Email")]
        public string Email { get; set; }

        public bool UsernamesEnabled { get; set; }

        public UserRegistrationType RegistrationType { get; set; }

        [SmiResourceDisplayName("Account.Login.Fields.Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [NoTrim]
        [SmiResourceDisplayName("Account.Login.Fields.Password")]
        public string Password { get; set; }

        [SmiResourceDisplayName("Account.Login.Fields.RememberMe")]
        public bool RememberMe { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}