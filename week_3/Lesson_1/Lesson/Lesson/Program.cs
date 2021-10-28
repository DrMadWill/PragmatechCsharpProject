using System;
using System.Collections;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Non Generic Type
            Console.WriteLine("Non Generic Type");

            #region Hashtable
            //hashtable ht = new hashtable();
            //ht.add("key", "value");
            //ht.add("naruto", "hinata");
            //ht.add("yin", "yang");
            //ht.add(1, 2);
            //ht.add(2, 4);
            
            

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            

            //foreach (var k in ht.Keys)
            //{
            //    Console.WriteLine(ht[k]);
            //}
            #endregion

            #region Stack

            //Stack st_type = new Stack();
            //st_type.Push("Mad");
            //st_type.Push(25);
            //st_type.Push("will");

            //foreach (var item in st_type)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Queue

            Queue my_duck = new Queue();
            my_duck.Enqueue(25);
            my_duck.Enqueue("SatAgenty");
            my_duck.Enqueue("Can fly");


            foreach (var item in my_duck)
            {
                Console.WriteLine(item);
            }

            #endregion


            #endregion



        }
    }
}



