using System.ComponentModel.DataAnnotations;

namespace MundoDePatitas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        
        [Required]
        public string EmailUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public string DNIUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public string DistritoUsuario { get; set; }

        public NivelUsuario IDNivelUsuario{ get; set; }
        public TipoUsuario IDTipoUsuario{get; set; }
    }
}











    
