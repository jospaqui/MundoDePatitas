
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Patitas.Models;
using Microsoft.AspNetCore.Identity;
using MundoDePatitas.Models;

namespace Patitas.Data
{
    public class MascotaContext : IdentityDbContext
    {
        
        public DbSet<Adopcion> Adopciones { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<ListaEspera> ListaDeEspera { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Refugio> Refugios { get; set; }
        public DbSet<TipoMascota> TipoMascotas { get; set; }
        public DbSet<Veterinaria> Veterinarias { get; set; }
        public DbSet<Archivo> Archivos { get; set; }

     

        public MascotaContext(DbContextOptions<MascotaContext>options):base(options){}
    }



}