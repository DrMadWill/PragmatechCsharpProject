using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region Params
            //getControlPrams(1,2,3,4);

            //int[] variable_int = { 1, 5, 5 };

            //getArray(variable_int);

            #endregion


            GameUser user_1 = new GameUser("MadWill",255);
            user_1.Race = "Learman";

            Console.WriteLine(user_1.UserName);


        }

        #region Params Method
        //public static void getControlPrams(params int[] list)
        //{
        //    foreach (var elemnt in list)
        //    {
        //        Console.WriteLine(elemnt);
        //    }
        //}

        //public static void getArray( int[] list)
        //{
        //    foreach (var elemnt in list)
        //    {
        //        Console.WriteLine(elemnt);
        //    }
        //}
        #endregion

    }

    class GameUser
    {
        public string UserName;
        public int Level;
        public string Race; 

        public GameUser(string user,int level)
        {
            UserName = user;
            Level = level;
        }


    }





}
