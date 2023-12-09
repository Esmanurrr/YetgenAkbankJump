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
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(RepositoryDbContext context) : base(context)
        {
        }
    }
}
