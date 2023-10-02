using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Week3__.Entities;

namespace Week3__.Services
{
    internal class ShippingService
    {
        public decimal CalculateTax(Product product, string country)
        {
            if (country == "U.S.A.")
                return product.Price * 1.2m;
            else if (country == "Türkiye")
                return product.Price * 1.1m;
            else if (country == "Spain")
                return product.Price * 1.4m;

            return -1;
        }
    }
}
