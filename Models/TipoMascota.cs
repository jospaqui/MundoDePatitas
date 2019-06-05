using System.Collections.Generic;
namespace MundoDePatitas.Models
{
    public class TipoMascota
    {
        public int Id { get; set; }
        public string NombreTipoMascota { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}