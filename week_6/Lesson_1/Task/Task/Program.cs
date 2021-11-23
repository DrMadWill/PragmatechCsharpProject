using System;
using System.Collections.Generic;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>>> Hello My World! <<<<<<<<<<<<<<<<<<<");

            Medicine medicine1 = new Medicine("Fosetrin", 30, 12);
            Medicine medicine2 = new Medicine("Kmietrin", 21, 30);
            Medicine medicine3 = new Medicine("Pririnos-4", 21, 12);
            Medicine medicine4 = new Medicine("NemRoot", 36, 12);
            Medicine medicine5 = new Medicine("BomZi", 40, 10);
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.AddMedicine(medicine1);
            pharmacy.AddMedicine(medicine2);
            pharmacy.AddMedicine(medicine3);
            pharmacy.AddMedicine(medicine4);
            pharmacy.AddMedicine(medicine5);
            List<string> operation = new List<string>();
            operation.Add("Create Medicine => cm");
            operation.Add("Remove Medicine => rm");
            operation.Add("Update Medicine => um");
            operation.Add("Show Medicine List=> swm");//
            operation.Add("Sell Medicine => slm");
            operation.Add("Find Medicine => fm");
            operation.Add("Show Common Totalincome => sctm");

            string operaton;
            bool is_conitue;
            do
            {
                My.NoteHead("Opertions");
                foreach (var item in operation)
                {
                    My.NoteOutput(item);
                }

                My.NoteHead("Choose your operation?");
                operaton = My.ConsInputString();
                switch (operaton)
                {
                    case "cm":
                        CreateMedicine(pharmacy);
                        break;
                    case "rm":
                        RemoveMedicine(pharmacy);
                        break;
                    case "um":
                        UpdateMedicine(pharmacy);
                        break;
                    case "swm":
                        pharmacy.ShowInfoList();
                        break;
                    case "slm":
                        Sell(pharmacy);
                        break;
                    case "fm":
                        Find(pharmacy);
                        break;
                    case "sctm":
                        My.NoteHead("Common Totalincome Medicine");
                        My.NoteOutput(pharmacy.TotalCome.ToString());
                        break;
                    default:
                        My.NoteOutput("Don't have this operation!");
                        break;
                }
                My.NoteHead("Want to do another operation?");
                is_conitue = !My.IsContinueLoop();

            } while (is_conitue);

        }
        public static void CommonTotalincome(Pharmacy pharmacy)
        {
            My.NoteHead("Common Totalincome Medicine");
            
            
        }
        public static void RemoveMedicine(Pharmacy pharmacy)
        {
            string name;
            bool is_continue_last;
            bool is_continue_2;
            do
            {
                do
                {
                    My.NoteHead("Medicine Remove");
                    My.NoteInput("Input Update Medicine Name");
                    name = My.ConsInputString();

                    try
                    {
                        pharmacy.RemoveMedicine(name);
                        is_continue_2 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        My.NoteOutput("Can't remove medicine! Plase input agen.");
                        is_continue_2 = true;
                    }

                } while (is_continue_2);
                My.NoteOutput("You remove updated!");
                My.NoteOutput("Do you remove update medicine ?");
                is_continue_last = !My.IsContinueLoop();

            } while (is_continue_last);
            IsShowList(pharmacy);
        }

        public static void UpdateMedicine(Pharmacy pharmacy)
        {
            int price;
            int count;
            string name;
            string newname;
            bool is_continue_last;
            bool is_continue_2;
            do
            {
                do
                {
                    My.NoteHead("Medicine Update");
                    My.NoteInput("Input Update Medicine Name");
                    name = My.ConsInputString();
                    My.NoteInput("Input New Medicine Name");
                    newname = My.ConsInputString();
                    My.NoteInput("Input New Medicine Name");
                    price = My.ConsInputInt();
                    My.NoteInput("Input New Medicine Count");
                    count = My.ConsInputInt();
                    try
                    {
                        pharmacy.UpdateMedicine(name, newname, price, count);
                        is_continue_2 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        My.NoteOutput("Can't update medicine! Plase input agen.");
                        is_continue_2 = true;
                    }

                } while (is_continue_2);
                My.NoteOutput("You medicine updated!");
                My.NoteOutput("Do you continue update medicine ?");
                is_continue_last = !My.IsContinueLoop();
                pharmacy.ShowInfoList();

            } while (is_continue_last);
            IsShowList(pharmacy);
        }
        
        public static void CreateMedicine(Pharmacy pharmacy)
        {
            int price;
            int count;
            string name;
            bool is_continue_last;
            bool is_continue_2;
            do
            {
                for (int i = 0; i < 1; i++)
                {
                    do
                    {
                        My.NoteHead("Medicine Create");
                        My.NoteInput("Input Medicine Name");
                        name = My.ConsInputString();
                        My.NoteInput("Input Medicine Price");
                        price = My.ConsInputInt();
                        My.NoteInput("Input Medicine Count");
                        count = My.ConsInputInt();
                        try
                        {
                            Medicine medicine = new Medicine(name, price, count);
                            pharmacy.AddMedicine(medicine);
                            is_continue_2 = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            My.NoteOutput("Can't create medicine! Plase input agen.");
                            is_continue_2 = true;

                        }

                    } while (is_continue_2);

                    My.NoteOutput("You medicine created!");
                }
                My.NoteOutput("Do you continue create medicine ?");
                is_continue_last = !My.IsContinueLoop();

            } while (is_continue_last);
            IsShowList(pharmacy);
        }

        public static void IsShowList(Pharmacy pharmacy)
        {
            bool is_continue;
            My.NoteOutput("Do you show list ?");
            is_continue = !My.IsContinueLoop();
            if (is_continue)
            {
                pharmacy.ShowInfoList();
            }
        }

        public static void Sell(Pharmacy pharmacy)
        {

            string name;
            int count;
            bool is_continue_last;
            bool is_continue_2;

            do
            {
                do
                {
                    My.NoteHead("Sell Medicine");
                    My.NoteInput("Input Medicine Name");
                    name = My.ConsInputString();
                    My.NoteInput("Input Medicine Count");
                    count = My.ConsInputInt();

                    try
                    {
                        pharmacy.Sell(name, count);
                        is_continue_2 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        My.NoteOutput("Can't sell medicine! Plase input agen.");
                        is_continue_2 = true;
                    }

                } while (is_continue_2);
                My.NoteOutput("You selled the medicine!");
                pharmacy.FindMedicineByName(name).ShowInfo();
                My.NoteOutput("Do you sell medicine ?");
                is_continue_last = !My.IsContinueLoop();

            } while (is_continue_last);



        }

        public static void Find(Pharmacy pharmacy)
        {
            string name;
            bool is_continue_last;
            bool is_continue_2;
            do
            {
                do
                {
                    My.NoteHead("Medicine Find");
                    My.NoteInput("Input Update Medicine Name");
                    name = My.ConsInputString();

                    try
                    {
                        pharmacy.FindMedicineByName(name);
                        is_continue_2 = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        My.NoteOutput("Can't find medicine! Plase input agen.");
                        is_continue_2 = true;
                    }
                } while (is_continue_2);
                pharmacy.FindMedicineByName(name).ShowInfo();

                My.NoteOutput("Do you find medicine ?");
                is_continue_last = !My.IsContinueLoop();

            } while (is_continue_last);
        }
    }
}
