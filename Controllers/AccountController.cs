    
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Patitas.Data;
using Patitas.Models;
using Patitas.ViewModels;

namespace Patitas.Controllers
{
    public class AccountController:Controller
    {
        private MascotaContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;


        public AccountController(
            MascotaContext mc,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim
        ){
            _context=mc;
            _userManager=um;
            _signInManager=sim;

        }

  
    public IActionResult RecuperarContraseña()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

        //ESTA ES LA FICHA DE REGISTRO para obtener los datos del adoptante
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(string correo, string nombre, string pass, string direccion){
            TempData["correo"]=correo;
            TempData["nombre"]=nombre;
            TempData["pass"]=pass;
            TempData["direccion"]=direccion;

        
         return RedirectToAction("ConfirmarRegistro");
        }

        //PARA CONFIRMAR EL REGISTRO DEL USUARIO
        public IActionResult ConfirmarRegistro(){
            return View();
        }



         public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model) {
            if (ModelState.IsValid) {
                var resultado = _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (resultado.Result.Succeeded) {
                    return RedirectToAction("index", "home");
                }
                else {
                    ModelState.AddModelError("error", "Usuario o contraseña incorrectos");
                
                }
            }

            return View(model);
        }


    }    
}