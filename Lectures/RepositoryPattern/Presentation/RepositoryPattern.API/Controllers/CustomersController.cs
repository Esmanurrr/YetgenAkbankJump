using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Application.Repositories.CustomerRepositories;
using RepositoryPattern.Domain.Entities;
using RepositoryPattern.Persistence.Repositories.CustomerRepositories;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public CustomersController(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        [HttpGet]
        public List<Customer> GetAllCustomers()
        {
            return _customerReadRepository.GetAll();
        }
    }
}
