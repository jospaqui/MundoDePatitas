using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MundoDePatitas.Models;

namespace MundoDePatitas.Datos
{
    public class MascotaContext : IdentityDbContext
    {
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veterinaria> Veterinarias { get; set; }
        public DbSet<Refugio> Refugios { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<FotoMascota> FotoMascotas { get; set; }
        public DbSet<Adoptante> Adoptantes { get; set; }
        public DbSet<Especie> Especies { get; set; }



        public MascotaContext(DbContextOptions<MascotaContext> options) : base(options) { }

    }
}