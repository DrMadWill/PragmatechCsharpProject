using System;

namespace TestinInternal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            Console.WriteLine(" Choos Your Will ");

        }
    }

    class Will //: Person // Don't use able Base Person Class
    {

    }

    abstract class Site_Operation
    {
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();


    }


    class Allen : Site_Operation
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }

    interface ISite_Opertion_CR
    {
        void Create();
        void Read();

    }

    interface ISite_Opation_UD
    {
        void Update();
        void Delete();
    }

    class MadWill : ISite_Opertion_CR,ISite_Opation_UD
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Novel : ISite_Opertion_CR
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }

}
