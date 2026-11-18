using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class ProductsController: Controller
    {
        public JsonResult GetProducts()
        {
            return new JsonResult(new List< Product>() 
            {
                new Product { Id = 1,Name="laptop",Price=50000 },
                new Product { Id =2, Name="phone",Price=7000 },
                new Product { Id = 3,Name="Iphone",Price=30000 }


            });
           
        }
        // /Products/Index
        public ViewResult Index()
        {
            return new ViewResult();
        }


        [HttpGet]
        public IActionResult yallakora()
        {
            return  Redirect("https://www.yallakora.com");
        }
    }
}
