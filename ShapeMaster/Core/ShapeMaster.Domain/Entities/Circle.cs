using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Circle : Shape
    {
        public decimal radius;
        public decimal PI = 3.14M;
        protected override decimal GetArea()
        {
            return PI * radius;
        }
    }
}
