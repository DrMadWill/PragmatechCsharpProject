using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator hesabgor = new Calculator();
            Console.WriteLine(hesabgor.Divide(8,2,2));

        }
    }
    
    interface ISum
    {
        double Sum(params double[] numbers);
    }

    interface IMultiply
    {
        double Multiply(params double[] numbers);
    }

    interface IDifference
    {
        double Difference(params double[] numbers);
    }

    interface IDivide
    {
        double Divide(double divide, params double[] numbers);
    }

    class Calculator : ISum, IMultiply, IDifference, IDivide
    {
        public double Difference(params double[] numbers)
        {
            double difference = 0;

            foreach (var item in numbers)
            {
                difference -= item;
            }

            return difference;
        }

        public double Divide(double divide, params double[] numbers)
        {
            double divides = divide;

            foreach (var item in numbers)
            {
                divides /= item;
            }

            return divides;
        }

        public double Multiply(params double[] numbers)
        {
            double multiply = 0;

            foreach (var item in numbers)
            {
                multiply *= item;
            }

            return multiply;
        }

        public double Sum(params double[] numbers)
        {
            double total = 0;
            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
        }
    }

}
