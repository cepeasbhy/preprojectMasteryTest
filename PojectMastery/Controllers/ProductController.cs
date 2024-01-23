using Microsoft.AspNetCore.Mvc;
using PojectMastery.Models;

namespace PojectMastery.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult AddProduct() {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
           
            return StatusCode(200);
        }

        public IActionResult UpdateProduct(int id) {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            return StatusCode(200);
        }

        public IActionResult GetAllProducts() {
            return PartialView("~/Views/Shared/Partials/_ProductList.cshtml");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int Id) {
            Console.WriteLine(Id);
            return StatusCode(200);
        }
    }
}
