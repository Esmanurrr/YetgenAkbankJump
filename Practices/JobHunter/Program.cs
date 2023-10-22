
using JobHunter.Entities;
using JobHunter.Enums;

Console.WriteLine("Change Tracker");

JobPost jobPost1 = new()
{
    Title = "Junior Developer",
  
    Company = "FoolTech",
    
    Description = "Bachelor's Degree in Computer Science/Engineering or relevant areas, Minimum 3 years experience in Net Framework & C# programming language (Knowledge and experience in .Net Core is a big plus)",

    WorkMode = WorkMode.InOffice,
   
    CreatedOn = DateTime.Now,
}