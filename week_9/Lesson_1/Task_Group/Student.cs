using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P121021
{
    public class Student
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            UpdateStudent(name, surname);
             Id = _id;
            _id++;

        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public void UpdateStudent(string name, string surename)
        {
            this.Name = name;
            this.Surname = surename;
        }

    }
}
