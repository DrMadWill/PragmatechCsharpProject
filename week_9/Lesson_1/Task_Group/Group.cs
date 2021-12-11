using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P121021
{
    public class Group
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        private List<Student> students;
        public Group(string name)
        {
            Name = name;
            Id = _id;
            _id++;
            students = new List<Student>();
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAlLStudent() => students;

        public override string ToString()
        {
            return Name;
        }

    }
}
