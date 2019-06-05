using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MundoDePatitas.Datos;
using MundoDePatitas.Models;
namespace MundoDePatitas.Controllers
{
    public class AdminController:Controller
    {
      private MascotaContext _context; //el contexto 

      public AdminController (MascotaContext c){ //el constructor del contexto
            _context = c;

      }
        public IActionResult Admin()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}