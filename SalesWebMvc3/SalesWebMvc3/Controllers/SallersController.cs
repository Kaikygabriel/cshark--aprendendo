using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc3.Controllers
{
    public class SallersController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
