using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult AddPet()
        {
            ViewBag.TipoMascotas = _context.TipoMascotas.ToList();

            return View();
        }

         [HttpPost]
         public IActionResult AddPet(ViewModels.AddPetViewModel m) {
            var IdUsuario = _userManager.Users.FirstOrDefault(u => u.Id == User.Identity.Name);
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
                    IdMascota=m.IdTipoMascota
                    };
                    
                _context.Mascotas.Add(pet);
                _context.SaveChanges();
            }
            else{
              RedirectToAction("Home","Index");
            }
            
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

                return RedirectToAction("Admin","Admin");
            }

            return View();
        }
        public IActionResult Refugios(){
          var Refugio = _context.Refugios.ToList();
          return View(Refugio);
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
          var Mascota = _context.Mascotas.ToList();
          return View(Mascota);
        }
    }
}