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
            int stop = (text.Length - 1) / 2;
            int eded1 = text.Length / 2;
            float eded = (text.Length) / 2f;

            float yokla = eded - (float)eded1 ;
            Console.WriteLine(">>>> yokla >>>"+yokla);


            int bc = 0;
            for (int i = 0; i <= stop; i++)
            {

                

                if (text[i] == text[text.Length - 1 - i])
                {

                    bc += 1;
                    Console.WriteLine(">>>>> if >>>"+bc);
                }
                if (yokla > 0 && i == stop)
                {
                    bc = bc - 1;
                }


            }

            if ((text.Length -1)/ 2 == bc)
            {
                Console.WriteLine(">>>>> Palindromdur");
            }
            else
            {
                Console.WriteLine(">>> Palimdrom deyil");
            }





        }
    }
}
