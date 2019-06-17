using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patitas.Models
{
    public partial class Mensaje
    {
        [Key]
        public int IdMensaje { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public string Email { get; set; }
        public Boolean IsRead { get; set; }


    }
}