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
        private Dictionary<string, int> ParfumNameToID;
        private Dictionary<string, int> SalePriceId;
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public DeleteSalePrice()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
            SalePriceId = new Dictionary<string, int>();
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString().Trim()];
                LoadParfumItems.LoadSalePrice(sqlConnection, true, comb, Id, SalePriceId);
            }

        }

        private void DeleteSalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName, ParfumNameToID);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int saleId = SalePriceId[comb.SelectedItem.ToString().Trim()];
                string commad = "Delete SalePrice where Id ="+saleId;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(commad, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Information deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        int Id = ParfumNameToID[combSearchName.SelectedItem.ToString().Trim()];
                        LoadParfumItems.LoadSalePrice(sqlConnection, false, comb, Id, SalePriceId);
                        RefresData.allUI.ChangeData();
                    }
                }
            }
        }
    }
}
