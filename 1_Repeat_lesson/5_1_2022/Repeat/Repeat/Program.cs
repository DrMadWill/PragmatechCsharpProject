using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Value Type
            int a = 5;

            int b = a;

            a = 7;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // Referance Type

            Item item_a = new Item();
            Item item_b = new Item();
            item_a.number = 5;
            item_b = item_a;

            item_a.number = 7;
            //Console.WriteLine(item_a.number);
            //Console.WriteLine(item_b.number);

            // StringBilder

            string txt = "Hello I like Anime. ";
            txt = txt + "Ofcorse I like manga";

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hello I like Anime ");
            stringBuilder.Append("Ofcorse I like manga");


            // Casting

            long long_number = 5;
            int int_number =(int) long_number;


            // Boxing

            //int number = 7;
            //object obj = number;

            // Un Boxing

            object obj = 7;
            int number = (int)obj;


            int j ;

            //Console.WriteLine(j);//7

            //RefMethod(ref j);
            OutMethod(out j);

            //Console.WriteLine(j);//10

            string[] text2 = new string[5] { "Strange", " Book", "Live", "Void","End" };

            string[] text1 = new string[3];

            string[] text3 = new string[] { "Apple", "Orange" };

            string[] text4 = { "Will", "Mad" };

            //int[] numbers = new int[5] { 1, 2 };

            text1[0] = "Header";

            //foreach (var item in text1)
            //{
            //    Console.WriteLine(item);
            //}

            ParamKeyWord(1, 5, 6, 7);

            ParamKeyWord("Will", 7, 8);

        }


        static void RefMethod(ref int number)
        {
            number = 10;
            
        }

        static void OutMethod(out int number)
        {
            number = 5;
        }

        static void ParamKeyWord(params int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void ParamKeyWord(string name,params int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(name);
                Console.WriteLine(item);
            }
        }

    }


    class Item
    {
        public int number;
    }
}
