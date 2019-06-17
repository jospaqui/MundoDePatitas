using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Adopcion
    {
        [Key]
        public int IdAdoptante { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaAdop { get; set; }

        public ApplicationUser Id{ get; set; }



    }
}