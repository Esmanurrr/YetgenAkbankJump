
using JobHunter.Contexts;
using JobHunter.Entities;
using JobHunter.Enums;

Console.WriteLine("Interception");

JobHunterDbContext context = new();

#region Entity States Example
//JobPost jobPost1 = new()
//{
//    Title = "Junior Developer",

//    Company = "FoolTech",

//    Description = "Bachelor's Degree in Computer Science/Engineering or relevant areas, Minimum 3 years experience in Net Framework & C# programming language (Knowledge and experience in .Net Core is a big plus)",

//    WorkMode = WorkMode.InOffice,

//    CreatedOn = DateTime.UtcNow,
//};


//var state1 = _context.Entry(jobPost1).State; // Detached

//_context.JobPosts.Add(jobPost1);

//var state2 = _context.Entry(jobPost1).State; // Added

//_context.SaveChanges();

//var state3 = _context.Entry(jobPost1).State; // Unchanged

//jobPost1.WorkMode = WorkMode.Hybrid;

//var state4 = _context.Entry(jobPost1).State; // Modified

//_context.SaveChanges();

//var state5 = _context.Entry(jobPost1).State; // Unchanged

//_context.JobPosts.Remove(jobPost1);

//var state6 = _context.Entry(jobPost1).State; // Deleted

//_context.SaveChanges();

//var state7 = _context.Entry(jobPost1).State; // Detached

#endregion

#region Interception

//JobPost jobPost1 = context.JobPosts.FirstOrDefault();

//jobPost1.Description = "Desc. Changed";

//context.SaveChanges();

#endregion

#region IQueryable
//its ready but its not in db
var query1 = context.JobPosts
    .ToList()
    .Where(x => x.WorkMode == WorkMode.InOffice)
    .Select(x => new { x.Title, x.CreatedOn })
    .OrderBy(x => x.CreatedOn);

Console.WriteLine("------------");

var query2 = context.JobPosts
    .Where(x => x.WorkMode == WorkMode.InOffice)
    .Select(x => new { x.Title, x.CreatedOn })
    .OrderBy(x => x.CreatedOn)
    .ToList();


#endregion

#region IEnumerable
//the result after the query
//var result = query.ToList();

#endregion