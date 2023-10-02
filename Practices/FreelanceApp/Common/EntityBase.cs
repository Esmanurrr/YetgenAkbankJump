﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceApp.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
