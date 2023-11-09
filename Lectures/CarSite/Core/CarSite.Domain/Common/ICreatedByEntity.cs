using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Domain.Common
{
    public interface ICreatedByEntity
    {
        DateTime CreatedOn { get; set; }
        string CreatedByUserId { get; set; }
    }
}
