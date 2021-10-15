using System;

namespace _5_ededin_edediortasi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Bes ededin ededi ortasi");
                Console.Write("1) reqem : ");
                int first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("2) reqem : ");
                int second_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("3) reqem : ");
                int third_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("4) reqem : ");
                int fourth_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("5) reqem : ");
                int fifth_number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Ededi ordta : {Edediorta(first_number, second_number, third_number, fourth_number, fifth_number)}");
                Console.Write("Tekrar : any/n >>>");
                string yokla = Console.ReadLine();
                if (yokla == "n")
                {
                    break;
                }
            }

        }


        public static int Edediorta(int first_number, int second_number, int third_number, int fourth_number, int fifth_number)
        {
            int resault = (first_number + second_number + third_number + fourth_number + fifth_number) / 5;
            return resault;

        }
        
    }
}
