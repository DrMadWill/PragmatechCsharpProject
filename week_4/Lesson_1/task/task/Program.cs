using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");


            User MadWill = new User("Maad@gmail.com","Salam12647");
            MadWill.FullName = "DR.MadWill";
            MadWill.ShowInfo();


        }


    }

    abstract class Account
    {
        public abstract bool PasswordChecker(string password);


        public virtual void ShowInfo()
        {
            Console.WriteLine("Not Found Information");
        }
    }


    class User : Account
    {
        public string FullName { get; set; }

        public string Email;
        

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (this.PasswordChecker(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("PassWord Telebleri odemir");
                }
            }
        }

        public User(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }


        public override bool PasswordChecker(string password)
        {
            bool isPassword=false;
            if (password.Length > 9 && password.Length < 25)
            {
                if (password.ToUpper() != password && password.ToLower() != password)
                {
                    isPassword = true;
                }
            }

            return isPassword;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Email : {this.Email} , Fullname {this.FullName}");
        }

    }

}
