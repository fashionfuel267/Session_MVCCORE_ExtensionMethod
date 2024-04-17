using M06C13_Session.Models;
using M06C13_Session.SessionHElper;
using Microsoft.AspNetCore.Mvc;

namespace M06C13_Session.Controllers
{
    public class SessionExController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult UserData()
        {
            var t = HttpContext.Session.GetSessionObj<UserInfo>("userobj") ?? null;
            if (t == null)
                return NotFound();

            return View(t);
        }
    }
}
