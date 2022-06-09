using Microsoft.AspNetCore.Mvc;
using MVCCore6.Models;
using MVCCore6.Data;

namespace MVCCore6.ViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Service> lst_Services = ServiceData.GetServices(); 

            return View("Services", lst_Services);
        }

    }
}
