using System;
using System.Collections.Generic;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Valyuta dəyərlərini təyin et
        // USD => AZN
        CashRegister.currency_values.Add(CurrencyType.USD, 1.7);
        // ERO => AZN
        CashRegister.currency_values.Add(CurrencyType.EUR, 1.9);
        // TL => USD
        CashRegister.currency_values.Add(CurrencyType.TL, 0.125);

        // TL => USD
        CashRegister.currency_values.Add(CurrencyType.AZN, 1);
        // Cash Currecy
        CashRegister.SelectCashCurrecy();


        Console.WriteLine(" Satiş elemek ucun 1 regemine basin,\n satişi silmek ucun 2 regemine.");
        string option = Console.ReadLine();


        while (option == "1" || option == "2")
        {
            if (option == "1")
            {

                CashInputValue cashInput = new CashInputValue();
                cashInput.SelectValue("Ödəniş ");
                CashRegister.AddSale(cashInput.SelectedAmount, cashInput.SelectedCurrency);

            }
            else if (option == "2")
            {
               
            }
            Console.WriteLine("davam etmek istiyirsiz? \n Satiş elemek ucun 1 regemine basin,\n satişi silmek ucun 2 regemine. \n Eger sistemnen cixmaq istiyirsiz, bawqa regeme basin.");
            option = Console.ReadLine();
        }
        CashRegister.Show();
    }
}

public class CashInputValue
{

    private  CurrencyType selectedCurrency ;
    private double selectedAmount;

    //Protect
    public CurrencyType SelectedCurrency { get { return selectedCurrency; } }
    public double SelectedAmount { get { return selectedAmount; } }

    public  void SelectValue(string operationType)
    {
        Console.WriteLine($"{operationType} valyutasini seçin : ");
        Console.WriteLine(" USD : 1 ");
        Console.WriteLine(" TL :  2 ");
        Console.WriteLine(" ERO : 3 ");
        Console.WriteLine(" AZN : 4 ");

        string currency = Console.ReadLine();

        // Select Currency
        switch (currency)
        {
            case "1":
                selectedCurrency =  CurrencyType.USD;
                break;
            case "2":
                selectedCurrency = CurrencyType.TL;
                break;
            case "3":
                selectedCurrency  = CurrencyType.EUR;
                break;
            case "4":
                selectedCurrency = CurrencyType.AZN;
                break;
            default:
                Console.WriteLine("You Select Wrong Elemet");
                return;
        }

        // Select Amount
        Console.WriteLine($"{operationType} mebleğini seçin: ");
        double mebleq = Convert.ToDouble(Console.ReadLine());
        selectedAmount = mebleq;
    }
}




public static class CashRegister
{
    // ========== Proteced Data ================
    private static double TotalAmount;
    private static int TotalSalesCount = 0;
    private static CurrencyType Currency;

    // ============= Data Base Sale
    private static Dictionary<CurrencyType, double> dict = new Dictionary<CurrencyType, double>();
    // =========== Data Base Currency Value
    public static Dictionary<CurrencyType, double> currency_values = new Dictionary<CurrencyType, double>();

    public static void SelectCashCurrecy()
    {
        bool isSelectCurrecy = true;
        while (isSelectCurrecy)
        {
            Console.WriteLine("Kassanin valutasini secin: ");
            Console.WriteLine(" USD : 1 ");
            Console.WriteLine(" TL :  2 ");
            Console.WriteLine(" ERO : 3 ");
            Console.WriteLine(" AZN : 4 ");
            string cashcurrency = Console.ReadLine();
            switch (cashcurrency)
            {
                case "1":
                    Currency = CurrencyType.USD;
                    isSelectCurrecy = false;
                    break;
                case "2":
                    isSelectCurrecy = false;
                    Currency = CurrencyType.TL;
                    break;
                case "3":
                    isSelectCurrecy = false;
                    Currency = CurrencyType.EUR;
                    break;
                case "4":
                    isSelectCurrecy = false;
                    Currency = CurrencyType.AZN;
                    break;
                default:
                    Console.WriteLine("You Select Wrong Elemet \n  ");
                    break;
            }
        }
        // Select Cash Currency
       
    }


    public static void AddSale(double amount, CurrencyType selectedCurrency)
    {
        if(amount == 0)
        {
            Console.WriteLine("Sale Failede \n ");
            return;
        }
       
        if (!dict.ContainsKey(selectedCurrency))
        {
            dict.Add(selectedCurrency, amount);
            TotalSalesCount++;
        }
        else
        {
            dict[selectedCurrency] += amount;
        }
        Console.WriteLine(" Sale Added ");
    }


    public static void Show()
    {
        Console.WriteLine($"Umumi butun kassalarda yəğıilan mebleğ \n{Currency} valutasinda gosterilecek.");

        double TotalAmountAZN = 0;
        
        foreach (var item in currency_values.Keys)
        {
            if (dict.ContainsKey(item))
                TotalAmountAZN += dict[item] * currency_values[item];
        }

        if (TotalAmountAZN == 0)
            TotalAmount = 0;
        else
        {
            TotalAmount = TotalAmountAZN / currency_values[Currency];
        }


        Console.WriteLine("Umumi kassada :  " + TotalAmount + " " + Currency.ToString() + " var");

        Console.WriteLine("Umumi satiw sayi: " + TotalSalesCount);
    }
}



public enum CurrencyType
{
    USD,
    EUR,
    TL,
    AZN
}