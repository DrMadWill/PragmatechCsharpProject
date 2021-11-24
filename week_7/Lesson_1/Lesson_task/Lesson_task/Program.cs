using System;
using System.Text;

namespace Lesson_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            
            Console.OutputEncoding = Encoding.UTF8;
            string method;
            byte month;
            bool is_conitue;
            do
            {
                My.NoteHead("Methods");
                My.NoteOutput("1.Ayin adini yazdirmaq");
                My.NoteOutput("2. Feslin adini yazdirmaq");
                My.NoteInput("Bir method secin");
                method = My.ConsInputString();
                My.NoteInput("bir ay secin");
                month = My.ConsInputByte();
                My.NoteOutput(ChooseMethod(method, month));
                My.NoteHead("Yeidən Ay Seçimi ?");
                is_conitue = !My.IsContinueLoop();
            } while (is_conitue);
            


            //Action<int> goster = delegate (int a)
            //{
            //    Action<int> ad = MenfiYokla;
            //    ad += DivsibleBy5;
            //    ad += Even;
            //    ad.Invoke(a);
            //};

            //goster.Invoke(5);

        }
        

        //public static void MenfiYokla(int a) => Console.WriteLine(a < 0 ? "Menfi" : "Musbet");
        //public static void DivsibleBy5(int a) => Console.WriteLine(a % 5 == 0 ? "Divsible" : "Not Divsible");
        //public static void Even(int a) => Console.WriteLine(a % 2 == 0 ? "even" : "odd");




        public delegate string Print(byte a);

        public delegate string ChoosMounth(string method, byte month);

        public static string PrintSeasonName(byte month_number)
        {
            string sizon;
            switch (month_number)
            {
                case 12:
                case 1:
                case 2:
                    sizon = "Qiş";
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
                    sizon = "Belə bir ay yoxdur!";
                    break;
            }

            return sizon;
        }
        public static string  TranslateMonthName(byte month_number)
        {
            string month = month_number switch
            {
                1 => "Yanvar",
                2 => "Fevral",
                3 => "Mart",
                4 => "Aprel",
                5 => "May",
                6 => "Iyun",
                7 => "Iyul",
                8 => "Avqust",
                9 => "Sentyabr",
                10 => "Oktyabr",
                11 => "Oktyabr",
                12 => "Dekabır",
                _ => "Belə bir ay mövcud deyildir!",
            };
            return month;
        }

        public static string ChooseMethod(string method, byte month)
        {
            Print print;
            
            if (method == "1")
            {
                My.NoteHead("Ay göstərir");
                print = TranslateMonthName;
                
            }
            else
            {
                My.NoteHead("Sezon göstərir");
                print = PrintSeasonName;
            }
            return print.Invoke(month);
        }

        
    }
}
