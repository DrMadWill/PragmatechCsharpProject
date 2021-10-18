using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Texs : ");
            string ast= Console.ReadLine();
            Console.Write("Remove elment : ");
            string remove = Console.ReadLine();


            string resault = "";
            for (int i = 0; i < ast.Length; i++)
            {
                if (Convert.ToString(ast[i]) == remove)
                {
                    continue;
                }
                resault += Convert.ToString(ast[i]);

            }

            Console.WriteLine(resault);


        }
    }
}
