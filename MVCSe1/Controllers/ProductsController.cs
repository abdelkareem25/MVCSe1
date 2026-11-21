using Microsoft.AspNetCore.Mvc;
using MVCSe1.Models;

namespace MVCSe1.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetJsonResult()
        {
            return new JsonResult(new List<Products>
            {
                new Products { Id = 1, Name = "Product 1", Price = 10.99m },
                new Products { Id = 2, Name = "Product 2", Price = 19.99m },
                new Products { Id = 3, Name = "Product 3", Price = 5.99m }
            });
        }

        [HttpGet]
        public FileContentResult DownloadFile()
        {
            var data = System.IO.File.ReadAllBytes("wwwroot/files/favicon.ico");
            return File(data, "image/x-icon");
        }

        [HttpGet]
        public RedirectResult RedirectToGoogle()
        {
            return new RedirectResult("https://www.google.com");
        }
    }
}
