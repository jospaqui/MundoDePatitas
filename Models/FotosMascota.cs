using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.Models
{
    public partial class FotosMascota
    {
        [Key]
        public int IdFotoMascota { get; set; }
        public string nombre { get; set; }

        public int IdMascota { get; set; }

    }
}