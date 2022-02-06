using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(c => c.ColaboradorId)
                .IsRequired(false);
            builder.Property(c => c.ClienteId)
                .IsRequired(false);
            builder.Property(c => c.FornecedorId)
                .IsRequired(false);

        }


    }
}
