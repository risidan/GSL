using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(h => h.Telefones)
               .WithOne(w => w.Colaborador)
               .HasForeignKey(w => w.ColaboradorId);

            builder.HasMany(h => h.Enderecos)
                 .WithOne(w => w.Colaborador)
                 .HasForeignKey(w => w.ColaboradorId);

            builder.HasOne(h => h.Usuario)
                   .WithOne(w => w.Colaborador)
                   .HasForeignKey<Usuario>(f => f.ColaboradorId);
        }

   
    }
}
