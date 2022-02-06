using GSL.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GSL.Infra.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
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
