using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Mvc.ModelBinding;
using Smi.Web.Framework.Models;

namespace Smi.Web.Areas.Admin.Models.Messages
{
    /// <summary>
    /// Represents an email account model
    /// </summary>
    public partial class EmailAccountModel : BaseSmiEntityModel
    {
        #region Properties

        [DataType(DataType.EmailAddress)]
        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Email")]
        public string Email { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.DisplayName")]
        public string DisplayName { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Host")]
        public string Host { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Port")]
        public int Port { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Username")]
        public string Username { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Password")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string Password { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.EnableSsl")]
        public bool EnableSsl { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.UseDefaultCredentials")]
        public bool UseDefaultCredentials { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.IsDefaultEmailAccount")]
        public bool IsDefaultEmailAccount { get; set; }

        [SmiResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.SendTestEmailTo")]
        public string SendTestEmailTo { get; set; }

        #endregion
    }
}