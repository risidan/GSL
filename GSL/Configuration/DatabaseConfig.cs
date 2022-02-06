using GSL.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GSL.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            services.AddDbContext<GSLContext>(options =>
                options.UseMySql(configuration.GetConnectionString("SQLConnection"), serverVersion));

        
        }
    }
}
