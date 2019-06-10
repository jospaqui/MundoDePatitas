using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoDePatitas.Models
{
    public class Especie
    {
        public int Id {get; set;}
        [Required]
        public string Nombre{get; set;}
        [Required]
        public string Foto { get; set; }
        public List<Mascota> Mascotas{get; set;}
    }
}