using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using MundoDePatitas.Models;

namespace Patitas.Models
{
    public class Mascota
    {
        
        public int Id { get; set; }
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

        public string Descripcion { get; set; }
        [Required]
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        [Required]
        public string Estado { get; set; }


        public List<Archivo> Archivos { get; set; }

        public TipoMascota TipoMascota { get; set; }
        public int TipoMascotaId { get; set; }


        public List<Pregunta> Preguntas { get; set; }

        public Refugio Refugio { get; set; }
        public int RefugioId { get; set; }


        
    }
}