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
    public class HomeController : Controller
    {
        private MascotaContext _context; //el contexto 

        public HomeController (MascotaContext c){ //el constructor del contexto
            _context = c;

        }
        
        public IActionResult Index( int tipomascota) //Listado de las mascotas
        {
            ViewBag.tipos = _context.Tipos.ToList();
            var mascotas = _context.Mascotas.Include(x => x.Tipo).ToList();

            if(tipomascota != 0){
                mascotas = _context.Mascotas.Include(x => x.Tipo).Where(x => x.TipoId == tipomascota).ToList();                
            }   
            return View(mascotas);
        }
    }
}
