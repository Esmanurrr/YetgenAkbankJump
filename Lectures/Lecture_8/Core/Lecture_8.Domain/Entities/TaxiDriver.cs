using Lecture_8.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8.Domain.Entities
{
    public class TaxiDriver : Person
    {
        public string LicencePlate { get; set; }
    }
}
