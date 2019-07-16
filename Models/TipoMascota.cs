using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patitas.Models
{
    public class TipoMascota
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FotoTipo { get; set; }
        public string Descripcion { get; set; }

        public List<Mascota> Mascotas { get; set; }
    }
}