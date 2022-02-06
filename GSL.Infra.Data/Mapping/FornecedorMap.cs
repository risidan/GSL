using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
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
               .WithOne(w => w.Fornecedor)
               .HasForeignKey(w => w.FornecedorId);

            builder.HasMany(h => h.Enderecos)
                 .WithOne(w => w.Fornecedor)
                 .HasForeignKey(w => w.FornecedorId);

            builder.HasOne(h => h.Usuario)
                   .WithOne(w => w.Fornecedor)
                   .HasForeignKey<Usuario>(f => f.FornecedorId);
        }

   
    }
}
