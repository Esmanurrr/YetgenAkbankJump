
using JobHunter.Contexts;
using JobHunter.Entities;
using JobHunter.Enums;

Console.WriteLine("Change Tracker");

JobPost jobPost1 = new()
{
    Title = "Junior Developer",

    Company = "FoolTech",

    Description = "Bachelor's Degree in Computer Science/Engineering or relevant areas, Minimum 3 years experience in Net Framework & C# programming language (Knowledge and experience in .Net Core is a big plus)",

    WorkMode = WorkMode.InOffice,

    CreatedOn = DateTime.UtcNow,
};

JobHunterDbContext _context = new();

var state1 = _context.Entry(jobPost1).State; // Detached

_context.JobPosts.Add(jobPost1);

var state2 = _context.Entry(jobPost1).State; // Added

_context.SaveChanges();

var state3 = _context.Entry(jobPost1).State; // Unchanged

jobPost1.WorkMode = WorkMode.Hybrid;

var state4 = _context.Entry(jobPost1).State; // Modified

_context.SaveChanges();

var state5 = _context.Entry(jobPost1).State; // Unchanged

_context.JobPosts.Remove(jobPost1);

var state6 = _context.Entry(jobPost1).State; // Deleted

_context.SaveChanges();

var state7 = _context.Entry(jobPost1).State; // Detached
