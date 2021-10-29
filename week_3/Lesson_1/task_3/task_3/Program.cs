using System;
using System.Collections.Generic;
namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            List<int> numb = new List<int>();
            int add;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("<<<<<<<<<<<< : ");
                add = Convert.ToInt32(Console.ReadLine());
                numb.Add(add);

            }


            List<int> first_5 = new List<int>();
            List<int> last_5 = new List<int>();
            for (int i = 0; i < numb.Count; i++)
            {
                if (i < 5)
                {
                    first_5.Add(numb[i]);
                }
                else
                {
                    last_5.Add(numb[i]);
                }
            }

            List<int> newlist = new List<int>();
            newlist.AddRange(last_5);
            newlist.AddRange(first_5);
            Console.WriteLine("******************************************");
            foreach (var item in newlist)
            {
                Console.WriteLine(">>>>>>>>>>>>>"+item);
            }


        }
     }
}
