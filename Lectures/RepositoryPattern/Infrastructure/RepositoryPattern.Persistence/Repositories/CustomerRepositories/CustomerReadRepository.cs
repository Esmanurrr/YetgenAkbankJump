using RepositoryPattern.Application.Repositories.CustomerRepositories;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository<Customer>
    {
        public CustomerReadRepository(RepositoryDbContext context) : base(context)
        {
        }
    }
}
