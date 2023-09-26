

using Freelancer.Entities;
using Freelancer.Services;

//var freelancer = new Freelancer.Entities.Freelancer()
//{
//    Id = Guid.NewGuid(),
//    CreatedOn = DateTime.Now,
//    FirstName = "John",
//    LastName = "Doe",
//    WorkExperience = "5 years experience in web development",
//    Points = new List<Review>
//    {
//        new Review() { Text = "Text 1", Rating = 5},
//        new Review() { Text = "Text 2", Rating = 4}
//    }
//};
//  notepadService.SaveToNotepad(freelancer);

//var anotherCustomerInstance = new Customer
//{
//    Id = Guid.NewGuid(),          
//    CreatedOn = DateTime.Now,    
//    FirstName = "Bob",
//    LastName = "Smith",
//    PhoneNumber = "555-123-4567"
//};

var anotherCustomer = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Esmanur",
    LastName = "Mazlum",
    PhoneNumber = "555-123-4222"
};

NotepadService notepadService = new();
//notepadService.SaveToNotepad(anotherCustomer);
string customerData = notepadService.GetOnNotepad("D:\\YetgenAkbank\\YetgenAkbankJump\\Freelancer\\Database\\Customers.txt");

string[] splittedLines = customerData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (string line in splittedLines)
{
    Customer customer = new();
    customer.SetValueCSV(line);
    customers.Add(customer);
}
