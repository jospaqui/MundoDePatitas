using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MundoDePatitas.ViewModels;
using Patitas.Data;
using Patitas.Models;
using static System.Net.Mime.MediaTypeNames;

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
            ViewBag.TipoMascotas = _context.TipoMascotas.ToList();

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


        public IActionResult AddVeterinaria() { 
             ViewBag.Veterinarias = _context.Veterinarias.ToList();
            return View(); 
        }
        [HttpPost]
        public IActionResult AddVeterinaria(Veterinaria v) { 
              if (ModelState.IsValid){
                _context.Add(v);
                _context.SaveChanges();

                return RedirectToAction("Admin","Admin");
            }
             ViewBag.Veterinarias = _context.Veterinarias.ToList();
            return View();
        }
        
    }
}