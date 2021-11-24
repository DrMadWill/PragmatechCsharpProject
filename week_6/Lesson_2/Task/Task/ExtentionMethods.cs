using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int number) => number % 2 == 1;
        public static bool IsEven(this int number) => number % 2 == 0;

        public static List<int> GetValueIndexes(this List<int> number_list,int number)
        {
            List<int> num_lists = new List<int>();

            for (int i = 0; i < number_list.Count; i++)
            {
                if (number_list[i] == number)
                {
                    num_lists.Add(i);
                }
            }

            return num_lists;
        }

        public static List<int> GetValueIndexes(this string str,char ch)
        {
            List<int> number_list = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    number_list.Add(i);
                }
            }

            return number_list;
        }

        public static bool IsContainsDigit(this string str)
        {
            bool isContainDigit = false;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    isContainDigit = true;
                    break;
                }
                
            }

            return isContainDigit;
        }


    }
}
