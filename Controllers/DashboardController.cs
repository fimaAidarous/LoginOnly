using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace ProjectWithLogin.Controllers
{
   [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
