using System;

namespace task_2_Reverse_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Text : ");
            string texts = Console.ReadLine();
             
            string outline="";
            

            for (int i = 0; i < texts.Length; i++)
            {
                outline +=Convert.ToString(texts[texts.Length -1- i]);
                
            }

            Console.WriteLine($"Resault : >> {outline}");

            
            
            
        }
    }
}
