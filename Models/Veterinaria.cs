using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Veterinaria
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Responsable { get; set; }
        public int Telefono { get; set; }


        public string Logo { get; set; }
    }
}