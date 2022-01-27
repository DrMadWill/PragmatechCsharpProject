using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
using ParfumUI.Load;
using ParfumUI.SalePriceFolder;
using ParfumUI.Users;
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
namespace ParfumUI.Users
{
    public partial class UserSaleMonitor : Form
    {
        public UserSaleMonitor()
        {
            InitializeComponent();
        }

        List<SaleDetailParfum> sales = new List<SaleDetailParfum>();

        List<SaleDetailParfum> search_sales = new List<SaleDetailParfum>();

        private void UserSaleMonitor_Load(object sender, EventArgs e)
        {
            LoadCommonData.LoadCategory(combCatogory);
            combCatogory.SelectedIndex = 0;
            combCatogory.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeData();
        }

        public void ChangeData()
        {
            dataGridViewShearch.DataSource = null;
            sales = LoadCommonData._db.SaleDetailParfums.ToList();
            dataGridViewShearch.DataSource = sales;
            textcatogory.Text = "All Parfums";
        }


        public void ChangeCatogory()
        {

            string catogory = combCatogory.SelectedItem.ToString().Trim();
            var ParfumIds = LoadCommonData._db.CategoryToParfums
                .Where(dr => dr.Catogory.Name == catogory)
                .Select(sd=>sd.ParfumId).ToList();
            sales.Clear();
            foreach (var parfumId in ParfumIds)
            {
                var parfums = LoadCommonData._db.SaleDetailParfums.Where(dr => dr.Id == parfumId);
                sales.AddRange(parfums);
            }
            dataGridViewShearch.DataSource = null;
            dataGridViewShearch.DataSource = sales;
            textcatogory.Text = catogory;

        }

        private void combCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCatogory();
        }

        private void btn_allparfums_Click(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void dataGridViewShearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewShearch.SelectedRows.Count > 0)
            {
                string id = dataGridViewShearch.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string PriceId = dataGridViewShearch.Rows[e.RowIndex].Cells["PriceId"].Value.ToString();
                string Name = dataGridViewShearch.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Description = dataGridViewShearch.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                string Brend = dataGridViewShearch.Rows[e.RowIndex].Cells["Brend"].Value.ToString();
                string Gender = dataGridViewShearch.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                string Density = dataGridViewShearch.Rows[e.RowIndex].Cells["Density"].Value.ToString();
                string Size = dataGridViewShearch.Rows[e.RowIndex].Cells["Size"].Value.ToString();
                string price = dataGridViewShearch.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string Number = dataGridViewShearch.Rows[e.RowIndex].Cells["Number"].Value.ToString();

                //Distinct
                foreach (DataGridViewRow item in dataGridViewSales.Rows)
                {
                    if (item.Cells["PriceId"].Value.ToString().Trim() == PriceId)
                    {
                        return;
                    }
                }
                
                dataGridViewSales.Rows.Add(id, PriceId, Name, Description, Brend, Gender, Density, Size,price, Number, "");
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            dataGridViewSales.Rows.Clear();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Are You Sure"))
            {
                

                string UserName = RefresData.salePriceLists.UserName;
                int userId = LoadCommonData._db.Users.FirstOrDefault(dr => dr.FullName.ToLower() == UserName.ToLower()).Id;
            IsEmptyDataGrid:;

                // Foreach Last Elemet Prablem

                foreach (DataGridViewRow row in dataGridViewSales.Rows)
                {
                    int saleCount = 0;
                    DataModelMsSql.SalePrice Price;
                    int PriceIdId = 0;
                    try
                    {
                        PriceIdId = int.Parse(row.Cells["PriceId"].Value.ToString().Trim());
                        saleCount = int.Parse(row.Cells["SaleCount"].Value.ToString().Trim());
                        Price = LoadCommonData._db.SalePrices.Find(PriceIdId);
                        if (Price == null)
                            throw new Exception();
                    }
                    catch 
                    {
                        ParfumMessenge.Warning("PLease Count(Number) Add Or PriceId Don't Change.");
                        return;
                    }
                     
                    if (saleCount > Price.number)
                    {
                        
                        ParfumMessenge.Error("There is not so much perfume.");
                        return;
                    }

                    if (saleCount == 0)
                    {
                        ParfumMessenge.Error("PLease Count Add.");
                        return;
                    }
                    int total = Price.Price * saleCount;
                    Sale sale = new Sale()
                    {
                        SalePriceId = Price.Id,
                        Total = total,
                        Date=DateTime.Now,
                        Count=saleCount,
                        UserId=userId,
                    };

                    LoadCommonData._db.Sales.Add(sale);
                    LoadCommonData._db.SaveChanges();

                    ParfumMessenge.Warning($": Parfum {Price.Parfume.Brend.Name} / {Price.Parfume.Name} Saled. Your Price : {total} ");
                    dataGridViewSales.Rows.Remove(row);
                    ChangeData();
                }

                if (dataGridViewSales.Rows.Count > 0)
                    goto IsEmptyDataGrid;

                RefresData.salePriceLists.ChangeData();
            }

        }

        private void dataGridViewSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                // Remove Dobul click elemet
                dataGridViewSales.Rows.Remove(dataGridViewSales.Rows[e.RowIndex]);
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string shrearchname = textSearchName.Text.Trim().ToLower();
            dataGridViewShearch.DataSource = null;
            if (string.IsNullOrEmpty(shrearchname))
                return;
            search_sales.Clear();
            foreach (var item in sales)
            {
                if (item.Name.ToLower().Trim().Contains(shrearchname.ToLower()))
                    search_sales.Add(item);
            }
            dataGridViewShearch.DataSource = search_sales;
        }

        
    }
}
