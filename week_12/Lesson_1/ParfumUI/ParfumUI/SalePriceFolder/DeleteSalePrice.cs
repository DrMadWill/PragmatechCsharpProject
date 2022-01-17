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
    public partial class DeleteSalePrice : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public DeleteSalePrice()
        {
            InitializeComponent();
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                LoadParfumItems.LoadSalePrice(sqlConnection, true, comb, Id);
            }

        }

        private void DeleteSalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int saleId = ((SqlModel.SalePriceData)comb.SelectedItem).Id;
                string commad = "Delete SalePrice where Id ="+saleId;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                        LoadParfumItems.LoadSalePrice(sqlConnection, false, comb, Id);
                        RefresData.allUI.ChangeData();
                    }
                }
            }
        }
    }
}
