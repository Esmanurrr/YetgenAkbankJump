using Calender.Abstract;
using Calender.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender.Entities
{
    internal class Todo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}
