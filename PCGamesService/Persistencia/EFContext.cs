using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PCGamesService.Dominio;
using System.Data.Entity;

namespace Persistencia.EF
{
    public class EFContext : DbContext
    {
        public EFContext(string cadenaConexion)
            : base(cadenaConexion)
        {
            Database.SetInitializer<EFContext>(null);
        }

        public DbSet<PCGames> PCGames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}