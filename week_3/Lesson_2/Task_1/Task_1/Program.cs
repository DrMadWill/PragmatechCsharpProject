using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            Group clas = new Group("MadWill",5);
            clas.Students = new List<Group>();


        }
    }


    class Student
    {
        public static int Count;
        public int No;
        public string Name;
        public string SureName;
        
        public Student(string name,string surename)
        {

            this.Name = name;
            this.SureName = surename;
            Count++;
            this.No = Count;

        }

        

    }

    class Group
    {
        public string Name;
        public int No;
        public static int Cout = 100;
        private readonly int Capacity;

        public List<Group> Students = new List<Group>();
 
        public Group(string name,int capasty)
        {
            this.Name = name;
            Cout++;
            this.No = Cout;
            this.Capacity = capasty;

        }

        


    }
}
