using System;
using System.Collections.Generic;
using System.Threading;

namespace FindWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action action = new Action(Hello);

            //setTimeout(action, 3000);

            Hello();


        }


        public static void Hello()
        {
            GenerateWord find = new GenerateWord();
            //Console.WriteLine(find.RenderWords()[71]);
            foreach (var item in find.RadomSelectWords(3,3))
            {
                Console.WriteLine(item);
            }
        }

        
    }

    public class GenerateWord
    {
        private string _words = "You can gain experience, if you are careful to " +
            "avoid empty redundancy. Do not fall into the error of the artisan who boasts of twenty " +
            "years experience in craft while in fact he has had only one year of experience–twenty times. " +
            "And never resent the advantage of experience your elders have. Recall that " +
            "they have paid for this experience in the coin of life, and have emptied " +
            "a purse that cannot be refilled.";
        public string Words { get { return _words; } }

        public List<string> RenderWords()
        {
            string words = this.Words.Trim();

            List<string> wordscollection = new List<string>();

            words = words.Replace(",", "").Replace(".", "");

            wordscollection.AddRange(words.Split(' '));

            return wordscollection;
        }

        public List<string> RadomSelectWords(int wordcount,int wordnumber)
        {
            // Select Word
            List<string> words = new List<string>();
            string word = "";
            foreach (var item in SelectIndexs(wordcount, wordnumber))
            {
                for (int i = 0; i < wordnumber; i++)
                {
                    if (i == 0)
                        word += RenderWords()[item];
                    else
                        word += "," + RenderWords()[item+i];

                }
                words.Add(word);
                word = "";
            }

            return words;
        }

        public static void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }

        public List<int> SelectIndexs(int wordcount, int wordnumber)
        {
            // Select index
            List<int> indexes = new List<int>();
            int index;
            for (int i = 1; i < wordcount; i++)
            {
            IndexContain:;

                index = RandomNumber(wordnumber);
                if (indexes.Contains(index))
                {
                    goto IndexContain;
                }
                indexes.Add(index);
            }
            return indexes;
        }

        public int RandomNumber(int count)
        {
            // Generet Random Nummber
            Random rnd = new Random();
            int number = rnd.Next(0, RenderWords().Count- count);
            return number;
        }
    }

    public class User
    {
        
        public int CommonGameWords { get; set; }

        public int TrueWords { get; set; }
        public int FalseWords { get; set; }

        public List<UserFalseWord> userFalseWords = new List<UserFalseWord>();
        private int Score { get; set; }
    }

    public class UserFalseWord
    {
        public string FalseWord;
        public string TrueWord;
    }

}
