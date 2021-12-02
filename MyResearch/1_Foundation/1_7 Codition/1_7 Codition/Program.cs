using System;

namespace _1_7_Codition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var isContition = false;


            //if (isContition)
            //    Console.WriteLine("1 > 2");
            //else
            //    Console.WriteLine("1 < 2");


            //if (isContition == true)
            //{
            //    Console.WriteLine("isContition = True");
            //}
            //else
            //{
            //    Console.WriteLine("isContition = False");
            //}



            //if (isContition == false)
            //{
            //    Console.WriteLine("isContition = False");
            //}
            //else if (isContition != true)
            //{
            //    Console.WriteLine("isContition = False");
            //}
            //else
            //{
            //    Console.WriteLine("isContition = True");
            //}
            Console.WriteLine(">>>>>>>>> 0 > x > 20 example 15,10,5 ");
            Console.Write("x : ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 5:
                    Console.WriteLine("x=5");
                    break;
                case 10:
                    Console.WriteLine("x=10");
                    break;
                case 15:
                    Console.WriteLine("x=15");
                    break;

                default:
                    Console.WriteLine("No Idea");
                    break;
            }

        }
    }
}
