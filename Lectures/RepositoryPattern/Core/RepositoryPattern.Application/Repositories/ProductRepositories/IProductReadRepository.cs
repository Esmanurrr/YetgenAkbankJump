﻿using RepositoryPattern.Domain.Common;
using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Application.Repositories.ProductRepositories
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
    }
}
