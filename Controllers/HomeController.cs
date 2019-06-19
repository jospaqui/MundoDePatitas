using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patitas.Models;

namespace Patitas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ListadoVeterinaria(){
            return View();
        }
        
        public IActionResult Index()
        {
            return View();
        }

          public IActionResult Contacto()
        {
            return View();
        }

























        public IActionResult Privacy()
        {
            return View();
        }

    }
}
