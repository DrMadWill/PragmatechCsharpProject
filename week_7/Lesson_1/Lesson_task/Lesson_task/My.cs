using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_task
{
    public static class  My
    {
        public static int ConsInputInt()
        {
            int number =0;
            bool break_loop;
            do
            {
                try
                {
                    Console.Write("Input a number : <<<<<< : ");
                    number = Convert.ToInt32(Console.ReadLine());
                    break_loop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("You don't use full number and don't use number !");
                    break_loop = true;
                }
                
            } while (break_loop);

            return number;
        }

        public static byte ConsInputByte()
        {
            byte number = 0;
            bool break_loop;
            do
            {
                try
                {
                    Console.Write("Input a number : <<<<<< : ");
                    number = Convert.ToByte(Console.ReadLine());
                    break_loop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("You don't use full number and don't use number !");
                    break_loop = true;
                }

            } while (break_loop);

            return number;
        }

        public static string ConsInputString()
        {
            Console.Write("Input text : <<<<<< : ");
            string str = Console.ReadLine();

            return str;
        }

        public static bool IsContinueLoop()
        {
            bool is_continue;
            Console.Write("<<<<<< Are you continue or exit => (Any case / n ) <<< : ");
            string str = Console.ReadLine();
            if (str == "n")
            {
                is_continue = true;
            }
            else
            {
                is_continue = false;
            }

            return is_continue;
        }

        public static void NoteHead(string str)
        {
            Console.WriteLine($"\n---------- >>>>>>>>>> {str} <<<<<<<<<<< ----------");
        }
        public static void NoteInput(string str)
        {
            Console.WriteLine($"<<<<<<<<<<<<< : {str}");
        }
        public static void NoteOutput(string str)
        {
            Console.WriteLine($">>>>>>> : {str}");
        }
    }
}
