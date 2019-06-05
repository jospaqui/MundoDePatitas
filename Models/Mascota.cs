namespace MundoDePatitas.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public string EdadMascota { get; set; }
        public string Foto { get; set; }
        public string CaracteristicaMascota { get; set; }
         public TipoMascota TipoMascota { get; set; }
        public int TipoId { get; set; }
    }
}