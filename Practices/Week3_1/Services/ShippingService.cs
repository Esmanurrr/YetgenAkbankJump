using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3_1.Entities;

namespace Week3_1.Services
{
    internal class ShippingService
    {
        public decimal CalculateTax(Product product, CountryInformation countryInformation)
        {
            return product.Price * countryInformation.TaxRate;
        }
    }
}
