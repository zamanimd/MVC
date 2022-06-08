using Microsoft.AspNetCore.Mvc;
using MVCCore6.Models;

namespace MVCCore6.ViewComponents
{
    public class SlidersViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Slider> lst_Sliders = new List<Slider>()
            {
                new Slider(1,"Example headline.","Some representative placeholder content for the first slide of the carousel.","Sign up Today","Slider-1.jpg","start"),
                new Slider(2,"Another example headline.","Some representative placeholder content for the second slide of the carousel.","Learn More","Slider-2.jpg",""),
                new Slider(3,"One more for good measure.","Some representative placeholder content for the second slide of the carousel.","Browse Gallery","Slider-3.jpg","end")
            };

            return View("Sliders", lst_Sliders);
        }

    }
}
