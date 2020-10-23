using Microsoft.AspNetCore.Mvc;

namespace comItMvc.Controllers
{
    public class CursosController : Controller
    {
        public CursosController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}