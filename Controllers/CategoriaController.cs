    
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patitas.Data;
using Patitas.Models;
namespace Patitas.Controllers
{
    public class CategoriaController:Controller
    {
      private MascotaContext _context; //el contexto 

      public CategoriaController (MascotaContext c){ //el constructor del contexto
            _context = c;

      }
    

    
    public IActionResult ListadoEspecie( int especieID) //Para listar todas las especies
    {
      ViewBag.especie = _context.TipoMascotas.ToList();

      var especie = _context.TipoMascotas.Include(x => x.IdTipoMascota).ToList();

      if(especieID != 0)
      {
        especie = _context.TipoMascotas.Include(x => x.IdTipoMascota).Where(x => x.IdTipoMascota == especieID).ToList();
      }
      return View(especie);
    }



    public IActionResult AgregarEspecie() //Para el registro de nuevas especies
    {
      ViewBag.especie = _context.TipoMascotas.ToList();   
      return View();
    }
    [HttpPost] //la parte del posteo
    public IActionResult AgregarEspecie( TipoMascota e)
    {
      if (ModelState.IsValid)
      {
          _context.Add(e);
          _context.SaveChanges();
          return RedirectToAction("ListadoEspecie");
      }
      ViewBag.especie = _context.TipoMascotas.ToList();
      return View(e);
    }



    public IActionResult Mascotas()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }
  
    }
}