namespace MundoDePatitas.Models
{
    public class FotoMascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }
    }
}