using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class Anuncio
    {
        
        public int Id { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}