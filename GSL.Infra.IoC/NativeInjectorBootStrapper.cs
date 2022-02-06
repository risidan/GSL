using GSL.Application.Services;
using GSL.Application.Services.Interfaces;
using GSL.Infra.Data;
using GSL.Infra.Data.Context;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository;
using GSL.Infra.Data.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GSL.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IClientesService, ClientesService>();
            services.AddScoped<IFornecedoresService, FornecedoresService>();
            services.AddScoped<IColaboradoresService, ColaboradoresService>();
            services.AddScoped<IUsuariosService, UsuariosService>();
            services.AddScoped<ITokenService, TokenService>();



            // Infra - Data
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<GSLContext>();

        }
    }
}
