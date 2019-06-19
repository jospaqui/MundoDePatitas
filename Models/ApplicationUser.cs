using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;


namespace Patitas.Models
{
    public partial class ApplicationUser:IdentityUser
    {
      
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Sexo { get; set; }


        


        public virtual List<Pregunta> Pregunta { get; set; }

        public virtual List<Adopcion> Adopcion { get; set; }

    

    }
}