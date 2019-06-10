using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MundoDePatitas.Models
{
    public class Mascota
    {
        public int Id { get; set;}
        [Required]
        public string Nombre{ get; set;}
        public int Edad  { get; set; }
        public string Sexo { get; set; }
        public string Descripcion { get; set; }
        public string Region { get; set; }
        public string Tamano { get; set; }
        public string Raza { get; set; }
        public string Estado { get; set; }
        public string EspacioRequerido { get; set; }
        public string PuedeEstarSolo { get; set; }
        public string Personalidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EspecieId { get; set; }
        public Especie Especie { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int RefugioId { get; set; }
        public Refugio Refugio { get; set; }
        public List<FotoMascota> FotoMascotas {get; set;}


    }
}