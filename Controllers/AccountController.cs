    
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
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult Register() {
            return View();
         }
        [AllowAnonymous]
         [HttpPost]
         public IActionResult Register(RegisterViewModel model) {
            if (ModelState.IsValid) {
                var user = new ApplicationUser { 
                    Nombre= model.Nombre, 
                    UserName=model.UserName,
                    Apellidos=model.Apellidos,
                    Email=model.Email,
                    Sexo=model.Sexo,
                    FechaDeRegistro=DateTime.Now
                    };


                var resultado = _userManager.CreateAsync(user, model.Password);

                if (resultado.Result == IdentityResult.Success) {

                    return RedirectToAction("Login", "Account");
                }
                else {
                    foreach (var error in resultado.Result.Errors) {
                        ModelState.AddModelError("error", error.Description);
                    }
                }
            }

            return View(model);
         }




         public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model) {
            if (ModelState.IsValid) {
                var resultado = _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

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