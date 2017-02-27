using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Lab04_Ex02
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Student(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public Student() : this("1", "MS Dhoni")
        {
        }

        public override string ToString()
        {
            return String.Format($"ID: {ID} || Name:{Name}");
        }
    }
}
