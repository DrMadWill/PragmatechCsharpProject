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
            int price;
            int count;
            string name;
            bool is_continue_last;
            bool is_continue_create_m;
            do
            {
                for (int i = 0; i < 2; i++)
                {
                    do
                    {
                        Console.WriteLine(" >>>>> Medicine Create <<<<<");
                        Console.WriteLine(" <<<<<<<<<< Input Medicine Name ");
                        name = My.ConsInputString();
                        Console.WriteLine(" <<<<<<<<<< Input Medicine Price ");
                        price = My.ConsInputInt();
                        Console.WriteLine(" <<<<<<<<<< Input Medicine Count ");
                        count = My.ConsInputInt();
                        try
                        {
                            Medicine medicine = new Medicine(name, price, count);
                            tarkim.AddMedicine(medicine);
                            is_continue_create_m = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Can't create medicine! Plase input agen .");
                            is_continue_create_m = false;
                            
                        }

                    } while (is_continue_create_m);
                    
                    
                }
                is_continue_last = My.IsContinueLoop();

            } while (is_continue_last);
            

             

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

            //medicine4.ShowInfo();
            //tarkim.Sell("nemroot", 10);
            //medicine4.ShowInfo();
            //Console.WriteLine(medicine4.Name + " Total Came >> "+medicine4.TotalIncome);


            //medicine3.ShowInfo();
            //tarkim.Sell("Pririnos-4", 10);
            //medicine3.ShowInfo();
            //Console.WriteLine(medicine3.Name +" Total Came >> " + medicine3.TotalIncome);
            //Console.WriteLine("Common Totalincame : " + tarkim.TotalCome);

            //medicine4.ShowInfo();
            //tarkim.Sell("nemroot", 2);
            //medicine4.ShowInfo();
            //Console.WriteLine(medicine4.Name + " Total Came >> " + medicine4.TotalIncome);

            //Console.WriteLine("Common Totalincame : " + tarkim.TotalCome);

        }
    }
}
