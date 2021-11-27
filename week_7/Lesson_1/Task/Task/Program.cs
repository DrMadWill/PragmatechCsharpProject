using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            ValutaExchanger kass = new ValutaExchanger();

            kass.AddNewCurencies(CurrencyType.EUR, 2);

            kass.CurenciesShowInfo();

            My.NoteOutput($"Cost : {kass.Exchange(CurrencyType.EUR, 25)}");

        }
    }

    public enum CurrencyType
    {
        USD, EUR,TL,AZN
    }

    

    

}
