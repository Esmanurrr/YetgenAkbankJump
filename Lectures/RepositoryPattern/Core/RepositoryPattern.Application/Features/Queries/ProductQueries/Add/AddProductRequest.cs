using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace RepositoryPattern.Application.Features.Queries.ProductQueries.Add
{
    public class AddProductRequest : IRequest<AddProductResponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
