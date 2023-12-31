﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Common
{
    public abstract class Shape 
    {
        public string Type { get; set; }
        protected abstract decimal GetArea();

        public string GetInfo()
        {
            return $"{Type} AREA : {GetArea()}" ;
        }
    }
}
