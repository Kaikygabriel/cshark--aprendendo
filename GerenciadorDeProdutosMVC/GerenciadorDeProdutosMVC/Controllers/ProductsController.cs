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

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", "Id not previded");

            var obj = _productsRepository.FindById(id);
            if(obj is null)
                return RedirectToAction("Error", "Id not previded");

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id,Product product)
        {
            if (id == null)
                return RedirectToAction("Error", "Id not found");
            try
            {
                _productsRepository.Update(product);
            }
            catch(ApplicationException e)
            {
                return RedirectToAction("Error", e.Message);

            }

            return RedirectToAction("Index");
        }
        public IActionResult Error(string menssage)
        {
            var viewModel = new ErrorViewModel { Menssage = menssage };
            return View(viewModel);
        }
    }

}
