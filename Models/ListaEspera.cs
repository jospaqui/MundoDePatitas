using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patitas.Models
{
    public partial class ListaEspera
    {
        [Key]
        public int IdListaEspera { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string TipoMascota { get; set; }
        public string SexoMascota { get; set; }
        public string Tamanio { get; set; }
    }
}