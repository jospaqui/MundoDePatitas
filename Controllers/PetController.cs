using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patitas.Data;
using Patitas.Models;
namespace Patitas.Controllers
{
    public class PetController:Controller
    {
      
        private MascotaContext _context; //el contexto 

        public PetController (MascotaContext c){ //el constructor del contexto
            _context = c;

        }

       public IActionResult AllPets()
       {
         //TODO: Implement Realistic Implementation
         return View();
       }
       public IActionResult ViewPet()
       {
         //TODO: Implement Realistic Implementation
         return View();
       }
       public IActionResult Categorias()
       {
         //TODO: Implement Realistic Implementation
         return View();
       }
    }
}
    
    