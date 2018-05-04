using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Infra.Data.EntityConfig
{
    public class HistoriaConfig : EntityTypeConfiguration<Historia>
    {
        public HistoriaConfig()
        {
            HasKey(h => h.CodHistoria);

            Property(h => h.DataInclusao)
                .IsRequired();

            Property(h => h.DataEdicao)
                .IsOptional();

            Property(h => h.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            Property(h => h.Titulo)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnType("varchar");

            Property(h => h.Descricao)
                .IsRequired();
                //.HasColumnType("nvarchar");

            ToTable("Historia");
        }
    }
}
