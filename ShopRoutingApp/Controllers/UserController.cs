using Microsoft.AspNetCore.Mvc;

namespace ShopRoutingApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Settings(int id)
        {
           
            if (id < 1 || id > 999)
            {
                return NotFound(); 
            }

            ViewData["UserId"] = id; 
            return View();
        }
    }
}
