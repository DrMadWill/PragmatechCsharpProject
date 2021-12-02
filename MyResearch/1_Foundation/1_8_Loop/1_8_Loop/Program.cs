using System;

namespace _1_8_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i+=2)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 25; i > 0; i-=2)
            //{
            //    Console.WriteLine(i);
            //}


            int i = 25;
            for (; i > 0; )
            {
                Console.WriteLine(i);
                i -= 2;
            }

        }
    }
}
