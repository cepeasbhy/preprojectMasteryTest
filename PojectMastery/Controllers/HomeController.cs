using Microsoft.AspNetCore.Mvc;
using PojectMastery.Interfaces;
using PojectMastery.Models;
using System.Data;
using System.Diagnostics;

namespace PojectMastery.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _connection;

        public HomeController(IProductRepository connection) { 
            _connection = connection;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.totalProducts = await _connection.GetTotalProducts();
            ViewBag.totalCategories = await _connection.GetTotalCategories();

            return View();
        }
    }
}
