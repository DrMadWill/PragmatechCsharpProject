using System;

namespace task__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 le verilmis eded arasinda kvadratlari cemi");
            Console.Write("Verilmis eded : ");
            int eded = Convert.ToInt32(Console.ReadLine());
            KvadratCemi(eded);

        }

        public static void KvadratCemi(int eded)
        {
            Console.WriteLine($">>> 1 + {eded * eded} = {eded * eded + 1} ");
        }
    }
}
