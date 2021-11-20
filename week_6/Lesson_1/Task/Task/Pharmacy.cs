using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Pharmacy
    {
        private readonly List<Medicine> _medicines;
        public List<Medicine> Medicines { get { return _medicines; } }

        public Pharmacy()
        {
            this._medicines = new List<Medicine>();
        }

        public void RemoveMedicine(string name)
        {
            string lowercase = name.Trim().ToLower();
            Medicine removemedicine = this._medicines.Find(f => f.Name.Trim().ToLower() == lowercase);
            if (removemedicine != null)
            {
                this._medicines.Remove(removemedicine);
            }
            else
            {
                throw new UnCatchNameException(" Not Foun This Medicine");
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
            Console.WriteLine(">>>>>>>>>>> Medicines List <<<<<<<<<<<");
            foreach (var item in this.Medicines)
            {
                listnumber += 1;
                
                Console.WriteLine($" >>> {listnumber}. Name : {item.Name} / Price : {item.Price} / Count : {item.Count} ");
            }
        }

    }
}
