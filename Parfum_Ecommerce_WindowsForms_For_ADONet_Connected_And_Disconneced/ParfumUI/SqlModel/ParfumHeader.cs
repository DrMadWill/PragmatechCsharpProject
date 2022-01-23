using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfumUI
{
    public class ParfumHeader
    {
        // Sql Id
        private int _Id;
        public int Id { get { return _Id; } }

        // ComboBox item
        private int _comboIndex;
        public int ComboIndex { get { return _comboIndex; } }

        // Sql Brend + Name
        private string _Header;
        public string Header { get { return _Header; } }

        public ParfumHeader(int Id, string Header)
        {
            _Id = Id;
            _Header = Header;
        }

        public ParfumHeader(int Id, string Header, int comboindex)
        {
            _Id = Id;
            _Header = Header;
            _comboIndex = comboindex;
        }

        public override string ToString()
        {
            return Header;
        }
    }
}
