using EFCoreExample.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExample.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            
        }
        public Product(string name, decimal price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;

        }
    }
}
