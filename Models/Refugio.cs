using System;
using System.Collections.Generic;

namespace MundoDePatitas.Models
{
    public class Refugio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Responsable { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Region { get; set; }
        public string Logo { get; set; }
        public List<Mascota> Mascotas {get; set;}


    }
}