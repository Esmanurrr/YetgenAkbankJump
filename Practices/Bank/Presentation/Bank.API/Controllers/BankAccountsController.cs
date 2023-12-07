using Bank.API.Models;
using Bank.Domain.Entities;
using Bank.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        public BankDbContext _context;

        public BankAccountsController(BankDbContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public void SetDefaultUsersData()
        {
            List<BankAccount> people = new()
            {
                new BankAccount {Id = Guid.Parse("952134bd-f36e-455f-86b7-1c558973ac5a"), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "James" , LastName = "Smith", PhoneNumber = "5523367351"},
                new BankAccount {Id = Guid.Parse("af41fe1e-9a53-4d35-b4b5-1c82796079d5"), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "Mary" , LastName = "Johnson", PhoneNumber = "5432435342"},
                new BankAccount {Id = Guid.Parse("fa45c334-edcd-43b0-aa8f-6635784c85c0"), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "John" , LastName = "Williams", PhoneNumber = "5335727392"},
                new BankAccount {Id = Guid.Parse("1b5cb6c6-cf8c-42e1-b470-381802a35b3e"), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "Patricia" , LastName = "Brom", PhoneNumber = "5523367421"},
                new BankAccount {Id = Guid.Parse("2e3ee66d-943e-486f-b90f-e7b92c7bcf8e"), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "Robert" , LastName = "Jones", PhoneNumber = "5523234231"},

            };

            _context.People.AddRange(people);
            _context.SaveChanges();
        }


        [HttpGet("[action]/{bankAccountId:guid}")]
        public GetBankAccountDataResponseModel GetBankAccountData(Guid bankAccountId)
        {
            var bankAccount = _context.People.FirstOrDefault(x => x.Id == bankAccountId);

            var response = new GetBankAccountDataResponseModel()
            {
                FirstName = bankAccount.FirstName,
                LastName = bankAccount.LastName,
                Balance = bankAccount.Balance,
            };

            return response;

        }
    }
}
