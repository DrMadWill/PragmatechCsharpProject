using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Task
{
    class Book
    {
        private string _name;
        public string Name { get { return _name; } }
        
        private string _ISBNNo;
        public string ISBNNo => _ISBNNo;
        
        private int _price;
        public int Price { get { return _price; } }
        
        private int _GenreId;
        public int GenreType { get { return _GenreId; } }

        private string _id;
        public string Id { get { return _id; } }

        public static int Total;


        private bool IsName(string name )
        {
            bool is_null_or_empty;
            if (string.IsNullOrEmpty(name.Trim()))
                throw new Exception("Not Use This Name");
            else
                is_null_or_empty = true;

            return is_null_or_empty;
        }


        public Book(string name,string isbnNo,int genreid,int price,string genreName)
        {
            try
            {
                if (IsName(name) && IsName(name) && price != 0)
                {
                    ++Total;
                    this._id = genreName + Total;
                    this._name = name;
                    this._ISBNNo = isbnNo;
                    this._price = price;
                    this._GenreId = genreid;
                    
                }
                else
                    throw new Exception("This Book Not Usible.");
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



    }

    

    

    //public enum Genre
    //{
    //    Novel=1,Story=2,Theater=3
    //}

}
