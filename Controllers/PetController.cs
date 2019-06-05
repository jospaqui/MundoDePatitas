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
    public class PetController:Controller
    {
      
        private MascotaContext _context; //el contexto 

        public PetController (MascotaContext c){ //el constructor del contexto
            _context = c;

        }

        //registrar mascotas
        public IActionResult RegistrarMascota(){
            ViewBag.tipos = _context.Tipos.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarMascota(Mascota m){
            if(ModelState.IsValid)
            {
                _context.Add(m);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.tipos = _context.Tipos.ToList();
            return View();
        }
    }
}
    
    