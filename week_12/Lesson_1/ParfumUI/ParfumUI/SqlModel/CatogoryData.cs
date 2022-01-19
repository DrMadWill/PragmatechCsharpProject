using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfumUI.SqlModel
{
    public class CatogoryData
    {
        // Sql Data
        private int _id;
        public int Id { get { return _id; } }


        // Sql Data
        private string _Name;
        public string Name { get { return _Name; } }

        
        public CatogoryData(int Id,string name)
        {
            _id = Id;
            _Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
