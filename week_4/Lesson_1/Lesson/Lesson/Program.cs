using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            MYWorld MadWill = new MYWorld("Mad","Will");
            MadWill.Eks_varliqlar();
            Console.WriteLine(MadWill.Name);
            Console.WriteLine(MadWill.Container);

            //World add = new World();


        }
    }




    abstract class World
    {
        public string Container;
        public string Name;

        public World(string container,string name)
        {
            this.Container = container;
            this.Name = name;
        }

        public void Eks_varliqlar()
        {
            Console.WriteLine("Bir birine qarsi mubarize");
        }

    }

    class MYWorld : World
    {
        public MYWorld(string container,string name):base(container,name)
        {

        }

        public void Learn()
        {
            Console.WriteLine("Gercekliyi oyren ,sebebleri oyern ,meqsedi oyren oyren oyer ..........");
        }
    }


}
