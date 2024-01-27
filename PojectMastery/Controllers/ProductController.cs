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

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetProductById(id);
            return View(product);
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
            
            var product = productInput.ToProduct();
            product.urlPhoto = urlPhoto;
            
            var res = await _productRepository.AddProduct(product);
            return res != 0 ? StatusCode(200) : BadRequest();
        }

        public async Task<IActionResult> UpdateProduct(int id)
        {
            var categories = await _categoryRepository.GetAllCategories();
            ViewBag.Categories = categories;
            
            var product = await _productRepository.GetProductById(id);
            return View(new ProductInput(product));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(int id, ProductInput productInput)
        {
            var product = productInput.ToProduct();
            if (productInput.productPhoto != null)
            {
                var urlPhoto = _fileUpload.Save(productInput.productPhoto);
                product.urlPhoto = urlPhoto;
            }

            await _productRepository.UpdateProduct(id, product);
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
