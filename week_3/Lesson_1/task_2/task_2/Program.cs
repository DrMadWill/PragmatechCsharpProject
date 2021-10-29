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
            que.Enqueue("25");




            List<string> reserve = new List<string>();

            foreach (var item in que)
            {
                reserve.Add(item);

            }

            reserve[reserve.Count-1]="Misson Complited";
            que.Clear();

            foreach (var item in reserve)
            {
                que.Enqueue(item);

            }




            foreach (var item in que)
            {
                Console.WriteLine(">>> " + item);
            }

        }
    }
}
