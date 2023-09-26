using Freelancer.Abstract;
using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    internal class Freelancer : Person<Guid>, ICsvConvertible
    {
        public string WorkExperience { get; set; }
        public List<Review> Points { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id},{CreatedOn},{FirstName},{LastName},{WorkExperience}";
        }

        public void SetValueCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');

            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }
    }
}
