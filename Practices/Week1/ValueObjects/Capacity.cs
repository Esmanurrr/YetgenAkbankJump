using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Enums;

namespace Week1.ValueObjects
{
    internal class Capacity
    {
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public Capacity(int size, CapacitySizeType sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }


    }
}
