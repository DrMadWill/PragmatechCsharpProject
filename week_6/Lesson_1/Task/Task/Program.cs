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
            medicine2.ShowInfo();
            Pharmacy tarkim = new Pharmacy();
            tarkim.AddMedicine(medicine1);
            tarkim.AddMedicine(medicine2);
            tarkim.AddMedicine(medicine3);

            //tarkim.ShowInfoList();//added
            //Medicine medicine2 = new Medicine("Fosetrin", 21, 12);//
            //medicine2.ShowInfo();
            //tarkim.AddMedicine(medicine2);//IsAlreadyAddedException
            tarkim.ShowInfoList();
            tarkim.RemoveMedicine("Kmietrin");
            tarkim.ShowInfoList();
            tarkim.UpdateMedicine("fosetrin", "BoraPilus", 32, 35);
            //tarkim.UpdateMedicine("fat", "vad", 32, 35);//Not Found


            tarkim.ShowInfoList();
        }
    }
}
