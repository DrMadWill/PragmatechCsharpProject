using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Sloution
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books { get { return _books; } set { _books = value; } }

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
            string lowercase = author.Trim().ToLower();
            List<Book> list = new List<Book>();
            foreach (var item in this.Books)
            {
                if(item.Author.ToLower().Trim().Equals(lowercase) && item.Genere.Equals(genere))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public void Remove(string book)
        {
            string lowername = book.Trim().ToLower();
            Book remove = this.Books.Find(x => x.Name.Trim().ToLower().Equals(lowername));
            if (remove != null)
            {
                this.Books.Remove(remove);
            }
        }

        public List<Book> Search(string value)
        {
            string lowercase = value.Trim().ToLower();
            List<Book> list = new List<Book>();
            foreach (var item in this.Books)
            {
                if (item.Author.ToLower().Trim().Equals(lowercase) || item.Name.ToLower().Trim().Equals(lowercase))
                {
                    list.Add(item);
                }
            }

            return list;

        }

        public void ShowInfo(string name)
        {
            
            Book showbook = this.Books.Find(x => x.Name.Trim().ToLower() == name.ToLower().Trim());
            if (showbook != null)
            {
                Console.WriteLine($" Book Name : {showbook.Name} / Book Author : {showbook.Author} / Book Page Count : {showbook.PageCount} / Book Genere : {showbook.Genere}");
            }
            else
            {
                throw new BookNotFoundException("Not Found This Book");
            }
        }
    }
}
