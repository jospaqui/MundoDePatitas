using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patitas.Models
{
    public partial class TipoMascota
    {
        [Key]
        public int IdTipoMascota { get; set; }
        public string Nombre { get; set; }
        public string FotoTipo { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Mascota> Mascota { get; set; }
    }
}