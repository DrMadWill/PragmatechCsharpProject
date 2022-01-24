using ParfumUI.Parfum.Load;
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
    public partial class UserActivityMonitor : Form
    {
        public UserActivityMonitor()
        {
            InitializeComponent();
        }

        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                dataGridShearch.DataSource = null;

                string command = "select * from SaleActivityMonitor";
                dataGridShearch.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, command, true);

                string commandItem = "select distinct FullName,IsActive from SaleActivitysIsUser";
                using (SqlCommand sqlCommand = new SqlCommand(commandItem, sqlConnection))
                {
                    // Data Clear
                    combUser.Items.Clear();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            
                            if (Convert.ToBoolean(sqlDataReader[1]))
                            {
                                combUser.Items.Add(sqlDataReader[0].ToString().Trim() + "-User");
                            }
                            else
                                combUser.Items.Add(sqlDataReader[0].ToString().Trim() + "-Employee");
                        }
                    }
                }
                combUser.DropDownStyle = ComboBoxStyle.DropDownList;
                combUser.SelectedIndex = 0;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string userName = combUser.SelectedItem.ToString().Trim().Split('-')[0];
            string startTime = dateStartTime.Value.ToString("yyyy-MM-dd");
            string lasttime =  dateLastTime.Value.ToString("yyyy-MM-dd");

            string command = $"select * from SaleActivityMonitor where FullName='{userName}' and [Date] Between '{startTime}' and '{lasttime}' ";
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                dataGridShearch.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, command, true);
        }

        private void dataGridShearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridShearch.SelectedRows.Count > 0)
            {

                string id = dataGridShearch.Rows[e.RowIndex].Cells["SaleId"].Value.ToString();
                string PriceId = dataGridShearch.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                string Name = dataGridShearch.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Brend = dataGridShearch.Rows[e.RowIndex].Cells["Brend"].Value.ToString();
                string Gender = dataGridShearch.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                string Density = dataGridShearch.Rows[e.RowIndex].Cells["Density"].Value.ToString();
                string Size = dataGridShearch.Rows[e.RowIndex].Cells["Size"].Value.ToString();
                string price = dataGridShearch.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string Number = dataGridShearch.Rows[e.RowIndex].Cells["Sale Count"].Value.ToString();
                string total = dataGridShearch.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                string date = dataGridShearch.Rows[e.RowIndex].Cells["Date"].Value.ToString();



                //Distinct
                foreach (DataGridViewRow item in dataGridViewDelete.Rows)
                {

                    if (item.Cells["SaleId"].Value.ToString().Trim() == id)
                    {
                        return;
                    }
                }
                dataGridViewDelete.Rows.Add(id, PriceId, Name, Brend, Gender, Density, Size, price, Number, total,date);


            }
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewDelete.Rows.Clear();
        }

        private void dataGridViewDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDelete.SelectedRows.Count > 0)
            {
                // Remove Dobul click elemet
                dataGridViewDelete.Rows.Remove(dataGridViewDelete.Rows[e.RowIndex]);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string saleid = "";
            string command = "";
            bool isFrist = true;
            string parfum = "";
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
            IsEmptyDataGrid:;
                // Foreach Last Elemet Prablem
                foreach (DataGridViewRow row in dataGridViewDelete.Rows)
                {
                    saleid = row.Cells["SaleId"].Value.ToString().Trim();
                    if (string.IsNullOrEmpty(saleid) )
                    {
                        LoadParfumItems.MessengeWarning("Not Deleted");
                        return;
                    }
                    command = $"delete Sale where Id="+saleid;
                    if (isFrist)
                    {
                        LoadParfumItems.DataBases(sqlConnection, command, true);
                        isFrist = false;
                    }
                    else
                        LoadParfumItems.DataBases(sqlConnection, command, false);

                    
                    dataGridViewDelete.Rows.Remove(row);
                }
                if (dataGridViewDelete.Rows.Count > 0)
                    goto IsEmptyDataGrid;
            }
            RefresData.salePriceLists.ChangeData();
            LoadParfumItems.MessengeWarning($": Parfum Sale Deleted.");

        }
    }
}
