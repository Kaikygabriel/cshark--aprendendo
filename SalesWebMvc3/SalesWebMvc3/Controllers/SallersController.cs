using Microsoft.AspNetCore.Mvc;
using SalesWebMvc3.Models;
using SalesWebMvc3.Services;

namespace SalesWebMvc3.Controllers
{
    public class SallersController : Controller
    {
        public SallersController(SallerService sallerService)
        {
            _serviceSaller = sallerService;
        }
        private readonly SallerService _serviceSaller;
        
        public IActionResult Index()
        {
            var sallers = _serviceSaller.FindAll();

            return View(sallers);
        }
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Saller saller)
        {
            _serviceSaller.AddSallerRepository(saller);
            return RedirectToAction("Index");
        }
    }
}
