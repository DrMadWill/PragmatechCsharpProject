using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class CashRegister
    {
        private readonly decimal _TotalAmount;
        public decimal TotalAmount { get { return _TotalAmount; } }
        public CashRegister(decimal totalamout)
        {
            //menfi erroru
            this._TotalAmount = totalamout;
        }

        public CurrencyType Currency;

        
    }
}
