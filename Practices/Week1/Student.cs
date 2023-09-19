using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int ıd, string name, string surname)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
        }
    }
}
