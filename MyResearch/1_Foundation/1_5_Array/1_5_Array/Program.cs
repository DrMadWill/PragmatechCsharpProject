using System;
using System.Collections.Generic;

namespace _1_5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello My World!");

            int[] numbers = new int[3];
            int[] numbers_1 = { 1, 2, 3, 5 };


            Array.Reverse(numbers_1);
            for (int i = 0; i < numbers_1.Length; i++)
            {
                Console.WriteLine(numbers_1[i]);
            }

            string[] text_list = { "Domation", "of", "Road", "Mad", "Will" };
            Array.Sort(text_list);
            for (int i = 0; i < text_list.Length; i++)
            {
                Console.WriteLine(text_list[i]);
            }

            string[] texts = new string[2];
            texts[0] = "Name";
            //Console.WriteLine(texts[1]);

            numbers[1] = 5;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            

            //Console.WriteLine(numbers[2]);

            Test dr = new Test("Dr");
            Test Mad = new Test("Mad");
            Test Will = new Test("Will");
            Test[] list = { dr, Mad, Will };
            


            for (int i = 0; i < list.Length; i++)
            {
                //Console.WriteLine(list[i].Name);
            }


            List<int> ededler = new List<int>() { 1, 3, 4, 5 };
            
        }
    }


    class Test
    {
        public string Name;
        public Test(string name)
        {
            this.Name = name;
        }
    }
}
