using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

using MVCCore6.Models;
using MVCCore6.Data;

namespace MVCCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ProductDetail(int id)
        {
            var product = ProductData.GetProductInfo(id);
            return View(product);
        }



        //--- Contact Form ---//

        private readonly List<ContactSubject> lst_ContactSubject = new List<ContactSubject>()
        {
            new ContactSubject("Contact","Contact Us"),
            new ContactSubject("Issue","Report Issue"),
            new ContactSubject("Other","Other")
        };


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                lst_Subjects = new SelectList(lst_ContactSubject, "Value", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.lst_Subjects = new SelectList(lst_ContactSubject, "Value", "Name");

            if (!ModelState.IsValid)
            {
                ViewBag.Msg_Error = "your entered data is not correct.";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact()
            {
                lst_Subjects = new SelectList(lst_ContactSubject, "Value", "Name")
            };
            ViewBag.Msg_Success = "Your message has been sent.";
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        //--------------------//



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}