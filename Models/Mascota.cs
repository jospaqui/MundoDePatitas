using System;
using System.ComponentModel.DataAnnotations;

namespace MundoDePatitas.Models
{
    public class Mascota
    {
        public int Id { get; set;}
        [Required]
        public string Nombre{ get; set;}
      
        public Boolean Adoptado { get; set; }
        public int edad { get; set; }
        public Boolean sexo  { get; set;}
        [Required]
        public string Foto{ get; set;}

        public TipoMascota Tipo { get; set; }

        public int TipoId { get; set; }

    }
}