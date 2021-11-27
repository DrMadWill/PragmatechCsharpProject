using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");

            

            

            My.NoteHead("Excanger");
            CurrencyType curs = SelectCurrency();
            ValutaExchanger kass = new ValutaExchanger(curs);
            kass.AddNewCurencies(CurrencyType.EUR, 5);
            kass.AddNewCurencies(CurrencyType.USD, 2);

            kass.CurenciesShowInfo();

            //My.NoteOutput($"Cost : {kass.Exchange(CurrencyType.EUR, 25,CurrencyType.AZN)}");
            //My.NoteOutput($"Cost : {kass.Exchange(CurrencyType.EUR, 25, CurrencyType.USD)}");


        }

        public static CurrencyType SelectCurrency()
        {
            My.NoteHead("Valutalar");
            My.NoteOutput("1 : USD");
            My.NoteOutput("2 : EUR");
            My.NoteOutput("3 : TL");
            My.NoteOutput("4 : AZN");
            My.NoteInput("Base Currency");
            byte currency_number= My.ConsInputByte();
            var currency = currency_number switch
            {
                1 => CurrencyType.USD,
                2 => CurrencyType.EUR,
                3 => CurrencyType.TL,
                _ => CurrencyType.AZN,
            };

            //switch (currency_number)
            //{
            //    case 1:
            //        currency = CurrencyType.USD;
            //        break;
            //    case 2:
            //        currency = CurrencyType.EUR;
            //        break;
            //    case 3:
            //        currency = CurrencyType.TL;
            //        break;
            //    default:
            //        currency = CurrencyType.AZN;
            //        break;
            //}

            return currency;
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
