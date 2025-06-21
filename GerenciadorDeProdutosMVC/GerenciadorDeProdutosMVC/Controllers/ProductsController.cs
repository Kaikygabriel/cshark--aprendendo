using GerenciadorDeProdutosMVC.Models;
using GerenciadorDeProdutosMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeProdutosMVC.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController(ServiceProductsRepository pd) 
        { 
            _productsRepository = pd;
        }
        private readonly ServiceProductsRepository _productsRepository;
        public IActionResult Index()
        {
            var list = _productsRepository.FindAll(); 
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            _productsRepository.AddProducts(product);
            return RedirectToAction("Index");
        }
    }
}
