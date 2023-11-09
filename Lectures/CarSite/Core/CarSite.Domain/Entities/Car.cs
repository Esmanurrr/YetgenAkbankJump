using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Domain.Entities
{
    public class Car : EntityBase<Guid>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal EngineDisplacement { get; set; }
        public int ManufacturingYear { get; set; }
    }
}
