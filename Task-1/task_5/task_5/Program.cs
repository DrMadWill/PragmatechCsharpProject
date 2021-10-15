using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 la verilmiş ədəd arasındaki ədədlərin hasili ilə cəminin fərqini");
            Console.Write("Verilmis eded : ");
            int eded = Convert.ToInt32(Console.ReadLine());

            Ferqi(eded);


        }

        public static void Ferqi(int eded)
        {
            Console.WriteLine($">>> ( 0 x {eded} = {eded * 0}) - ( 0 + {eded} = {eded + 0}) = {(0 * eded) - (eded + 0)}");

        }
    }
}
