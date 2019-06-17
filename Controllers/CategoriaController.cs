    
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    
    public IActionResult ListadoEspecie( int especieID) //Para listar todas las especies
    {
      ViewBag.especie = _context.Especies.ToList();

      var especie = _context.Especies.Include(x => x.Id).ToList();

      if(especieID != 0)
      {
        especie = _context.Especies.Include(x => x.Id).Where(x => x.Id == especieID).ToList();
      }
      return View(especie);
    }



    public IActionResult AgregarEspecie() //Para el registro de nuevas especies
    {
      ViewBag.especie = _context.Especies.ToList();   
      return View();
    }
    [HttpPost] //la parte del posteo
    public IActionResult AgregarEspecie( Especie e)
    {
      if (ModelState.IsValid)
      {
          _context.Add(e);
          _context.SaveChanges();
          return RedirectToAction("ListadoEspecie");
      }
      ViewBag.especie = _context.Especies.ToList();
      return View(e);
    }



    public IActionResult Mascotas()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }
  
    }
}