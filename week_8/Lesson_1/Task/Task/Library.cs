using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Task
{
    class Library
    {
        private List<Book> _books;

        public List<Book> Books { get { return _books; } }

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(string name, string isbnNo, int genereid, int price,string genreName)
        {
            try
            {
                if (IsUniq(isbnNo))
                {

                    
                    if (name == "" || isbnNo == "" || price == 0 || genereid < 0)
                        throw new Exception("Empty value not added");
                    else
                    {
                        Book book = new Book(name, isbnNo, genereid, price, genreName);
                        _books.Add(book);
                    }
                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            

        }
        
        public Book GetFindBook(string name)
        {
            Book findBook = this._books.Find(e => e.Name.Trim().ToLower() == name.Trim().ToLower());
            return findBook;
        }

        private bool IsUniq(string isbnNo)
        {
            bool isuniq;
            Book uniqbook = Books.Find(e => e.ISBNNo.Trim().ToLower() == isbnNo.Trim().ToLower());
            if (uniqbook != null)
            {
                throw new Exception("This Already Added");
            }
            else
                isuniq = true;

            return isuniq;
        }
    }
}
