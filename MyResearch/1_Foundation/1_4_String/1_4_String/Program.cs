﻿using System;
using System.Collections.Generic;
using System.Text;
namespace _1_4_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = "Nofel";
            string last_name = "Salahov";
            int age = 25;

            //string str = "My name is " + first_name + last_name + " and I'am " + age + " years old.";
            //string str = string.Format("My name is {0} {1} and I'am {2} years old.",first_name,last_name,age);
            string str =$"My name is {first_name} {last_name} and I'am {age} years old." ;

            string[] texts = new string[] { "My", " name ", " is ",first_name," ",last_name };

            string resault_string = "";
            
            // yaddaş prablemei
            for (int i = 0; i < texts.Length; i++)
            {
                resault_string += texts[i];
            }
            Console.WriteLine(resault_string);

            // yaddaş prablemei
            StringBuilder result_stringBilder = new StringBuilder();
            for (int i = 0; i < texts.Length; i++)
            {
                result_stringBilder.Append(texts[i]);
            }
            Console.WriteLine(result_stringBilder);


            Console.WriteLine(str);
        }
    }
}
