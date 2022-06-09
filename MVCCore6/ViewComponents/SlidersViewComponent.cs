using Microsoft.AspNetCore.Mvc;
using MVCCore6.Models;
using MVCCore6.Data;

namespace MVCCore6.ViewComponents
{
    public class SlidersViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Slider> lst_Sliders = SliderData.GetSliders();

            return View("Sliders", lst_Sliders);
        }

    }
}
