using GerenciadorDeTarefasMvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefasMvc.Controllers
{
    public class TaskController : Controller
    {
        private readonly ServiceDataTask _serviceDataTask;
        public TaskController(ServiceDataTask serviceDataTask)
        {
            _serviceDataTask = serviceDataTask;
        }

        public IActionResult Index()
        {
            var list = _serviceDataTask.FindAll();
            return View(list);
        }


    }
}
