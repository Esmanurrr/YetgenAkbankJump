using Bogus;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Persistence.Contexts;

namespace YetgenAkbankJump.WebApi.Services
{
    public class FakeDataService
    {
        //private readonly ApplicationDbContext _context;
        //private readonly Random _random;

        //public FakeDataService(ApplicationDbContext context)
        //{
        //    _context = context;
        //    _random = new Random();
        //}

        //public async Task<int> GenerateStudentDataAsync(CancellationToken cancellationToken)
        //{
        //    var fakeStudentRules = new Faker<Student>("tr")
        //        .RuleFor(s => s.Id, new Guid())
        //        .RuleFor(s => s.FirstName, f => f.Name.FirstName())
        //        .RuleFor(s => s.LastName, f => f.Name.LastName())
        //        .RuleFor(s => s.Country, f => f.Address.Country())
        //        .RuleFor(s => s.City, f => f.Address.City())
        //        .RuleFor(s => s.Company, f => f.Company.CompanyName())
        //        .RuleFor(s => s.Age, Convert.ToInt16(_random.Next(10, 59)))
        //        .RuleFor(s => s.RegistrationFee, _random.Next(0, 9999))
        //        .RuleFor(s => s.CreatedOn, DateTimeOffset.UtcNow)
        //        .RuleFor(s => s.CreatedByUserId, "KalayMaster");

        //    var students = fakeStudentRules.Generate(10000);

        //    foreach (var student in students)
        //        student.Id = Guid.NewGuid();

        //    await _context.Students.AddRangeAsync(students, cancellationToken);

        //    var recordCount = await _context.SaveChangesAsync(cancellationToken);

        //    return recordCount;

        //}
    }
}
