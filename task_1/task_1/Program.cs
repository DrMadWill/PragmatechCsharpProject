using System;
using System.Collections.Generic;
using System.Collections;


namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------->>>>>>> Hello My World! <<<<<<<-------------");

            Dictionary<string, string> dict = new Dictionary<string, string>();//1 a

            string country;
            string city;

            for (int i = 0; i <2 ; i++)//b
            {
                Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkə adı qeyd edin : ");
                Console.Write("<<<<<<<<<<< : ");
                country = Console.ReadLine();//b1
                Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa ölkəyə aid paytaxt qeyd edin : ");
                Console.Write("<<<<<<<<<<< : ");
                city = Console.ReadLine();//b2
                dict.Add(country, city);
                Console.WriteLine("*******************************************************************");
            }


            string search;
            string isCountine;
            int resault;
            while (true)
            {
                Console.WriteLine("Hörmətli istifadəçi! Zəhmət olmasa paytaxtını tapmaq istədiyiniz ölkənin adını qeyd edin.");
                Console.Write("<<<<<<<<<<< : ");
                search = Console.ReadLine();
                
                if (dict.ContainsKey(search))
                {
                    Console.WriteLine($">>>>>>>>>> : {search} olkesini paytaxti {dict[search]}");

                }
                else
                {
                    Console.WriteLine("Olkenin adini duzgun qeyd edin");
                    continue;
                }

                
                while (true)
                {
                    Console.WriteLine("Yeni paytaxt axtarılsın? Y/N");
                    Console.Write("<<<<<<<<<<< : ");
                    isCountine = Console.ReadLine();
                    if (isCountine == "Y")
                    {
                        resault = 1;
                    }
                    else if (isCountine == "N")
                    {
                        resault = 0;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun ifade daxil edilmedi.");
                        resault = -1;
                    }

                    if (resault == 0 || resault==1)
                    {
                        break;
                    }
                }

                if (resault==1)
                {
                    continue;
                }
                else
                {
                    break;
                }



            }


        }

        
    }
}
