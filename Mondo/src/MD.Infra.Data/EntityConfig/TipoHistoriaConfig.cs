using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Infra.Data.EntityConfig
{
    public class TipoHistoriaConfig : EntityTypeConfiguration<TipoHistoria>
    {
        public TipoHistoriaConfig()
        {
            HasKey(t => t.CodTipoHistoria);

            Property(t => t.DataInclusao)
                .IsRequired();

            Property(t => t.DataEdicao)
                .IsOptional();

            Property(t => t.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            Property(t => t.Titulo)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(400);

            Property(t => t.Descricao)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(800); 

            ToTable("TipoHistoria");
        }
    }
}
