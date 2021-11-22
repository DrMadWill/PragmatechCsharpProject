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

        private int _totalIncome;
        public int TotalIncome { get { return _totalIncome; } }
        public Medicine(string name,int price,int count)
        {
            this.Update(name, price, count);
        }

        public void ShowInfo()
        {
            My.NoteHead("Medicine Info");
            Console.WriteLine($" >> Name : {this.Name} / Price : {this.Price} / Count : {this.Count} / TotalIncome : {this.TotalIncome}");
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

        public void Sell(int count)
        {
            if (count == 0)
            {
                throw new IsNotZeroCountException("You Use UnCorrect Count");
            }
            else if (count > this.Count)
            {
                throw new IsNotZeroCountException("Not Found This Count");
            }
            else
            {
                this._totalIncome = this.TotalIncome + this._price * count;
                this._count = this.Count - count;
            }
        }
    }
}
