using MediatR;
using RepositoryPattern.Application.Repositories.ProductRepositories;
using RepositoryPattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepositoryPattern.Application.Features.Queries.ProductQueries.Add
{
    internal class AddProductHandler : IRequestHandler<AddProductRequest, AddProductResponse>
    {
        private readonly IProductWriteRepository _productWriteRepository;

        public AddProductHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public Task<AddProductResponse> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price
            };

            _productWriteRepository.Add(product);
            _productWriteRepository.SaveChanges();

            return Task.FromResult(new AddProductResponse());
        }
    }
}
