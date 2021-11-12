using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }

    interface IFuger
    {
        void CalculateArea();
        void CalculatePerimeter();
    }

    class Rectangle : IFuger
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Circle : IFuger
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Square : IFuger
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
