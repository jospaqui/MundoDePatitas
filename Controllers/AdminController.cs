using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patitas.Data;
using Patitas.Models;

namespace Patitas.Controllers
{
    public class AdminController:Controller
    {
      private MascotaContext _context; //el contexto 
      private UserManager<IdentityUser> _userManager;
      private SignInManager<IdentityUser> _signInManager;
	    
      
        
        public AdminController(
            MascotaContext c,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim
        ){
            _context=c;
            _userManager=um;
            _signInManager=sim;

        }

        public IActionResult Dashboard()
        {

          ViewBag.Mascotas=_context.Mascotas.Count();
          return View();
        }
        public IActionResult AddPet()
        {

            return View();
        }

         [HttpPost]
         public IActionResult AddPet(ViewModels.AddPetViewModel m) {
            if (ModelState.IsValid) {
                var pet = new Mascota { 
                    Nombre= m.Nombre, 
                    Sexo=m.Sexo,
                    Tamaño=m.Tamaño,
                    PuedeEstarSolo=m.PuedeEstarSolo,
                    Personalidades=m.Personalidades,
                    Edad=m.Edad,
                    Descripcion=m.Descripcion,
                    Direccion=m.Direccion,
                    FechaRegistro=DateTime.Now,
                    Estado=m.Estado,
                    TipoMascotaId=m.TipoMascotaId,
                    RefugioId=m.RefugioId
                    
                    };
                    
                _context.Mascotas.Add(pet);
                _context.SaveChanges();
             return RedirectToAction("Pets","Admin");

            }
            int userId =Int32.Parse(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            ViewBag.Refugio = _context.Refugios.Where(x=>x.Id==userId);

            return View(m);
         }

       
        public IActionResult AddRefugio()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [HttpPost]
        public IActionResult AddRefugio(ViewModels.AddRefugioViewModel r) { 
              if (ModelState.IsValid){
                
                _context.Add(r);
                _context.SaveChanges();

                return RedirectToAction("Refugios","Admin");
            }

            return View();
        }
        public IActionResult Refugios(){
          ViewBag.Refugio = _context.Refugios.ToList();
          return View();
        }
        public IActionResult Veterinarias(){
          var Veterinaria = _context.Veterinarias.ToList();
          return View(Veterinaria);
        }


        public IActionResult AddVeterinaria() { 
            return View(); 
        }
        [HttpPost]
        public IActionResult AddVeterinaria(Veterinaria v) { 
              if (ModelState.IsValid){
                _context.Veterinarias.Add(v);
                _context.SaveChanges();

                return RedirectToAction("Veterinarias");
            }
            return View(v);
        }
        public IActionResult Pets()
        {
          ViewBag.MascotasLista=_context.Mascotas.Include(x=>x.TipoMascota).ToList();

          return View();
        }
        public IActionResult Users()
        {
          return View();
        }
    }
}