
using System;
using System.Reflection;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student st = new Student("Statick");

            Console.WriteLine(st.GetType().Assembly);// assembly yeri
            foreach (var item in st.GetType().GetMethods()) // methodlar.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("++++++++++++++++++");
            var tip = typeof(Student);
            var infor = tip.GetFields();
            foreach (var item in tip.GetFields())
            {
                Console.WriteLine(item);
            }
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name;
        public bool isAdele;
        public static int total;
        public void GetWirte()
        {
            Console.WriteLine("Hi,You big man ");
        }

        public Student(string name)
        {
            this.Name = name;
        }
    }

}
