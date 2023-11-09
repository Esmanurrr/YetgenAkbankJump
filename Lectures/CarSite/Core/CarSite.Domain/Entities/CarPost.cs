using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.Domain.Entities
{
    public class CarPost : EntityBase<Guid>
    {
        public Car Car { get; set; }
        public int Mileage { get; set; }
        public GearboxType Gearbox { get; set; }
        public CarColor Color { get; set; }
    }
}
