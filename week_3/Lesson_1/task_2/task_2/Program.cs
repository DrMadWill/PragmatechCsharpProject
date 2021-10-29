using System;
using System.Collections.Generic;
using System.Collections;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            Queue<string> que = new Queue<string>();
            que.Enqueue("I");
            que.Enqueue("Love");
            que.Enqueue("duck");
            que.Enqueue("but");
            que.Enqueue("What");
            que.Enqueue("is");
            que.Enqueue("Queue");
            que.Enqueue("1");
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");
            que.Enqueue("5");
            que.Enqueue("6");




            int counts=0;
            foreach (var item in que)
            {
                counts += 1;
                if (counts > 10)
                {
                    if (counts == que.Count)
                    {
                        item
                    }
                }
                Console.WriteLine(">>> " + item);
            }

        }
    }
}
