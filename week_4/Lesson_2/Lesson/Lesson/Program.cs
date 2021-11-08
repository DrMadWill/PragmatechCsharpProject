using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            Console.WriteLine("-------- Struct and Class -------------------");

            MW tipic = new MW("Learn","will");
            
            tipic.cw();
            //Console.WriteLine(tipic.Ideal);


            WR testing = new WR();
            

        }
    }

    struct MW
    {
        public string Ideal;
        string Life;

        public MW(string ideal,string life)
        {
            this.Ideal = ideal;
            this.Life = life;
        }

        public void cw()
        {
            Console.WriteLine(this.Ideal);
        }

    }

    class WR
    {
        
        string anime;
        string bools;
    }
}
