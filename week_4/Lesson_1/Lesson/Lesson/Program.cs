using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            //MYWorld MadWill = new MYWorld("Mad","Will");
            //MadWill.Eks_varliqlar();
            //MadWill.Learn();
            //Console.WriteLine(MadWill.Name);
            //Console.WriteLine(MadWill.Container);



            //World add = new World();


            Check dety = new Check();
            //dety.Name = "salam";
            dety.Name = "Salam";
            Console.WriteLine(dety.Name);

        }
    }

    class Check
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                foreach (var item in value)
                {
                    if (Char.IsUpper(item))
                    {
                        _name = value;
                        break;
                    }
                }
            }

        }
    }

    #region Inheritance


    abstract class World
    {
        public string Container;
        public string Name;

        public World(string container,string name)
        {
            this.Container = container;
            this.Name = name;
        }

        public virtual void Eks_varliqlar()
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

        public override void Eks_varliqlar()
        {
            Console.WriteLine("Bu Menim cliskerimdir");
        }

    }
    #endregion

}
