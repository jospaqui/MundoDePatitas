using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patitas.Data;
using Patitas.Models;
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

         public IActionResult AddPet()
        {
            ViewBag.Mascota = _context.Mascotas.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddPet(Mascota m)
        {
            if (ModelState.IsValid){
                _context.Add(m);
                _context.SaveChanges();

                return RedirectToAction("Admin","Admin");
            }
            ViewBag.Mascota = _context.Mascotas.ToList();

            return View();
        }
    }
}