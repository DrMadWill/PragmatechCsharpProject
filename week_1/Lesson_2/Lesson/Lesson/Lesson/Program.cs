using System;
using System.Text;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            


            string a = "MadWill";

            string b = "salam ";

            string eded = "5";

            #region String method

            //Console.WriteLine("Hello World!");

            //StringBuilder testing = new StringBuilder();

            //testing.Append("Salam");
            //testing.Append("-----salam");

            //Console.WriteLine(testing);


            //Console.WriteLine(b.Length);
            //string replacede = b.Replace('s', 'S');
            //Console.WriteLine((b.Trim()));
            //Console.WriteLine((b.Trim()).Length);

            //console.writeline(replacede);

            //console.writeline(a.lastindexof('d'));

            //console.writeline(string.isnullorempty(b));

            //console.writeline(a.equals(b));

            #endregion

            #region Array

            //int[] nas = { 1, 4, 4 };
            //long ads = nas[1];
            //Console.WriteLine(ads);

            //int refout;

            //ChangeNumber(out refout);
            //Console.WriteLine(refout);

            int[] arr = new int[5];

            int[] arr2 = new int[3] { 1, 2, 3 };

            int[] arr3 = { 1, 5, 6, 7 };

            string[] arr4 = new string[] { "salam", "hello" };

            #endregion
        }

        public static void ChangeNumber(out int refout)
        {
            refout = 100;
        }




    }
}
