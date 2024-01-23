using Microsoft.AspNetCore.Mvc;
using PojectMastery.Models;
using System.Diagnostics;

namespace PojectMastery.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
