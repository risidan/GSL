using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
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
                .WithOne(w => w.Cliente)
                .HasForeignKey(w => w.ClienteId);

            builder.HasMany(h => h.Enderecos)
                 .WithOne(w => w.Cliente)
                 .HasForeignKey(w => w.ClienteId);

            builder.HasOne(h => h.Usuario)
                   .WithOne(w => w.Cliente)
                   .HasForeignKey<Usuario>(f => f.ClienteId);
        }


    }
}
