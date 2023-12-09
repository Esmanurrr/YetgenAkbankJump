using RepositoryPattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : EntityBase
    {
        List<T> GetAll();
        T GetById(string id);
    }
}
