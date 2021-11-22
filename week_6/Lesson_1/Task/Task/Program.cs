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
            string newname;
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
                            tarkim.AddMedicine(medicine);
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
            IsShowList(tarkim);


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
                        tarkim.UpdateMedicine(name, newname, price, count);
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
                tarkim.ShowInfoList();

            } while (is_continue_last);
            IsShowList(tarkim);

            do
            {
                do
                {
                    My.NoteHead("Medicine Remove");
                    My.NoteInput("Input Update Medicine Name");
                    name = My.ConsInputString();

                    try
                    {
                        tarkim.RemoveMedicine(name);
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
                tarkim.ShowInfoList();

            } while (is_continue_last);
            IsShowList(tarkim);
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
    }
}
