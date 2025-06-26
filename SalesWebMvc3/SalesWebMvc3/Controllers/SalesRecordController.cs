using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc3.Controllers
{
    public class SalesRecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }
        public IActionResult GroupSearch()
        {
            return View();
        }

    }
}
