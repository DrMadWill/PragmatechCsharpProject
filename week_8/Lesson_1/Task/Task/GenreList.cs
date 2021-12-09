using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class GenreList
    {
        public List<Genre> genres;
        public GenreList()
        {
            genres = new List<Genre>();
        }

        public void AddGenre(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Genre genre = new Genre(name);
                genres.Add(genre);
            }
        }

        public int FindGenreId(string name)
        {
            Genre genre = genres.Find(e => e.Name.Trim().ToLower() == name.Trim().ToLower());
            if (genre != null)
                return genre.GenreId;
            else
                throw new Exception("Not Found This Genre");
        }


        public string FindGenre(int id)
        {
            string name="";
            foreach (var item in genres)
            {
                if (item.GenreId == id)
                {
                    name = item.Name;
                    break;
                }
            }
            return name;
            //if (genre != null)
            //    return genre.Name;
            //else
            //    throw new Exception("Not Found This Genre");
        }

        public List<string> GetGenreNames()
        {
            List<string> genreName = new List<string>();

            foreach (var item in genres)
            {
                genreName.Add(item.Name);
            }

            return genreName;
        }

    }
}
