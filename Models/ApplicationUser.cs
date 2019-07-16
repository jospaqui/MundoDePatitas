using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using System.IO;
using MundoDePatitas.Models;

namespace Patitas.Models
{
    public partial class ApplicationUser:IdentityUser
    {
      
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Sexo { get; set; }

        public List<Pregunta> Preguntas { get; set; }

        public List<Adopcion> Adopciones { get; set; }

        public List<Archivo> Archivos { get; set; }

    }
}