using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Thread Pool
            //Console.WriteLine("Hello World!");
            //ThreadPool.QueueUserWorkItem(WriteMad);
            //Console.WriteLine("Hello I'am Jenis");
            //Console.WriteLine("Class introduct Ended");

            #endregion

            //Console.WriteLine(Y());
            


        }

        #region Thread Pool
        static void WriteMad(object state)
        {
            Console.WriteLine("Inot ended and I live. Mad Firend is So Mad");
        }

        #endregion

        static int Y()
        {
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int z = 0; z < 1000000; z++)
                {
                    x = i + z;
                }
            }
            return x;
        }

        static async void Call()
        {
            string filPath = "C:\Users\nofel\OneDrive\Desktop\Color.txt";

        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;
            Console.WriteLine("Start file reading");
            using (StreamReader reader = new StreamReader(file))
            {
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            Console.WriteLine("reader end");
            return length;
        }

    }
}
