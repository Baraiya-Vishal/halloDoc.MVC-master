using halloDoc.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace halloDoc.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Patient_forgot_password()
        {
            return View();
        }
        public IActionResult Patient_login()
        {
            return View();
        }

        public IActionResult Dashboard()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}