using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Sloution
{
    class LibraryManager : ILibraryManager
    {
        public List<Book> Books { get; set; }

        public LibraryManager()
        {
            this.Books = new List<Book>();
        }

        public void Add(Book newbook)
        {
            bool isNameAdd = false;

            foreach (var item in this.Books)
            {
                if (item.Name.ToLower().Trim() == newbook.Name.ToLower().Trim())
                {
                    isNameAdd = true;
                    break;
                }
            }

            if (!isNameAdd)
            {
                this.Books.Add(newbook);
            }
            else
            {
                throw new SameBookAlreadyAddedException("This Book Already Added");
            }
        }

        public List<Book> Filter(string author, Genere genere)
        {
            throw new NotImplementedException();
        }

        public void Remove(string book)
        {
            throw new NotImplementedException();
        }

        public List<Book> Search(string value)
        {
            throw new NotImplementedException();
        }

        public void ShowInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
