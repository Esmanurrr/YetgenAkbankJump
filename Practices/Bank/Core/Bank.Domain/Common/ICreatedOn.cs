using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Common
{
    public interface ICreatedOn
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
    }
}
