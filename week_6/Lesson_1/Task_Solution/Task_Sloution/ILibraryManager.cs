using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Sloution
{
    interface ILibraryManager
    {
        public List<Book> Books { set; get; }
        public void Add(Book newbook);
        public void ShowInfo(string name);
        public List<Book> Search(string value);
        public List<Book> Filter(string author, Genere genere);
        public void Remove(string book);
    }
}
