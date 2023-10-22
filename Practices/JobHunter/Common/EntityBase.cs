using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
