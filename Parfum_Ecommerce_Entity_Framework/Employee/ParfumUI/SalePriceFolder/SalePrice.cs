using ParfumUI.Common;
using ParfumUI.Load;
using ParfumUI.SalePriceFolder.Volume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParfumUI
{
    public partial class SalePrice : Form
    {

        DataTable dataTable = new DataTable();
        int PriceId =0;
        int PafumSize = 0;
        public SalePrice()
        {
            InitializeComponent();
        }


        private void SalePrice_Load(object sender, EventArgs e)
        {
            // Size and Shearch Name Load
            LoadCommonData.LoadSearchName(combSearchName);
            LoadCommonData.LoadSize(combSize);
        }

        //Save 
        private void button1_Click(object sender, EventArgs e)
        {

            
            if (ParfumMessenge.IsAreYouSure($"Are Sure Add Price ?"))
            {
                int size;
                int price;
                int number; 
                try
                {
                    size = Convert.ToInt32(combSize.SelectedItem.ToString().Trim());
                    price = Convert.ToInt32(textPrice.Text.Trim());
                    number = Convert.ToInt32(textNumber.Text.Trim());
                }
                catch 
                {

                    ParfumMessenge.Error("You Must Be Write Number");
                    return;
                }

                int parfumId = ((ParfumHeader)combSearchName.SelectedItem).Id;
                // Parfum to Sale Pirce
                if (!IsAdd(size, parfumId))
                {
                    return;
                }

                var sizeId = LoadCommonData._db.Sizes.FirstOrDefault(dr => dr.Size1 == size).Id;
                DataModelMsSql.SalePrice AddsalePrice = new DataModelMsSql.SalePrice()
                {
                    ParfumId = parfumId,
                    SizeId = sizeId,
                    Price = price,
                    number = number
                };

                LoadCommonData._db.SalePrices.Add(AddsalePrice);
                LoadCommonData._db.SaveChanges();
                ChangeInfo();
                ClearInfo();

                // Refres datagridwiev
                RefresData.salePriceLists.ChangeData();
                ParfumMessenge.Warning($" Price Created");
            }
        }


        public void ChangeSize()
        {
            LoadCommonData.LoadSize(combSize);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            VolumeAdd volumeAdd = new VolumeAdd();
            volumeAdd.ShowDialog();
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeInfo();
            ClearInfo();
        }

        private void ChangeInfo()
        {
            
            dataGridView1.Rows.Clear();
            // Data Grid View Price List
            int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
            var salePriceList = LoadCommonData._db.SalePrices
                .Where(dr => dr.ParfumId == Id)
                .Select(fd=>new { 
                    fd.Size.Size1,
                    fd.Price,
                    fd.number,
                    fd.Id
                })
                .ToList();

            foreach (var item in salePriceList)
            {
                dataGridView1.Rows.Add(item.Size1, item.Price, item.number, item.Id);
            }
        }

        private bool IsAdd(int size,int id)
        {
            bool isAdd = true;
            var isAddedPrice = LoadCommonData._db.SalePrices.FirstOrDefault(dr => dr.ParfumId == id && dr.Size.Size1==size);
            if(isAddedPrice != null)
            {
                ParfumMessenge.Error("This Price Already Added");
                isAdd = false;
            }
            return isAdd;
        }

        
        // Data Grid View Price List
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Size Ml Problem
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                int SizeML = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["SizeML"].Value.ToString());
                string Price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string Count = dataGridView1.Rows[e.RowIndex].Cells["PCount"].Value.ToString();

                PriceId = id;
                PafumSize = SizeML;
                combSize.SelectedItem = SizeML;
                textPrice.Text = Price;
                textNumber.Text = Count;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure(" Are You Sure Update?"))
            {
                if (PriceId == 0)
                {
                    ParfumMessenge.Warning("Pleac select price");
                    return;
                }
                int price;
                int count;
                try
                {
                    price = int.Parse(textPrice.Text.Trim());
                    count = int.Parse(textNumber.Text.Trim());
                }
                catch 
                {
                    ParfumMessenge.Error("You Must be Write Number ");
                    return;
                }
                
                int ParfumId = ((ParfumHeader)combSearchName.SelectedItem).Id;
                int newsize = int.Parse(combSize.SelectedItem.ToString().Trim());

                var isAddedPrice = LoadCommonData._db.SalePrices.FirstOrDefault(dr=>dr.ParfumId == ParfumId && dr.Size.Size1 == newsize);
                if (isAddedPrice!=null)
                {
                    if(PafumSize != newsize)
                    {
                        ParfumMessenge.Error("This Price Already Added");
                        return;
                    }
                }

                int sizeId = LoadCommonData._db.Sizes.FirstOrDefault(dr => dr.Size1 == newsize).Id;
                var updateParfumPrice = LoadCommonData._db.SalePrices.Find(PriceId);
                if(updateParfumPrice != null)
                {
                    updateParfumPrice.SizeId = sizeId;
                    updateParfumPrice.Price = price;
                    updateParfumPrice.number = count;

                    LoadCommonData._db.SaveChanges();
                }

                ChangeInfo();
                // SalePriceList Refres 
                RefresData.salePriceLists.ChangeData();

                ParfumMessenge.Warning("Parfum Price Update");
                ClearInfo();
            }

        }


        private void ClearInfo()
        {
            textNumber.Text = "";
            textPrice.Text = "";
            try
            {
                combSize.SelectedIndex = 0;
            }
            catch 
            {
            }
           
            PriceId = 0;
            PafumSize = 0;
        }
    }
}
