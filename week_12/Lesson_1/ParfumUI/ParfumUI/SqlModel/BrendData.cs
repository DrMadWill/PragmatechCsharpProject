using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfumUI.SqlModel
{
    public class BrendData
    {
        // Sql Data
        private int _id;
        public int Id { get { return _id; } }


        // Sql Data
        private int _size;
        public int Size { get { return _size; } }

        
        public BrendData(int Id,int size)
        {
            _id = Id;
            _size = size;
        }

        public override string ToString()
        {
            return $"{Size}";
        }
    }
}
