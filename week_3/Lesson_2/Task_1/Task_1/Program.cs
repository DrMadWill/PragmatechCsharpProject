using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
    }


    class Student
    {
        public static int Count;
        public int No;
        public string Name;
        public string SureName;
        
        public Student(string name,string surename)
        {

            this.Name = name;
            this.SureName = surename;
            Count++;
            this.No = Count;

        }

    }
}
