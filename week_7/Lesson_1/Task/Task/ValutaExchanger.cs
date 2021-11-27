using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class ValutaExchanger
    {
        private readonly Dictionary<CurrencyType, double> _urencies;
        public Dictionary<CurrencyType, double> Curencies { get { return _urencies; } }

        public CurrencyType Currency;



        public ValutaExchanger(CurrencyType currency)
        {
            this._urencies = new Dictionary<CurrencyType, double>();
            this.Currency = currency;
        }

        private double GetFindValuta(CurrencyType currency)
        {
            double azn_cost = 0D;
            foreach (var item in this.Curencies.Keys)
            {
                if (item == currency)
                {
                    azn_cost = this.Curencies[item];
                    break;
                }
            }
            return azn_cost;
        }

        public double Exchange(CurrencyType currency, double cost, CurrencyType change_currency)
        {
            double resault;
            double total;
            if (currency != this.Currency)
            {
                if (change_currency == this.Currency)
                {
                    resault = GetFindValuta(currency) * cost;
                }
                else
                {
                    total= GetFindValuta(currency) * cost;
                    resault =(1/GetFindValuta(change_currency)) * total;
                }

            }
            else
            {
                if (change_currency != this.Currency)
                {
                    resault = (1 / GetFindValuta(change_currency)) * cost;
                }
                else
                {
                    resault = cost;
                }
                
            }

            return resault;
        }

        public void AddNewCurencies(CurrencyType currency, double Currency_cost)
        {
            this._urencies.Add(currency, Currency_cost);
        }

        public void CurenciesShowInfo()
        {
            foreach (var item in this.Curencies)
            {
                My.NoteOutput($" Currency : {item.Key} / {this.Currency} Cost : {item.Value}");
            }
        }

    }
}
