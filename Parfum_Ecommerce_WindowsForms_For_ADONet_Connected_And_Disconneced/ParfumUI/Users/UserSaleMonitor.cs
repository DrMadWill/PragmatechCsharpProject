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
    public partial class UserSaleMonitor : Form
    {
        public UserSaleMonitor()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();


        DataTable dataTableShearch = new DataTable();

        private void UserSaleMonitor_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                string command = "select Name from Catogory";
                LoadParfumItems.LoadItem(sqlConnection, command, true, combCatogory);

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


                string commands = "select * from SaleDetailParfum where PriceId=1";
                table = LoadParfumItems.DataBeseRead(sqlConnection, commands, false);


            }
            combUser.SelectedIndex = 0;
            combUser.DropDownStyle = ComboBoxStyle.DropDownList;
            combCatogory.SelectedIndex = 0;

            ChangeData();

        }

        public void ChangeData()
        {

            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                dataGridViewShearch.DataSource = null;
                
                string command = "select * from SaleDetailParfum";

                dataTableShearch = LoadParfumItems.DataBeseRead(sqlConnection, command, true);
                dataGridViewShearch.DataSource = dataTableShearch;
                textcatogory.Text = "All Parfums";

            }
        }


        public void ChangeCatogory()
        {

            string catogory = combCatogory.SelectedItem.ToString().Trim();

            
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                dataGridViewShearch.DataSource = null;

                
                // Databses Info add
                string command = "EXECUTE usp_SaleShowCategoryParfums '" + catogory + "'";
                dataTableShearch= LoadParfumItems.DataBeseRead(sqlConnection, command, true);
               
                dataGridViewShearch.DataSource = dataTableShearch;
                textcatogory.Text = catogory;
            }
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
            if (LoadParfumItems.IsAreYouSure())
            {
                string PriceId = "";
                string command = "";

                string UserName = combUser.SelectedItem.ToString().Trim().Split('-')[0];
                string time = dateTimeSale.Value.ToString("yyyy-MM-dd");
                int count = 0;
                int basecount = 0;
                int price = 0;
                bool isfrist = true;
                int total = 0;
                string parfumname = "";
                int datacount = dataGridViewSales.Rows.Count;

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                IsEmptyDataGrid:;
                    // Foreach Last Elemet Prablem
                    foreach (DataGridViewRow row in dataGridViewSales.Rows)
                    {
                        PriceId = row.Cells["PriceId"].Value.ToString().Trim();
                        try
                        {
                            count = int.Parse(row.Cells["SaleCount"].Value.ToString().Trim());

                        }
                        catch (Exception err)
                        {
                            LoadParfumItems.MessengeWarning("PLease Count Add.");
                            return;
                        }
                        basecount = int.Parse(row.Cells["BaseCount"].Value.ToString().Trim());
                        price = int.Parse(row.Cells["ParfumPrice"].Value.ToString().Trim());
                        parfumname = row.Cells["ParfumN"].Value.ToString().Trim();
                        total = count * price;
                        if (count > basecount)
                        {
                            LoadParfumItems.MessengeWarning("There is not so much perfume.");
                            return;
                        }

                        if (count == 0 )
                        {
                            LoadParfumItems.MessengeWarning("PLease Count Add.");
                            return;
                        }
                        command = $"EXECUTE usp_InsertSaleAdmin @Name='{UserName}',@SalePrice={PriceId},@Count={count},@Total={total},@Date='{time}'";
                        if (isfrist)
                        {
                            LoadParfumItems.DataBases(sqlConnection, command, true);
                            isfrist = false;
                        }
                        else
                            LoadParfumItems.DataBases(sqlConnection, command, false);

                        LoadParfumItems.MessengeWarning($": Parfum {parfumname} Saled ");
                        dataGridViewSales.Rows.Remove(row);
                        ChangeData();
                    }

                    if (dataGridViewSales.Rows.Count > 0)
                        goto IsEmptyDataGrid;
                }

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
            string loadnames = "";
            table.Rows.Clear();
            List<int> indexs = new List<int>();
            foreach (DataRow row in dataTableShearch.Rows)
            {
                loadnames = row["Name"].ToString().Trim().ToLower();
                if (loadnames.Contains(shrearchname))
                {
                    table.Rows.Add(row.ItemArray);

                }
            }

            dataGridViewShearch.DataSource = table;
        }
    }
}
