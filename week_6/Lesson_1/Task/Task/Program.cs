using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>>> Hello My World! <<<<<<<<<<<<<<<<<<<");

            Medicine medicine1 = new Medicine("Fosetrin", 30, 12);
            //medicine1.ShowInfo();
            Medicine medicine2 = new Medicine("Kmietrin", 21, 30);
            Medicine medicine3 = new Medicine("Pririnos-4", 21, 12);
            Medicine medicine4 = new Medicine("NemRoot", 36, 12);
            //medicine2.ShowInfo();
            Pharmacy tarkim = new Pharmacy();
            tarkim.AddMedicine(medicine1);
            tarkim.AddMedicine(medicine2);
            tarkim.AddMedicine(medicine3);
            tarkim.AddMedicine(medicine4);

            //tarkim.ShowInfoList();
            //Medicine medicine2 = new Medicine("Fosetrin", 21, 12);//
            //medicine2.ShowInfo();
            //tarkim.AddMedicine(medicine2);//IsAlreadyAddedException

            //tarkim.ShowInfoList();
            //tarkim.RemoveMedicine("Kmietrin");
            //tarkim.ShowInfoList();
            //tarkim.UpdateMedicine("fosetrin", "BoraPilus", 32, 35);
            //tarkim.UpdateMedicine("fat", "vad", 32, 35);//Not Found Exception
            //tarkim.ShowInfoList();

            //Console.WriteLine(" Find >> Name : "+tarkim.FindMedicineByName("borapilus").Name+" / Price : "+ tarkim.FindMedicineByName("borapilus").Price);
            //Console.WriteLine(tarkim.FindMedicineByName("cs"));Not Found Exception

            //medicine4.ShowInfo();
            //medicine4.Sell(12);
            //medicine4.Sell(13);//Not Found
            //medicine4.Sell(0);// Exception
            //medicine4.ShowInfo();
            //Console.WriteLine(medicine4.TotalIncome);

            medicine4.ShowInfo();
            tarkim.Sell("nemroot", 13);
            medicine4.ShowInfo();
            Console.WriteLine(" Total Came >> "+medicine4.TotalIncome);



        }
    }
}
