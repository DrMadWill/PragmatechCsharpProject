using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfumUI.SqlModel
{
    class SalePriceData
    {

        // Sql Id
        private int _Id;
        public int Id { get { return _Id; } }

        // Sql Size
        private int _Size;
        public int Size { get { return _Size; } }

        // Sql Price
        private int _Price;
        public int Price { get { return _Price; } }

        // Sql number
        private int _Count;
        public int Count { get { return _Count; } }


        public SalePriceData(int Id,int size, int price, int count)
        {
            _Id = Id;
            _Size = size;
            _Price = price;
            _Count = count;
        }

        public override string ToString()
        {
            return $"{Size}ML / {Price}AZN / {Count}";
        }
    }
}
