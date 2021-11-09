using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            Ikta fanalis = new Ikta();
            fanalis.Name = "Eren Yegar";
            fanalis.Cw();

        }
    }

    internal abstract class Person
    {
        public string Name;
        public int Age;

        public void Cw()
        {
            Console.WriteLine(this.Name);
        }
    }


}
