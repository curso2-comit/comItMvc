using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using comItMvc.Models;

namespace comItMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Hola()
        {
            return "Hola mundo!!!!";
        }

        public string Saludar(string nombre)
        {
            //return "Hola " + nombre;
            return $"Hola {nombre}";
        }

        public IActionResult SaludarConVista(string nombre)
        {
            this.ViewBag.Nombre = nombre;
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarContacto(string nombre, 
            string mail, string consulta)
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
