using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Rectangle : Shape
    {
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }

        public Rectangle()
        {
            Type = "Rectangle"; 
        }
        public override decimal GetArea()
        {
            return ASide * BSide;
        }
    }
}
