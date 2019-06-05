using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MundoDePatitas.Models;
namespace MundoDePatitas.Controllers
{
    public class PetController:Controller
    {
        public IActionResult Mascotas()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}