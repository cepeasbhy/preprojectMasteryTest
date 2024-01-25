using Microsoft.AspNetCore.Mvc;
using PojectMastery.Interfaces;
using PojectMastery.Models;
using PojectMastery.Views.Shared.Inputs;

namespace PojectMastery.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IFileUpload _fileUpload;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, IFileUpload fileUpload, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _fileUpload = fileUpload;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Details(int id)
        {
            return View();
        }
        
        public async Task<IActionResult> AddProduct()
        {
            var categories = await _categoryRepository.GetAllCategories();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductInput productInput)
        {
            var urlPhoto = _fileUpload.Save(productInput.productPhoto);
            var product = new Product(
                    productInput.name,
                    productInput.description,
                    urlPhoto,
                    productInput.sku,
                    productInput.size,
                    productInput.color,
                    categoryId: int.Parse(productInput.categoryId),
                    productInput.weight,
                    productInput.price
                );
            
            var res = await _productRepository.AddProduct(product);
            return res != 0 ? StatusCode(200) : BadRequest();
        }

        public IActionResult UpdateProduct(int id) {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            return StatusCode(200);
        }

        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();
            return PartialView("~/Views/Shared/Partials/_ProductList.cshtml", products);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int Id) {
            return StatusCode(200);
        }
    }
}
