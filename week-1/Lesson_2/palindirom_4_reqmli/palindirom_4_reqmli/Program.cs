using System;

namespace palindirom_4_reqmli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>> Ededin palidromlu]u yoxlanmasi <<<<<<<<<<<<<<<<<<<<");

            while (true)
            {
                

                Console.Write("Eded : ");
                string eded = Console.ReadLine();

                int yoxlama = Convert.ToInt32(eded);

                if (eded[0] == eded[3] && eded[1] == eded[2])
                    Console.WriteLine("Tebrikler. Bu palidraom ededdir");
                else
                    Console.WriteLine("Palindrom deyil");

                

                Console.Write("Palidromu yoxlamaqa davam? >> klavaturan her hansi tusu /n :");
                string davamyoxlama=Console.ReadLine();
                if (davamyoxlama == "n")
                    break;

        
            }
        }
    }
}
