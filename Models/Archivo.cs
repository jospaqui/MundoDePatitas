using Patitas.Models;

namespace MundoDePatitas.Models
{
    public class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }

        public Mascota Mascota { get; set; }
        public int? MascotaId { get; set; }

    }
}