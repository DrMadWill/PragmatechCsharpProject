using System;
using System.Collections.Generic;
using System.ComponentModel;
using ParfumUI.Parfum.Load;
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

namespace ParfumUI.SalePriceFolder
{

    public partial class UpdateSalePrice : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public UpdateSalePrice()
        {
            InitializeComponent();
        }

        private void UpdateSalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);

                LoadParfumItems.LoadSize(sqlConnection, false, combSize);
                SelectedChange();
            }
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;

                LoadParfumItems.LoadSalePrice(sqlConnection, true, comb, Id);
            }

        }

        private void SelectedChange()
        {
            
            string size = comb.SelectedItem.ToString().Trim().Split('M')[0];
            string price = comb.SelectedItem.ToString().Split(' ')[1].Split('A')[0];
            string count = comb.SelectedItem.ToString().Split(' ')[2];

            combSize.SelectedItem = size;
            textPrice.Text = price;
            textNumber.Text = count;
        }

        private void comb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedChange();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
            int size = int.Parse(comb.SelectedItem.ToString().Split(' ')[1].Split('A')[0]);
            string newsize = combSize.SelectedItem.ToString().Trim();
            string price = textNumber.Text.Trim();
            string count = textNumber.Text.Trim();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                DataTable dataTable = LoadParfumItems.LoadSalePriceDataTable(sqlConnection, true, Id);
                foreach (DataRow row in dataTable.Rows)
                {
                    if(row["Size ML"].ToString().Trim() == newsize)
                    {
                        MessageBox.Show("Got this Size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string commad = $"UPDATE SalePrice set SizeId=(select Id from Size where Size={newsize}),Price={price},number={count} where ParfumId = {Id} and SizeId=(select Id from Size where Size={size}) ";
                using (SqlCommand sqlCommand =new SqlCommand(commad, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Information update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadParfumItems.LoadSalePrice(sqlConnection, false, comb, Id);
                }
            }

          

        }

        
    }
}
