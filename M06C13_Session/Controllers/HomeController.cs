using M06C13_Session.Models;
using M06C13_Session.SessionHElper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace M06C13_Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         string SessionUserId = "uu";
         string SessionUserName = "uuu";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionUserName, "WADA/ACSL-A/58/01");
            HttpContext.Session.SetInt32(SessionUserId, 1234567);
            var user = new UserInfo
            {
                Id = 5,
                Name = "Wada-58"
            };
            HttpContext.Session.SetObjInSession("userobj", user);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string GetSession()
        {
            string? UserName = HttpContext.Session.GetString(SessionUserName);
            int? UserId = HttpContext.Session.GetInt32(SessionUserId);
            string Message = $"UserName: {UserName}, UserId: {UserId}";
            return Message;
            
        }
    }
}
