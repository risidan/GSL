using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.Property(c => c.ColaboradorId)
               .IsRequired(false);
            builder.Property(c => c.ClienteId)
                .IsRequired(false);
            builder.Property(c => c.FornecedorId)
                .IsRequired(false);
        }

   
    }
}
