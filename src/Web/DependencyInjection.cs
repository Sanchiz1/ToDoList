using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Models;

namespace Web
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LocalConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();


            services
                .AddDefaultIdentity<ApplicationUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        public static void InitialiseDatabase(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
        }
    }
}
