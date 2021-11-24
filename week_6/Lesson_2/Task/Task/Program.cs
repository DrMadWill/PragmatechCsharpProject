using System;
using System.Collections.Generic;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string password = "adssddds202";
            int number = 25;
            My.NoteOutput($"Resault => {password.IsContainsDigit()}");
            My.NoteOutput($"Resault => {number.IsOdd()}");
            My.NoteOutput($"Resault => {number.IsEven()}");
            foreach (var item in password.GetValueIndexes('d'))
            {
                My.NoteOutput($"Resault => {item}");
            }

            List<int> numbs = new List<int>
            {
                5,
                6,
                5,
                7,
                5
            };


            foreach (var item in numbs.GetValueIndexes(5))
            {
                My.NoteOutput($"Resault => {item}");
            }



        }
    }

}
