using System;
using System.ComponentModel.DataAnnotations;

namespace Patitas.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]

        public string Sexo { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}