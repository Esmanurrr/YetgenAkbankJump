using RepositoryPattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Domain.Entities;

namespace RepositoryPattern.Application.Repositories.ProductRepositories
{
    public interface IProductWriteRepository : IWriteRepository<Product>
    {
    }
}
