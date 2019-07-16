using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Adopcion
    {
        
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaAdop { get; set; }

        public ApplicationUser ApplicationUser{ get; set; }
        public int AplicationUserId { get; set; }




    }
}