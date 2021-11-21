using System;
using System.Net.Mail;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string name = "emao@gmail.com";
            //Console.WriteLine(name.IsEmail());

            //Console.WriteLine(SumOdds(1,3,6,8));

            //Console.WriteLine(Sum(IsOdd,1,2,3));


            Action<int, int> writeNumber = delegate (int a, int b)
               {
                   Console.WriteLine($">> Method 1 >> Number {a} ,{b}");
               };

            writeNumber += WriteMethod2;

            writeNumber += (a, b) =>
            {
                Console.WriteLine($">> Method 3 >> Number {a} ,{b}");
            };

            writeNumber.Invoke(4, 5);
            
            #region Delegate
            //Writers write = new Writers(WriterEven);

            //write += WriterDivsibleBy3;

            //write += delegate (int a)
            // {
            //     Console.WriteLine($" Numeber {a}  is {(a % 4 == 0 ? "Divsible By 4" : "not Divsible By 4")}");
            // };

            //write.Invoke(20);
            #endregion

        }

        public static void WriteMethod2(int a, int b)
        {
            Console.WriteLine($">> Method 2 >> Number {a} ,{b}");
        }

        #region Delegate
        public delegate void Writers(int a);

        public static void WriterEven(int a)
        {
            Console.WriteLine($" Numeber {a}  is {(a%2==0? "even":"odd")}");
        }

        public static void WriterDivsibleBy3(int a)
        {
            Console.WriteLine($" Numeber {a}  is {(a % 3 == 0 ? "Divsible By 3" : "not Divsible By 3")}");
        }


        public delegate bool Check(int number);
        public static bool IsOdd(int a) => a % 2 == 1;
        public static bool İsEven(int a) => a % 2 == 0;

        public  static int Sum(Check method,params int[] numbers)
        {
            int resault = 0;
            foreach (var item in numbers)
            {
                if (method(item))
                {
                    resault += item;
                }
            }

            return resault;
        }


        //public static int SumOdds(params int[] numbers)
        //{
        //    int resault = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 1)
        //        {
        //            resault += item;
        //        }
        //    }

        //    return resault;
        //}

        //public static int SumEvens(params int[] numbers)
        //{
        //    int resault = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            resault += item;
        //        }
        //    }

        //    return resault;
        //}
        #endregion
    }
}
