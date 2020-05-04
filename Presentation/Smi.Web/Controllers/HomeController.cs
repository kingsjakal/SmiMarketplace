using Microsoft.AspNetCore.Mvc;

namespace Smi.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}