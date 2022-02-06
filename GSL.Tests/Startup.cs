using GSL.Application.AutoMapper;
using GSL.Infra.Data.Context;
using GSL.Tests.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GSL.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {


            //var connectionString = configuration.GetConnectionString("A_DbCoreConnectionString");
            //services.AddDbContext<AContext>(options1 => options1.UseSqlServer(connectionString));

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            services.AddDbContext<GSLContext>(options =>
                options.UseMySql("server=localhost;user=root;password=1234;database=GSL", serverVersion));

            services.AddAutoMapper(typeof(DomainToViewModel), typeof(ViewModelToDomain));

            services.AddDependencyInjectionConfiguration();

        }
    }
}
