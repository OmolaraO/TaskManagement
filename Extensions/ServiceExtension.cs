using Microsoft.EntityFrameworkCore;
using TaskManagement.Application.interfaces.Repository;
using TaskManagement.Infrastructure.Repository;

namespace TaskManagement.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(opts => opts.UseNpgsql(configuration.GetConnectionString("MyDatabaseConnection")));
       
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
    }

}
