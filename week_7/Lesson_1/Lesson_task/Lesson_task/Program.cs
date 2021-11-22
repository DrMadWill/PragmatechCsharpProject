using System;
using System.Text;

namespace Lesson_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Print print = new Print(PrintSeasonName);

            //print += TranslateMonthName;

            //byte num=Convert.ToByte(Console.ReadLine());
            //print.Invoke(num);

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("**Methods** \n 1. Ayin adini yazdirmaq \n 2. Feslin adini yazdirmaq");
            //Console.WriteLine("Bir method secin");
            //string method = Console.ReadLine();
            //Console.WriteLine("bir ay secin");
            //byte month = byte.Parse(Console.ReadLine());
            //Console.WriteLine(ChooseMethod(method, month));
            Action<int> goster = delegate (int a)
            {
                Action<int> ad = MenfiYokla;
                ad += DivsibleBy5;
                ad += Even;
                ad.Invoke(a);
            };

            goster.Invoke(5);

        }
        

        public static void MenfiYokla(int a) => Console.WriteLine(a < 0 ? "Menfi" : "Musbet");
        public static void DivsibleBy5(int a) => Console.WriteLine(a % 5 == 0 ? "Divsible" : "Not Divsible");
        public static void Even(int a) => Console.WriteLine(a % 2 == 0 ? "even" : "odd");




        public delegate string Print(byte a);

        public delegate string ChoosMounth(string method, byte month);

        public static string PrintSeasonName(byte b)
        {
            string sizon;
            switch (b)
            {
                case 12:
                case 1:
                case 2:
                    sizon = "qis";
                    break;
                case 3:
                case 4:
                case 5:
                    sizon = "Yaz";
                    
                    break;
                case 6:
                case 7:
                case 8:
                    sizon = "Yay";
                    break;
                case 9:
                case 10:
                case 11:
                    sizon = "Payiz";
                    
                    break;
                default:
                    sizon = "Bele bir ay yoxdur";
                    break;
            }

            return sizon;
        }
        public static string  TranslateMonthName(byte b)
        {
            string month;
            switch (b)
            {
                case 1:
                    month = "Yanvar";
                    break;
                case 2:
                    month = "Fevral";
                    break;
                case 3:
                    month = "Mart";
                    break;
                case 4:
                    month = "Aprel";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Iyun";
                    break;
                case 7:
                    month = "Iyul";
                    break;
                case 8:
                    month = "Avqust";
                    break;
                case 9:
                    month = "Sentyabr";
                    break;
                case 10:
                    month = "Oktyabr";
                    break;
                case 11:
                    month = "Oktyabr";
                    break;
                case 12:
                    month = "Dekabir";
                    break;

                default:
                    month = "belə bir fəsil mövcud deyildir";
                    break;
            }

            return month;
        }

        public static string ChooseMethod(string method, byte month)
        {
            Print print = null;
            
            if (method == "1")
            {
                PrintInfo("Month göstərir");
                print = TranslateMonthName;
                
            }
            else
            {
                PrintInfo("Sezon göstərir");
                print = PrintSeasonName;
            }
            return print.Invoke(month);
        }

        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
