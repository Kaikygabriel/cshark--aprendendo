using Microsoft.AspNetCore.Mvc;
using SalesWebMvc3.Models;
using SalesWebMvc3.Models.ViewModels;
using SalesWebMvc3.Services;

namespace SalesWebMvc3.Controllers
{
    public class SallersController : Controller
    {
        public SallersController(SallerService sallerService, DepartamentService departamentservice)
        {
            _serviceSaller = sallerService;
            _departamentservice = departamentservice;
        }
        private readonly SallerService _serviceSaller;
        private readonly DepartamentService _departamentservice;   

        public IActionResult Index()
        {
            var sallers = _serviceSaller.FindAll();

            return View(sallers);
        }
        public IActionResult Create() 
        {
            var departaments =  _departamentservice.FindAll();
            var viewModel = new SallerFormViewModel { Departaments = departaments };

            return View(viewModel);
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
