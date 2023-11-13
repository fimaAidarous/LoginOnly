using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectWithLogin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
