using System;

namespace palindrom_5_reqemli
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

                int yoxlamaeded = Convert.ToInt32(eded);

                if (eded[0] == eded[4] && eded[1] == eded[3])
                    Console.WriteLine("----->Tebrikler. Bu palidraom ededdir");
                else
                    Console.WriteLine("----->Palindrom deyil");



                Console.Write("Palidromu yoxlamaqa davam? >> klavaturan her hansi tusu /n :");
                string davamyoxlama = Console.ReadLine();
                if (davamyoxlama == "n")
                    break;


            }
        }
    }
}
