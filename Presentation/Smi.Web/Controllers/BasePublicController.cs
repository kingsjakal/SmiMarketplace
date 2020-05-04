using Microsoft.AspNetCore.Mvc;
using Smi.Web.Framework.Controllers;
using Smi.Web.Framework.Mvc.Filters;

namespace Smi.Web.Controllers
{
    [WwwRequirement]
    [CheckAccessPublicStore]
    [CheckAccessClosedStore]
    [CheckLanguageSeoCode]
    [CheckDiscountCoupon]
    [CheckAffiliate]
    public abstract partial class BasePublicController : BaseController
    {
        protected virtual IActionResult InvokeHttp404()
        {
            Response.StatusCode = 404;
            return new EmptyResult();
        }
    }
}