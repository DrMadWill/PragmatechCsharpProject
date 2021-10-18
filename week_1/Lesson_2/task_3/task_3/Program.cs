using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Text : ");
            string text = Console.ReadLine();
            int stop = (text.Length-1) / 2;



            
            int bc = 0;
            for (int i = 0; i <= stop; i++)
            {


                if (text[i] == text[text.Length - 1 - i])
                {

                    bc += 1;
                    Console.WriteLine(bc);
                }


            }

            if (text.Length/2 == bc)
            {
                Console.WriteLine("Good boy");
            }
            else
            {
                Console.WriteLine("Bad boy");
            }


            //string[] sad = new string[] { "salam ", "necesen" };
            //string resault="";
            //foreach (string elemet in sad)
            //{
            //    resault += elemet;
            //}




            ////char a = 'a';
            ////char b = 'c';
            ////resault = Convert.ToString(a) + Convert.ToString(b);


            //Console.WriteLine(resault);



        }
    }
}
