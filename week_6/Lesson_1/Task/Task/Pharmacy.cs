using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Pharmacy:IPharmacy
    {
        private readonly List<Medicine> _medicines;
        public List<Medicine> Medicines { get { return _medicines; } }

        private int _totalcome;
        public int TotalCome { get { return _totalcome; } }
        public Pharmacy()
        {
            this._medicines = new List<Medicine>();
        }

        public void Sell(string name,int count)
        {
            Medicine sellmedicine = this.FindMedicineByName(name);
            sellmedicine.Sell(count);
            this._totalcome = this.TotalCome + sellmedicine.Price * count;
        }
        public Medicine FindMedicineByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new UnCatchNameException("This is Empty");
            }
            string lowercase = name.Trim().ToLower();
            Medicine findmedicine = this._medicines.Find(f => f.Name.Trim().ToLower().Equals(name.ToLower().Trim()));
            if (findmedicine == null)
            {
                throw new UnCatchNameException("Not Found This Medicine");
            }

            return findmedicine;

        }
        public void UpdateMedicine(string name, string newneme, int newprice, int newcount)
        {
            
            if (string.IsNullOrEmpty(name))
            {
                throw new UnCatchNameException("This is Empty");
            }
            string lowercase = name.ToLower().Trim();
            Medicine updatemedicines = this.Medicines.Find(f => f.Name.Trim().ToLower().Equals(name.ToLower().Trim()));
            if (updatemedicines == null)
            {
                throw new UnCatchNameException("Not Found This Medicine");
            }
            else
            {
                

                if (string.IsNullOrEmpty(newneme))
                {
                    newneme = updatemedicines.Name;
                }

                if (newprice == 0)
                {
                    newprice = updatemedicines.Price;
                }

                if (newcount == 0)
                {
                    newcount = updatemedicines.Count;
                }

                updatemedicines.Update(newneme, newprice, newcount);
            }
        }
        public void RemoveMedicine(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new UnCatchNameException("This is Empty");
            }
            string lowercase = name.Trim().ToLower();
            Medicine removemedicine = this._medicines.Find(f => f.Name.Trim().ToLower() == lowercase);
            if (removemedicine != null)
            {
                this._medicines.Remove(removemedicine);
            }
            else
            {
                throw new UnCatchNameException(" Not Found This Medicine");
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            string lowercase = medicine.Name.Trim().ToLower();
            Medicine newmedicine = this._medicines.Find(f => f.Name.Trim().ToLower().Equals(medicine.Name.ToLower().Trim()));
            if (newmedicine == null)
            {
                this._medicines.Add(medicine);
            }
            else
            {
                throw new IsAlreadyAddedException("This Medicine Already Added");
            }

        }

        public void ShowInfoList()
        {
            int listnumber = 0;
            My.NoteHead("Medicines List");
            foreach (var item in this.Medicines)
            {
                listnumber += 1;                
                Console.WriteLine($" >>> {listnumber}. Name : {item.Name} / Price : {item.Price} / Count : {item.Count} / TotalIncome : {item.TotalIncome} ");
            }
        }

    }

}
