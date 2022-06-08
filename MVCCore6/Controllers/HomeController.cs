﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCore6.Models;
using System.Diagnostics;

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
        //--------------------//



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}