using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Triangle : Shape
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public Triangle()
        {
            Type = "Triangle";
        }

        protected override decimal GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}
