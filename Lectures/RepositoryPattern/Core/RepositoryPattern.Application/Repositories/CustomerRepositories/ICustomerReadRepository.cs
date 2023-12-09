using RepositoryPattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Application.Repositories.CustomerRepositories
{
    public interface ICustomerReadRepository<T> : IReadRepository<T> where T : EntityBase 
    {
    }
}
