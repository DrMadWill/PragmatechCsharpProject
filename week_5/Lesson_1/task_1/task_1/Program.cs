using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student Mad = new Student("Domation","Road",25);
            Student Will = new Student("Nofel", "Salahov", 22);
            Will.Counter();

        }



    }

    interface ICount
    {
        void Counter();
    }

    class Student:ICount
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public static int Total;
        private int Number;

        public Student(string name,string surename,int age)
        {
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
            Total++;
            this.Number = Total;

        }

        public void Counter()
        {
            Console.WriteLine($" {this.Number} defe instance edildi.");
        }
    }
}
