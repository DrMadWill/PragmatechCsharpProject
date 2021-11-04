using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            MYWorld MadWill = new MYWorld();
            MadWill.Eks_varliqlar();

            //World add = new World();


        }
    }




    abstract class World
    {
        public string Container;
        public void Eks_varliqlar()
        {
            Console.WriteLine("Bir birine qarsi mubarize");
        }

    }

    class MYWorld : World
    {


        public void Learn()
        {
            Console.WriteLine("Gercekliyi oyren ,sebebleri oyern ,meqsedi oyren oyren oyer ..........");
        }
    }


}
