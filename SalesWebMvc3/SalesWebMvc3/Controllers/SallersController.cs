using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using MySqlConnector;
using SalesWebMvc3.Models;
using SalesWebMvc3.Models.ViewModels;
using SalesWebMvc3.Services;
using SalesWebMvc3.Services.Exceptions;

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
            var departaments = _departamentservice.FindAll();
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


        public IActionResult Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id is null" });

            var obj = _serviceSaller.FindById(id);
            if (obj == null)
                return RedirectToAction("Error", new {menssage ="Id not found"});

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });

            var obj = _serviceSaller.FindById(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });
            _serviceSaller.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id is null" });

            var obj = _serviceSaller.FindById(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });
            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id not provided" });

            var obj = _serviceSaller.FindById(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not provided" });

            var departaments = _departamentservice.FindAll();
            var viewModel = new SallerFormViewModel { Departaments = departaments, Saller = obj };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SallerFormViewModel obj)
        {
            if (id != obj.Saller.Id)
                return RedirectToAction("Error", new { menssage = "Ids not equals" });
            try
            {
                _serviceSaller.Update(obj.Saller);
                return RedirectToAction("Index");
            }
            catch (ApplicationException e)
            {
                return RedirectToAction("Error", new { menssage = e.Message });
            }
        }
        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel { Message = message ,RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier};
            return View(viewModel);
        }
    }
}
