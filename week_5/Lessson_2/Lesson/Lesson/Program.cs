using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            ICrudForAdmin maid = new User();//ICrudForAdmin basqa hec birirni method ve property gormur
            ICrudForAdmin.Create();


        }
    }

    


    interface ICrudForAdmin
    {
        public static void Create()
        {
            Console.WriteLine("I am Created");
        }

        void Update();
        

    }

    interface ICrudForClent
    {
        void Read();
    }


    class User : ICrudForClent,ICrudForAdmin
    {
        public void Read()
        {
            Console.WriteLine("User Read");
        }

        public void Update()
        {
            Console.WriteLine("User Update");
        }
    }








}
