using GerenciadorDeProdutosMVC.Models;
using GerenciadorDeProdutosMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

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

        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();

            var obj = _productsRepository.FindById(id);
            if(obj is null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Product product)
        {
            var obj = _productsRepository.FindById(product.Id);
           
            obj = product;

            _productsRepository.Remove(obj.Id);
            _productsRepository.AddProducts(obj);

            return RedirectToAction("Index");
        }
    }

}
