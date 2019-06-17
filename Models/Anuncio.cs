using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Anuncio
    {
        [Key]
        public int IdAnuncio { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}