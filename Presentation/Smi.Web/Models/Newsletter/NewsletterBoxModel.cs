using System.ComponentModel.DataAnnotations;
using Smi.Web.Framework.Models;

namespace Smi.Web.Models.Newsletter
{
    public partial class NewsletterBoxModel : BaseSmiModel
    {
        [DataType(DataType.EmailAddress)]
        public string NewsletterEmail { get; set; }
        public bool AllowToUnsubscribe { get; set; }
    }
}