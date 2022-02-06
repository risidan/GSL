using GSL.Domain.Entidades;
using GSL.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GSL.Infra.Data.Context
{
    public sealed class GSLContext : DbContext
    {
        public GSLContext(DbContextOptions<GSLContext> options) : base(options)
        { 
        
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Pessoa>();
            modelBuilder.Ignore<EntidadeBase>();


            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(200)");

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is EntidadeBase && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((EntidadeBase)entityEntry.Entity).DataAtualizacao = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((EntidadeBase)entityEntry.Entity).DataCriacao = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync();
        }
    }
}
