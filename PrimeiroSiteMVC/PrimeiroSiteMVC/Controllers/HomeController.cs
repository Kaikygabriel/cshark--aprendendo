using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeiroSiteMVC.Models;

namespace PrimeiroSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult ExibirTexto(string texto, string email)
        {
            ViewBag.Texto = texto;  // Passa o valor para a View
            ViewBag.email = email;
            return View("Index");  // Retorna para a página inicial
        }
    }
}
