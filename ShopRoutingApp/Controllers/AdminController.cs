using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShopRoutingApp.Controllers
{
    public class AdminController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = context.ActionDescriptor.RouteValues["action"];
            if (actionName != null && !actionName.EndsWith("setup", StringComparison.OrdinalIgnoreCase))
            {
                context.Result = NotFound();
            }
            base.OnActionExecuting(context);
        }

        public IActionResult Setup()
        {
            return View();
        }

        public IActionResult AnotherAction()
        {
            return View();
        }
    }
}
