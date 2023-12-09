using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Application.Repositories;
using RepositoryPattern.Domain.Common;
using RepositoryPattern.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : EntityBase
    {
        private readonly RepositoryDbContext _context;

        public ReadRepository(RepositoryDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>(); // to achieve database

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(string id)
        {
            return Table.FirstOrDefault(x=>x.Id == Guid.Parse(id));
        }
    }
}
