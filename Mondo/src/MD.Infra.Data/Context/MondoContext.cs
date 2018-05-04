using MD.Domain.Entities;
using MD.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Infra.Data.Context
{
    public class MondoContext : DbContext
    {
        public MondoContext()
            : base("MondoConnection")
        {

        }

        public DbSet<Historia> Historias { get; set; }
        public DbSet<TipoHistoria> TiposHistoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new HistoriaConfig());
            modelBuilder.Configurations.Add(new TipoHistoriaConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataInclusao") != null && entry.Entity.GetType().GetProperty("DataEdicao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                    entry.Property("DataEdicao").CurrentValue = null;
                }

                if(entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").IsModified = false;
                    entry.Property("DataEdicao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
