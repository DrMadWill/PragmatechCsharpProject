using System;

namespace Lesson
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate New Using

            //Cws Cons = new Cws(Cwrite);
            //Cons += Cwrt;
            //Cons -= Cwrite;

            //Cons.Invoke();

            #endregion


            //Action Cons = Cwrite;
            //Cons += Cwrt;
            //Cons.Invoke();

            C = Cwrite;
            C += Program_C;
            C += Cwrt;
            C();


        }

        private static void Program_C()
        {
            My.NoteOutput("Not Found ");
        }

        static event Cws C;

        static void Cwrite()
        {
            My.NoteHead("Hello My WWorld");
        }


        static void Cwrt()
        {
            My.NoteHead("Hello I");

        }


    }

    public delegate void Cws();

}
