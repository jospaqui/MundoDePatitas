using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MundoDePatitas.Models;
namespace MundoDePatitas.Controllers
{
    public class AdminController:Controller
    {
        public IActionResult Admin()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}