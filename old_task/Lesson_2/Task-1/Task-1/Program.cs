using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("get g'l'rs'n");

            string a = "get yuxu gor cirpil yere oyan sonra gelresen";
            Console.WriteLine(a);

            string[] soz = a.Split();
            int c = 1;


            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(soz[i]);
            //    c++;
            //    Console.WriteLine(c);

            //}

            c++;

            //if (c > 1)
            //{
            //    Console.WriteLine("------------isleyir");
            //}


            //string deyeryoxalma = c == 2 ? "2 den bouykuk" : "2 den kicik";
            //Console.WriteLine(deyeryoxalma);

            string testing = "25";
            int nuberconvert = Convert.ToInt32(Console.ReadLine());
            int testingconvert = Convert.ToInt32(testing);
            int toplama = testingconvert + nuberconvert;
            Console.WriteLine(toplama);
        }
    }
}
