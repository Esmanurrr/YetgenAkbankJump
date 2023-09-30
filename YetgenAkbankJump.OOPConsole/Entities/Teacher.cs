using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetgenAkbankJump.OOPConsole.Common;
using YetgenAkbankJump.OOPConsole.Enums;

namespace YetgenAkbankJump.OOPConsole.Entities
{
    public class Teacher : EntityBase<long>
    {
        public DateTimeOffset RegistrationDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator Teacher(Student student)
        {
            return new Teacher()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                CreatedOn = student.CreatedOn
            };
        }
    }
}
