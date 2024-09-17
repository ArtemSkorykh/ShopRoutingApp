using Microsoft.AspNetCore.Mvc;

namespace ShopRoutingApp.Controllers
{
    public class ShopController : Controller
    {
        [Route("newOrder")]
        public IActionResult Buy()
        {
            return View();
        }
    }
}
