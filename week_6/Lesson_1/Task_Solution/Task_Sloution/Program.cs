using System;
using System.Collections.Generic;

namespace Task_Sloution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>> Hello My World! <<<<<<<<<");

            LibraryManager lib = new LibraryManager();

            Book madonna = new Book
            {
                Name = "Xez derili madaonna",
                Author = "Sebahedin Eli",
                PageCount = 75,
                Genere = Genere.Drama
            };

            lib.Add(madonna);

            Book domation = new Book
            {
                Name = "Emperor's Domination",
                Author = "Yan Bi Xiao Sheng ",
                PageCount = 3265,
                Genere = Genere.ScienceFiction
            };

            lib.Add(domation);

            Book wmw = new Book
            {
                Name = " Warlock of the Magus World ",
                Author = "The Plagiarist",
                PageCount = 1200,
                Genere = Genere.ScienceFiction
            };

            lib.Add(wmw);

            Book smw = new Book
            {
                Name = " Warlock of the Magus World ",
                Author = "The Plagiarist",
                PageCount = 1200,
                Genere = Genere.ScienceFiction
            };

            //lib.Add(smw);

            lib.ShowInfo(" Warlock of the Magus World");

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
