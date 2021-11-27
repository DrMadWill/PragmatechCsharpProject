using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class ValutaExchanger
    {
        private readonly Dictionary<CurrencyType, double> _urencies;
        public Dictionary<CurrencyType, double> Curencies { get { return _urencies; } }

        public ValutaExchanger()
        {
            this._urencies = new Dictionary<CurrencyType, double>();
        }

        public double Exchange(CurrencyType currency, double cost)
        {
            double resault;
            double azn_cost = 0D;
            foreach (var item in this.Curencies.Keys)
            {
                if (item == currency)
                {
                    azn_cost = this.Curencies[item];
                }
            }
            resault = azn_cost * cost;

            return resault;
        }

        public void AddNewCurencies(CurrencyType currency, double azn_cost)
        {

            this._urencies.Add(currency, azn_cost);
        }

        public void CurenciesShowInfo()
        {
            foreach (var item in this.Curencies)
            {
                My.NoteOutput($" Currency : {item.Key} / AZN Cost : {item.Value}");
            }
        }

    }
}
