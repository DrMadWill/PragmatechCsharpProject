using System;

namespace _1_9_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student student1 = new Student(1, "Cika", "Hiromiya");
            Student student2 = new Student(2, "Sirogane", "Hiromiya");

            Student[] students = { student1, student2 };

            foreach (var item in students)
            {
                Console.WriteLine($">>>>>>>> Student Number : {item.Student_Number} / Name : {item.Name} / Class : {item.Class}");
            }

        }
    }

    class Student
    {
        public int Student_Number { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }


        public Student(int number,string name,string clas)
        {

            this.Class = clas;
            this.Name = name;
            this.Student_Number = number;
        }
    }
}
