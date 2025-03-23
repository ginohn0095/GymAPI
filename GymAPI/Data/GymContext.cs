using Microsoft.EntityFrameworkCore;
using GymAPI.Models;
using System.Collections.Generic;

namespace GymAPI.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options) { }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
