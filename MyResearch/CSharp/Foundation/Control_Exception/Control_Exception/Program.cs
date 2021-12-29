using System;
using System.Linq;

namespace Control_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            //System.FormatException: Input string was not in a correct format.
            //Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
            //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.

            //Console.Write(">> 1. Number : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write(">> 2. Number : ");
            //int number2 = int.Parse(Console.ReadLine());

            //var resault = number1 / number2;

            //int[] nums = new int[2];
            ////nums[2] = 15;

            //Prodact prodact = null;
            //Console.WriteLine(prodact.MyProperty);

            try
            {
                Console.Write("<< 1. Number : ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("<< 2. Number : ");
                int number2 = int.Parse(Console.ReadLine());
                var resault = number1 / number2;


                Console.WriteLine(resault);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(">> 2. Number not equal 0 ");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(">> You must write number ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(">> Good Boy, you have a error ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(">> End of Program");
            }



        }


        static void CheckPassword(string password)
        {
            if (password.Length < 8 || password.Length > 25)
                throw new Exception("You Dont Use This Password, So Sort or So Big");
            if (!password.Any(Char.IsDigit))
                throw new Exception("You Dont Use This Password, You must use number");
            if (!password.Any(char.IsLetter))
                throw new Exception("You Dont Use This Password, You must use string");
        }


    }

    class Prodact
    {
        public int MyProperty { get; set; }
    }
}
