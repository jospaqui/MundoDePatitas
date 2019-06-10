using System.Collections.Generic;

namespace MundoDePatitas.Models
{
    public class TipoUsuario
    {
        public int Id {get; set;}
        public string Nombre{get; set;}
        public List<Usuario> Usuarios {get; set;}


    }
}