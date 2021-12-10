using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Group
{
    class Student
    {
        private static int total;

        private int _id;
        public int Id { get { return _id; } }

        // Group ID Relation
        private int _groupid;
        public int GroupId { get { return _groupid; } }


        private string _name;
        public string Name { get { return _name; } }

        private string _surename;
        public string SureName { get { return _surename; } }


        public Student(string name,string surename,int groupid)
        {
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surename))
                throw new Exception("Student Name and SureName Not Empty");
            else
            {
                total++;
                this._id = total;
                this._groupid = groupid;
                Update(name, surename);
            }

        }

        //Update For List
        public void Update(string name,string surename)
        {
            this._name = name;
            this._surename = surename;
        }

    }
}
