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

            Hashtable ht = new Hashtable();
            ht.Add("Key", "Value");
            ht.Add("Naruto", "Hinata");
            ht.Add("Yin", "Yang");
            ht.Add(1, 2);
            ht.Add(2, 4);
            
            

            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            

            foreach (var k in ht.Keys)
            {
                Console.WriteLine(ht[k]);
            }



            #endregion



        }
    }
}



