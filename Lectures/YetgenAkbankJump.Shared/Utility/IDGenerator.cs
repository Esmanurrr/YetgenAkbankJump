using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetgenAkbankJump.Shared.Utility
{
    public class IDGenerator
    {
        public Guid Generate()
        {
            return Guid.NewGuid();
        }
    }
}
