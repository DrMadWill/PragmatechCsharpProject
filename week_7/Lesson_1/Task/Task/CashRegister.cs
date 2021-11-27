using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class CashRegister
    {
        private  double _TotalAmount ;
        public double TotalAmount { get { return this._TotalAmount; } }

        public ValutaExchanger Changer;

        public CurrencyType Currency;
        public PaymentTypes PaymentType;

        private long _TotalSalesCount=0;
        public long TotalSalesCount { get { return this._TotalSalesCount; } }

        public CashRegister(double totalamout, CurrencyType currency)
        {
            //menfi erroru
            this._TotalAmount = totalamout;
            this.Currency = currency;


        }

        public void AddSale(CurrencyType currency, double cost)
        {

            double total;
            if (currency != this.Currency)
            {
                this.Changer = new ValutaExchanger(currency);
                total=this.Changer.Exchange(currency, cost, this.Currency);
            }
            else
            {
                this._TotalSalesCount = this._TotalSalesCount + 1;
                this._TotalAmount = this.TotalAmount + cost;
            }
            
        }
        public void RemoveSale()
        {
            
        }

    }
}
