using System;
using System.ComponentModel.DataAnnotations;

namespace MundoDePatitas.Models
{
    public class Veterinaria
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public string Responsable { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Region { get; set; }
        [Required]
        public string Logo { get; set; }

    }
}