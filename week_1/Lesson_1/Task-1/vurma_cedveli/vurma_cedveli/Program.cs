using System;

namespace vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vurma cedveli");
            Console.Write("Gosterilmesi istenilen vurmacedvelin ededi : ");
            int eded = Convert.ToInt32(Console.ReadLine());
            VumraCedveli(eded);
        }

        public static void VumraCedveli(int eded)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($">>>>>>> {eded} x {i} = {eded*i}");
            }
        }

    }
}
