using System;

namespace lessson_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Book Geass = new Book("Code Geass", "Icihara Shirayuji", 250);
            //Book Geass_1 = new Book("Heraku", "Icihara Shirayuji", 250);
            //Book[] books = new Book[2];
            //books[0] = Geass;
            //books[1] = Geass_1;

            //Console.WriteLine(Geass_1.Code);


            int[] astra = { 1, 5, 6 };

            


        }



        public static void GelApar()
        {

        }

    }

    class Book
    {
        public string Code;
        public static int code;
        public string Name;
        public string AthorName;
        public int PageCount;
        


        public Book(string Name,string AthorName,int PageCount)
        {
            this.Name = Name;
            this.AthorName = AthorName;
            this.PageCount = PageCount;
            code++;
            this.Code = this.Name.Substring(0, 2) + Convert.ToString(code);
        }


    }
}
