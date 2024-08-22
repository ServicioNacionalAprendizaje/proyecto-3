using GastroManagerBE.DB;
using GastroManagerBE.Interfaces;
using GastroManagerBE.Repository;
using GastroManagerBE.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GastroManagerBE
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServicesProject(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IProductServices, ProductServices>();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            
            return services;
        }
    }
}
