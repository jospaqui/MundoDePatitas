    
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
    public class CategoriaController:Controller
    {
      private MascotaContext _context; //el contexto 

      public CategoriaController (MascotaContext c){ //el constructor del contexto
            _context = c;

      }
    public IActionResult Mascotas()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }
  
    }
}