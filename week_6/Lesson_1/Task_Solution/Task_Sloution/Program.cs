using System;
using System.Collections.Generic;

namespace Task_Sloution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
        }
    }


    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Genere Genere;
    }

    public enum Genere
    {
        Detective,
        Drama,
        ScienceFiction
    }

    


}
