using System;
using System.Collections;
using System.Collections.Generic;


namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Non Generic Type
            //Console.WriteLine("Non Generic Type");

            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add("key", "value");
            //ht.Add("naruto", "hinata");
            //ht.Add("yin", "yang");
            //ht.Add(1, 2);
            //ht.Add(2, 4);

            //Hashtable hash = new Hashtable();
            //hash.Add("Key", "Value");
            //hash.Add("Crack", "Trash");
            //hash.Add("Password", "NeedPasssword");
            //hash.Add(4, 25);

            //------------Tch

            //foreach (DictionaryEntry item in hash)
            //{
            //    Console.WriteLine($"{item.Key} + {item.Value}");
            //}


            //-------------I
            //foreach (var item in hash.Keys)
            //{
            //    Console.WriteLine(hash[item]);
            //}


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

            //Stack st_type = new Stack();// Last in , First out
            //st_type.Push("Mad");
            //st_type.Push(25);
            //st_type.Push("will");
            //st_type.Push("Domation");
            //st_type.Push("Road");
            ////st_type.Pop();


            //foreach (var item in st_type)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"----------->> {st_type.Peek()} <<-------------------");

            #endregion

            #region Queue

            //Queue my_duck = new Queue();
            //my_duck.Enqueue(25);
            //my_duck.Enqueue("SatAgenty");
            //my_duck.Enqueue("Can fly");
            //my_duck.Enqueue(17);

            ////my_duck.Dequeue();


            //foreach (var item in my_duck)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion

            #region Generic Type
            Console.WriteLine("Generic Type");
            #region List <>

            //List<int> list_number = new List<int>();

            //list_number.Add(1);
            //list_number.Add(2);
            //list_number.Add(11);
            //list_number.Add(22);
            //list_number.Add(13);
            //list_number.Add(24);

            //foreach (var item in list_number)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Stack <>

            //Stack<int> generic_stack = new Stack<int>();
            //generic_stack.Push(1);
            //generic_stack.Push(2);
            //generic_stack.Push(7);
            //generic_stack.Push(26);

            //foreach (var item in generic_stack)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Queue <>
            //Queue<string> generic_queue = new Queue<string>();
            //generic_queue.Enqueue("Domation");
            //generic_queue.Enqueue("Road");
            //generic_queue.Enqueue("Mad");
            //generic_queue.Enqueue("Will");

            //foreach (var item in generic_queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary <>

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "ideal");
            dict.Add(2, "Life");
            dict.Add(3, "most");
            dict.Add(4, "Art");

            foreach (var item in dict)
            {
                Console.WriteLine($"key : {item.Key} values : {item.Value} ");
            }

            #endregion

            #endregion



        }
    }
}



