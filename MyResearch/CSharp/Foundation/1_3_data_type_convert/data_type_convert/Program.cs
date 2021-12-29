using System;
using System.Collections.Generic;
namespace data_type_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. eded : ");
            int eded1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. eded : ");
            int eded2 = Convert.ToInt32(Console.ReadLine());
            int toplama = eded1 + eded2;
            Console.WriteLine($"Toplamanin cavab: {toplama}");
            
            int eded = int.Parse("15");
            Console.WriteLine(eded);

            int intdeyer = 15;
            long longdeyer = intdeyer;
            Console.WriteLine(longdeyer);

            //implicit casting ( automatically ) ozunden boyuk deyerler ozunden kicik deyerleri tuta bilir

            int intdeyer2 = 10;
            long longdeyer2 = intdeyer2;

            float float_deyer = 25.6f;
            double double_deyer = float_deyer;

            Console.WriteLine(double_deyer);




            //explicit casting ( manually )

            long longdeyer_2 = 25;
            int intdyeyer_2 = (int)longdeyer_2;

            double double_deyer_2 = 2332.3;
            float float_deyer_2 = (float)double_deyer_2;

            intdyeyer_2 = (int)double_deyer_2;

            Console.WriteLine(double_deyer_2);


        }
    }
}
