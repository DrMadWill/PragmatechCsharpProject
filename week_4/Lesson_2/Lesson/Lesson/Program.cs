using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            Console.WriteLine("-------- Struct and Class -------------------");

            MW tipic = new MW();
            tipic.Ideal = "CWorld";
            Console.WriteLine(tipic.Ideal);

        }
    }

    struct MW
    {
        public string Ideal;
        string Life;

    }
}
