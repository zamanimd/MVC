using Microsoft.AspNetCore.Mvc;
using MVCCore6.Models;
using MVCCore6.Data;

namespace MVCCore6.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            List<Product> lst_Products = ProductData.GetProducts();

            //List<ProductCategory> lst_ProductCategory = new List<ProductCategory>()
            //{
            //    new ProductCategory("Cat1"),
            //    new ProductCategory("Cat2"),
            //    new ProductCategory("Cat3"),
            //    new ProductCategory("Cat4")
            //};

            //ViewData["ProductCategory"] = lst_ProductCategory;

            return View("Products", lst_Products);
        }

    }
}
