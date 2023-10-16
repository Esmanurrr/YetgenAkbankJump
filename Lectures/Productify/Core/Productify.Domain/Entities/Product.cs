using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime CreatedOn { get; set; }

        public Product(string name, string category)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            CreatedOn = DateTime.Now;
        }
    }
}
