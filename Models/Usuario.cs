using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace MundoDePatitas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Region { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int TipoUsuarioId { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public List<Mascota> Mascotas {get; set;}

    }
}











    
