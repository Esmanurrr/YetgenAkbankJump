using Microsoft.Extensions.DependencyInjection;
using RepositoryPattern.Application.Repositories.CustomerRepositories;
using RepositoryPattern.Application.Repositories.ProductRepositories;
using RepositoryPattern.Persistence.Contexts;
using RepositoryPattern.Persistence.Repositories.CustomerRepositories;
using RepositoryPattern.Persistence.Repositories.ProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddDbContext<RepositoryDbContext>();
        }
    }
}
