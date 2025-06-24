using System.Diagnostics;
using System.Threading.Tasks;
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

        public async Task<IActionResult> Index()
        {
            var sallers = await _serviceSaller.FindAllAsync();

            return View(sallers);
        }
        public async Task<IActionResult> Create()
        {
            var departaments = await _departamentservice.FindAllAsync();
            var viewModel = new SallerFormViewModel { Departaments = departaments };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Saller saller)
        {
            if (!ModelState.IsValid)
                return View(new SallerFormViewModel { Departaments = await _departamentservice.FindAllAsync(), Saller = saller});

            await _serviceSaller.AddSallerRepositoryAsync(saller);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id is null" });

            var obj = await _serviceSaller.FindByIdAsync(id);
            if (obj == null)
                return RedirectToAction("Error", new {menssage ="Id not found"});

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });

            var obj = await _serviceSaller.FindByIdAsync(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });
            await _serviceSaller.RemoveAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id is null" });

            var obj = await _serviceSaller.FindByIdAsync(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not found" });
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return RedirectToAction("Error", new { menssage = "Id not provided" });

            var obj = await _serviceSaller.FindByIdAsync(id);
            if (obj == null)
                return RedirectToAction("Error", new { menssage = "Id not provided" });

            var departaments = await _departamentservice.FindAllAsync();
            var viewModel = new SallerFormViewModel { Departaments = departaments, Saller = obj };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SallerFormViewModel obj)
        {
            if (id != obj.Saller.Id)
                return RedirectToAction("Error", new { menssage = "Ids not equals" });

            if (!ModelState.IsValid)
                return View(obj);

            try
            {
                await _serviceSaller.UpdateAsync(obj.Saller);
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
