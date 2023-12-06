using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Domain.Entities
{
    public class Category : EntityBase<Guid>
    {
        public string Name { get; set; }
        public ICollection<ProductCategory> ProductCategories  { get; set; }

        //_context.Categories.Include(x=>x.Product).Find(id);
    }
}
