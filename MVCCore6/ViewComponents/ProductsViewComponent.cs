using Microsoft.AspNetCore.Mvc;
using MVCCore6.Models;

namespace MVCCore6.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Product> lst_Products = new List<Product>()
            {
                new Product(1,"Product 1","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat1","Product-1.jpg"),
                new Product(2,"Product 2","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat2","Product-2.jpg"),
                new Product(3,"Product 3","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat3","Product-3.jpg"),
                new Product(4,"Product 4","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat4","Product-4.jpg"),
                new Product(5,"Product 5","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat1","Product-5.jpg"),
                new Product(6,"Product 6","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat2","Product-6.jpg"),
                new Product(7,"Product 7","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat3","Product-7.jpg"),
                new Product(8,"Product 8","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat1","Product-8.jpg"),
                new Product(9,"Product 9","This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.","Cat1","Product-9.jpg")
            };

            //List<ProjectCategory> lst_ProjectCategory = new List<ProjectCategory>()
            //{
            //    new ProjectCategory("Cat1"),
            //    new ProjectCategory("Cat2"),
            //    new ProjectCategory("Cat3"),
            //    new ProjectCategory("Cat4")
            //};

            //ViewData["ProjectCategory"] = lst_ProjectCategory;

            return View("Products", lst_Products);
        }

    }
}
