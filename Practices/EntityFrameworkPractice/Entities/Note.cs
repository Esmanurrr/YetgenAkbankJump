using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Entities
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public Note(string text)
        {
            Id = Guid.NewGuid();
            Text = text;
        }

    }
}
