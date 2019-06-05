using Microsoft.EntityFrameworkCore;
using MundoDePatitas.Models;

namespace MundoDePatitas.Datos
{
    public class MascotaContext : DbContext
    {
        public DbSet<Mascota> Mascotas {get; set;}
        public DbSet<Models.TipoMascota> Tipos {get; set;}

        public MascotaContext(DbContextOptions<MascotaContext> o) : base(o){

        }
    }
}