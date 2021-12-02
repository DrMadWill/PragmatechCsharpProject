using System;

namespace _1_5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            int[] numbers = new int[3];
            int[] numbers_1 = { 1, 2, 3, 5 };

            string[] text_list = { "Domation", "of", "Road", "Mad", "Will" };


            numbers[1] = 5;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine(numbers[2]);

            Test dr = new Test("Dr");
            Test Mad = new Test("Mad");
            Test Will = new Test("Will");
            Test[] List = { dr, Mad, Will };

            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i].Name);
            }
           
            
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
