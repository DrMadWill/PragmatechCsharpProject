using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class Medicine
    {
        private string _name;
        public string Name { get { return _name; } }

        private int _price;
        public int Price { get { return _price; } }

        private int _count;
        public int Count { get { return _count; } }

        public Medicine(string name,int price,int count)
        {
            this.Update(name, price, count);
        }

        public void ShowInfo()
        {
            Console.WriteLine(">>>>>>>> Medicine Info <<<<<<<<<");
            Console.WriteLine($" >> Name : {this.Name} / Price : {this.Price} / Count : {this.Count}");
        }

        public void Update(string name,int price,int count)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new UnCatchNameException("Name is Null or Empty");
            }
            else
            {
                this._name = name;
            }

            if (0 >= price)
            {
                throw new IsNotZeroPriceException("You Use UnCorrect Price ");
            }
            else
            {
                this._price = price;
            }

            if (0 >= count)
            {
                throw new IsNotZeroCountException("You Use UnCorrect Count");
            }
            else
            {
                this._count = count;
            }
        }
    }
}
