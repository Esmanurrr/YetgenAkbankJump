using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Application.Repositories
{
    public interface IRepository<T> where T : EntityBase
    {
        DbSet<T> Table { get; }
    }
}
