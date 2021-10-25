using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string username;
            string password;
            while (true)
            {
                Console.Write("UserName : ");
                username = Console.ReadLine();
                if (IsUserNameValid(username))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Plase Dont't use sybol");
                }
                
            }

            while (true)
            {
                Console.Write("Password : ");
                password = Console.ReadLine();
                if (IsPasswordValid(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Plase use sybol,digit and password length min =8 and max 25");
                }

                
            }

            Acount user_1 = new Acount(username,password);

            Console.WriteLine($"User Name >> {user_1.UserName} , Password >> {user_1.Password}  ");

        }

        public static bool IsUserNameValid(string username)
        {
            bool isTure=true;

            for (int i = 0; i < username.Length; i++) 
            {
                if (username[i] == '!' || username[i] == '@' || username[i] == '$' || username[i] == '%' || username[i] == '^' || username[i] == '&' || username[i] == '*' || username[i] == '(' || username[i] == ')' || username[i] == '-'|| username[i] == '_' || username[i] == '=' || username[i] == '+' || username[i] == '/')
                {
                    isTure = false;
                    break;
                }
            }
            
            return isTure;
        }

        public static bool IsPasswordValid(string password)
        {

            bool isTure = false;
            string sybol = "!@#$%^&*()_-+=?><|";
            bool is1sert=false;
            bool is2sert = false;

            for (int i = 0; i < password.Length; i++)
            {
                for (int a = 0; a < sybol.Length; a++)
                {
                    if (password.Length > 7 && password.Length < 25)
                    {
                        if (password[i] == sybol[a])
                        {
                            is1sert = true;
                        }




                        if (Convert.ToString(a) ==Convert.ToString( password[i]))
                        {
                            is2sert = true;
                        }



                        if (is1sert && is2sert)
                        {

                            isTure = true;
                            break;

                        }

                    }
                        

                }

                if (isTure == true)
                {
                    break;
                }


            }



            return isTure;
        }


    }


    class Acount
    {
        public string UserName;
        public string Password;
        public int No;


        public static int Count;
        
        public Acount(string UserName,string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
            ++Count;
            this.No = Count;
        }

    }
}
