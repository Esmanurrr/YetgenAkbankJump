using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8.Domain.Common
{
    public interface IDeletedByEntity
    {
        DateTimeOffset? DeletedOn { get; set; }
        bool IsDeleted { get; set; }
    }
}
