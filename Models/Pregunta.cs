using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public class Pregunta
    {
        
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Contenido { get; set; }

        public ApplicationUser AplicationUser { get; set; }
        public int AplicationUserId { get; set; }

        public Mascota Mascota { get; set; }
        public int MascotaId { get; set; }


    }
}