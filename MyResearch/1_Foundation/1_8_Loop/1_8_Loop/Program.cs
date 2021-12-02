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


            //int i = 25;
            //for (; i > 0; )
            //{
            //    Console.WriteLine(i);
            //    i -= 2;
            //}



            //string name = "";
            //while (string.IsNullOrEmpty(name))
            //{
            //    Console.Write("Plase your name : ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello {name.ToUpper().TrimStart()}");


            //do
            //{
            //    Console.WriteLine("to do");
            //} while (1>2);

            //for (int i = 0; i < 5; i++)
            //{

            //    if (i == 0)
            //        continue;
            //    if (i == 2)
            //        break;

            //    Console.WriteLine(i);
            //}


            
            Console.WriteLine((new Random()).Next(1,100));


        }
    }
}
