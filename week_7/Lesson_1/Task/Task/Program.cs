using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            ValutaExchanger kass = new ValutaExchanger(CurrencyType.TL);

            kass.AddNewCurencies(CurrencyType.EUR, 5);
            kass.AddNewCurencies(CurrencyType.USD, 2);

            kass.CurenciesShowInfo();

            //My.NoteOutput($"Cost : {kass.Exchange(CurrencyType.EUR, 25,CurrencyType.AZN)}");
            //My.NoteOutput($"Cost : {kass.Exchange(CurrencyType.EUR, 25, CurrencyType.USD)}");


        }
    }

    public enum CurrencyType
    {
        USD, EUR,TL,AZN
    }

    public enum PaymentTypes
    {
        Card,Cash
    }






}
