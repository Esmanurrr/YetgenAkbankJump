﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunter.Common
{
    public interface ICreatedByEntity
    {
        public DateTime CreatedOn { get; set; }
    }
}
