
using EFCoreExample.Entities;
using EFCoreExample.Persistence;

EFCoreDbContext _context = new();

var category = new Category()
{
    Id = 1,
    Name = "Pencil"
};

var category2 = new Category()
{
    Id = 2,
    Name = "Book"
};


_context.Products.Add(new("Pencil 1", 100, category));
_context.Products.Add(new("Pencil 2", 100, category));
_context.Products.Add(new("Book 1", 100, category2));
_context.Products.Add(new("Book 2", 100, category2));

//insertion
_context.Products.AddRange(new List<Product>
{
    new Product ("Pencil 3", 200, category),
    new Product ("Pencil 4", 300, category),
    new Product ("Book 3", 200, category2),
    new Product ("Book 4", 300, category2),
});

_context.SaveChanges();

//remove
_context.Products.RemoveRange(_context.Products.Where(x=>x.Name == "Pencil 1"));

_context.SaveChanges();


//update
var product = _context.Products.First();
product.Name = "Pencil 200";


List<Product> products = _context.Products.ToList();


Console.WriteLine();
