using RepositoryPattern.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.Entities
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
