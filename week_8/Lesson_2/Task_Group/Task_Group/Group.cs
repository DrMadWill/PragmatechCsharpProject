using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Group
{
    class Group
    {
        private static int total;
        private int _id;
        public int Id { get { return _id; } }

        private string _name;
        public string Name { get { return _name; } }

        public Group(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Not Empty Group Name");
            else
            {
                ++total;
                this._id = total;
                this._name = name;
            }
        }
    }
}
