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
        public IActionResult RegisterPet(){
            return View();
        }
       
    }
}
    
    