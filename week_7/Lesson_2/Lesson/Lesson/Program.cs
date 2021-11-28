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



            //C = Cwrite;
            //C += Program_C;
            //C += Cwrt;
            //C();


            MVC mVC = new MVC(500);
            // Atm
            mVC.BalanceFinisid += (a, b) =>
            {
                My.NoteOutput($"Balansda {b} qederdir. Istenir {a}");
            };
            //User
            mVC.BalanceFinisid += UserBalanceFinshed;

            mVC.TransferSuccessfly += (z, y, time) =>
            {
                My.NoteOutput($"{time} vaxta {z} qeder mebleq balasdan cixarildi. qaliq {y}");
            };

            mVC.WithDraw(100);
            mVC.WithDraw(150);
            mVC.WithDraw(260);

        }


        public static void UserBalanceFinshed(double a, double b)
        {
            My.NoteOutput($"hazirda balancda {a} qeder mebleq yoxdur . Balanc {b} AZN");
        }


        #region My Research
        private static void Program_C()
        {
            My.NoteOutput("Not Found ");
        }

        

        static void Cwrite()
        {
            My.NoteHead("Hello My WWorld");
        }


        static void Cwrt()
        {
            My.NoteHead("Hello I");

        }

        public static event Cws C;

        #endregion
    }


    class MVC
    {
        public event Action<double, double> BalanceFinisid;
        public event Action<double, double, DateTime> TransferSuccessfly;


        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }

        }


        public MVC(double balance)
        {
            Balance = balance;
        }


        public void WithDraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                if (TransferSuccessfly != null)
                {
                    TransferSuccessfly.Invoke(amount, Balance, DateTime.Now);
                }
                return;
            }
            else
            {
                if (BalanceFinisid != null)
                {
                    BalanceFinisid.Invoke(amount, Balance);
                }
            }
        }

    }   

    public delegate void Cws();

}
