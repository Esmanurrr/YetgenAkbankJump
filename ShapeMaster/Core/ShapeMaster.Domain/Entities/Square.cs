using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Square : Shape
    {
        public decimal OneSide { get; set; }
        public Square()
        {
            Type = "Square";        
        }

        protected override decimal GetArea()
        {
            return OneSide * OneSide;
        }
    }
}
