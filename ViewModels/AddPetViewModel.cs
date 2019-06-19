using System.ComponentModel.DataAnnotations;
namespace Patitas.ViewModels
{
    public class AddPetViewModel
    {
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
        [Required]
        public string Estado { get; set; }

        public int IdTipoMascota { get; set; }

    }
}