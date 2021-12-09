using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Genre
    {
        public static int total;
        private int _genereId;
        public int GenreId { get { return _genereId; } }

        private string _name;
        public string Name { get { return _name; } }

        public Genre(string genre)
        {
            if (string.IsNullOrEmpty(genre))
                throw new Exception("Genre Not Able Empty");
            else
            {
                total++;
                this._name = genre;
                this._genereId = total;
            }
        }


        public string GetGenre(int id)
        {
            return this.Name;
        }

    }




}
