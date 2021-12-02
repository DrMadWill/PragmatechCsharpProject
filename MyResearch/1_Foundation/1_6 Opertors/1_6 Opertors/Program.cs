using System;

namespace _1_6_Opertors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 20;
            int b = 10;
            int resault;

            resault = a + b;//30
            resault = a - b;//10
            resault = a * b;//200
            resault = a / b;//2
            resault = a % b;//++
            resault = a++;//20
            resault = ++a;//21

            resault = (int)Math.Pow(2,5);
            resault = (int)Math.Sqrt(25);
            resault = Math.Abs(-35);
            resault = (int)Math.Round(2.6);
            resault = (int)Math.Round(2.3);

            bool iscadition = a > b;
            iscadition = a < b;
            iscadition = a == b;
            iscadition = a != b;
            iscadition = a > b && a < b;
            //iscadition = a < b || a > b;

            Console.WriteLine(iscadition);
            Console.WriteLine("a : " + a);
            Console.WriteLine("resault : "+resault);

            



        }
    }
}
