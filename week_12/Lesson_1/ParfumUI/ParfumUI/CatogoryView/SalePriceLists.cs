using ParfumUI.SalePriceFolder;
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


namespace ParfumUI.CatogoryView
{
    public partial class SalePriceLists : Form
    {
        DataTable dataTable = new DataTable();

        DataTable dataTableShearch = new DataTable();
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public SalePriceLists()
        {
            InitializeComponent();
        }

        private void SalePriceLists_Load(object sender, EventArgs e)
        {
            LoadCatogory();

            ChangeData();
        }


        public void ChangeData()
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                dataGridView1.DataSource = null;
                dataGridShearch.DataSource = null;
                dataTable.Rows.Clear();
                dataTableShearch.Rows.Clear();

                string command = "select * from FullDetailParfum";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Fill(dataTableShearch);
                dataGridView1.DataSource = dataTable;
                textcatogory.Text = "All Parfums";
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

            dataGridShearch.DataSource =null;
            dataTableShearch.Rows.Clear();
            string name = textSearchName.Text.Trim();
            List<string> lis = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {

                if ( row["Name"].ToString().Trim().Contains(name) )
                {
                    foreach (DataColumn dataColumn in dataTable.Columns)
                    {
                        lis.Add(row[dataColumn].ToString());
                    }
                    //Table add
                    dataTableShearch.Rows.Add(lis[0], lis[1], lis[2], lis[3], lis[4], lis[5], lis[6], lis[7], lis[8], lis[9]);
                    lis.Clear();
                }

            }
            dataGridShearch.DataSource = dataTableShearch;
            
        }

        

        private void parfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parfum_Function parfum_Function = new Parfum_Function();
            RefresData.parfum_Function = parfum_Function;
            parfum_Function.ShowDialog();
        }

        // Sale Price
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalePrice salePrice = new SalePrice();
            RefresData.salePrice = salePrice;
            salePrice.ShowDialog();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSalePrice updateSalePrice = new UpdateSalePrice();
            RefresData.updateSalePrice = updateSalePrice;
            updateSalePrice.ShowDialog();
        }

        private void btn_allparfums_Click(object sender, EventArgs e)
        {
            ChangeData();
        }


        private void LoadCatogory()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string commandSize = "select * from Catogory";
                using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
                {
                    // Connection Open 
                    sqlConnection.Open();

                    // Data Clear
                    combCatogory.Items.Clear();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combCatogory.Items.Add(sqlDataReader[1].ToString().Trim());
                        }
                    }
                    combCatogory.DropDownStyle = ComboBoxStyle.DropDownList;
                    combCatogory.SelectedIndex = 0;
                }
            }
        }

        private void combCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCatogory();
        }



        private void ChangeCatogory()
        {

            string catogory = combCatogory.SelectedItem.ToString().Trim();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                dataGridView1.DataSource = null;
                dataGridShearch.DataSource = null;
                dataTable.Rows.Clear();
                dataTableShearch.Rows.Clear();

                string command = "EXECUTE usp_ShowCategoryParfums '" + catogory + "'";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Fill(dataTableShearch);
                dataGridView1.DataSource = dataTable;
                textcatogory.Text = catogory;
            }
        }

        

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryAdd categoryAdd = new CategoryAdd();
            categoryAdd.ShowDialog();
        }

        

        private void updateDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryUpdateDelete categoryUpdateDelete = new CategoryUpdateDelete();
            categoryUpdateDelete.ShowDialog();
        }
    }
}
