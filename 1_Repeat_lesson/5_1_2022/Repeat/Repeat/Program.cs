﻿using System;
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



        }

        

    }


    class Item
    {
        public int number;
    }
}
