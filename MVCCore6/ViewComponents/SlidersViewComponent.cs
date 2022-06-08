using Microsoft.AspNetCore.Mvc;

namespace MVCCore6.ViewComponents
{
    public class SlidersViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            //List<Project> lst_Projects = new List<Project>()
            //{
            //    new Project(1,"Portfolio 1","Portfolio 1 descripton.","Cat1","portfolio-1.jpg"),
            //    new Project(1,"Portfolio 2","Portfolio 2 descripton.","Cat2","portfolio-2.jpg"),
            //    new Project(1,"Portfolio 3","Portfolio 3 descripton.","Cat3","portfolio-3.jpg"),
            //    new Project(1,"Portfolio 4","Portfolio 4 descripton.","Cat4","portfolio-4.jpg"),
            //    new Project(1,"Portfolio 5","Portfolio 5 descripton.","Cat1","portfolio-5.jpg"),
            //    new Project(1,"Portfolio 6","Portfolio 6 descripton.","Cat2","portfolio-6.jpg"),
            //    new Project(1,"Portfolio 7","Portfolio 7 descripton.","Cat3","portfolio-7.jpg"),
            //    new Project(1,"Portfolio 8","Portfolio 8 descripton.","Cat1","portfolio-8.jpg"),
            //    new Project(1,"Portfolio 9","Portfolio 9 descripton.","Cat1","portfolio-9.jpg")
            //};

            //List<ProjectCategory> lst_ProjectCategory = new List<ProjectCategory>()
            //{
            //    new ProjectCategory("Cat1"),
            //    new ProjectCategory("Cat2"),
            //    new ProjectCategory("Cat3"),
            //    new ProjectCategory("Cat4")
            //};

            //ViewData["ProjectCategory"] = lst_ProjectCategory;

            //return View("Products", lst_Projects);
            return View("Sliders");
        }

    }
}
