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
    public class HomeController : Controller
    {
        private MascotaContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;


        public HomeController(
            MascotaContext mc,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim
        ){
            _context=mc;
            _userManager=um;
            _signInManager=sim;

        }

        public IActionResult Veterinarias(){
            var vet = _context.Veterinarias.ToList();
            return View(vet);
        }
        
        public IActionResult Index()
        {
            return View();
        }

          public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
