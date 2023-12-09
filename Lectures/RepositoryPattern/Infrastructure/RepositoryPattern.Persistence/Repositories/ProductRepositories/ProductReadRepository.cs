using RepositoryPattern.Application.Repositories.ProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Persistence.Contexts;

namespace RepositoryPattern.Persistence.Repositories.ProductRepositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository<Product>
    {
        public ProductReadRepository(RepositoryDbContext context) : base(context)
        {
        }
    }
}
