using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Pregunta
    {
        [Key]
        public int IdPregunta { get; set; }
        public DateTime Fecha { get; set; }
        public string Contenido { get; set; }

        public ApplicationUser Id { get; set; }
        public int IdMascota { get; set; }


    }
}