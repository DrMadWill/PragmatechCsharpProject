using System;
using System.Text;

namespace task_2_Reverse_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Text : ");
            string texts = Console.ReadLine();
             
            string outline;
            int texts_length = texts.Length - 1;

            for (int i = 0; i < texts.Length; i++)
            {
                outline =Convert.ToString(texts[texts_length - i]);
                Console.Write(outline);
                
            }

            
            
            
        }
    }
}
