using halloDoc.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace halloDoc.MVC.Controllers
{
    public class RequestController : Controller
    {
        private readonly ILogger<RequestController> _logger;

        public RequestController(ILogger<RequestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult Create_business_request()
        {
            return View();
        }
        public IActionResult Create_concierge_request()
        {
            return View();
        }
        public IActionResult Create_family_friend_request()
        {
            return View();
        }
        public IActionResult Create_patient_request()
        {
            return View();
        }
        public IActionResult Submit_patient_request()
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