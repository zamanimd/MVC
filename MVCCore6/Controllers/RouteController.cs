using Microsoft.AspNetCore.Mvc;

namespace MVCCore6.Controllers
{
    public class RouteController : Controller
    {
        //--- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-6.0 ---//

        [Route("/invertory/products")]
        //--- localhost:1001/invertory/products ---//


        [Route("Index")]
        //--- localhost:1001/invertory/products/Index ---//
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("MyIndex")]
        //--- localhost:1001/invertory/products/MyIndex ---//
        public IActionResult MyIndex()
        {
            return View();
        }


        [HttpGet("MyIndexid/{id?}")]
        //[HttpGet("MyIndexid/{id?}/{name?}/{model?}")]
        //--- Get id from url (Manual Routing)
        //--- localhost:1001/invertory/products/MyIndexid/23 ---//
        public IActionResult MyIndexid(int id)
        {
            return View();
        }

        //--- Get id from url (Default Routing)
        //--- localhost:1001/invertory/products/MyIndexMyid/23 ---//
        public IActionResult MyIndexMyid(int id)
        {
            return View();
        }

    }
}
