using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Patitas.Models
{
    public partial class Mascota
    {
        [Key]
        public int IdMascota { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Tamaño { get; set; }
        [Required]
        public string PuedeEstarSolo { get; set; }
        [Required]
        public string Personalidades { get; set; }
        [Required]
        public int Edad { get; set; }
        public string FotoMascota { get; set; }

        public string Descripcion { get; set; }
        [Required]
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Required]
        public string Estado { get; set; }

        public int IdTipoMascota { get; set; }


        public virtual List<Pregunta> Pregunta { get; set; }




        
    }
}