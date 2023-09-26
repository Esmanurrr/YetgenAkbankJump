using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Abstract
{
    internal interface ICsvConvertible
    {
        public string GetValuesCSV();
        public void SetValueCSV(string csvLine);  
    }
}
