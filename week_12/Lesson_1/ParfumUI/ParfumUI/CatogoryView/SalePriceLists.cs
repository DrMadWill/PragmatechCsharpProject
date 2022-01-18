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

        public SalePriceLists()
        {
            InitializeComponent();
        }

        private void SalePriceLists_Load(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SalePrice salePrice = new SalePrice();
            RefresData.salePrice = salePrice;
            salePrice.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSalePrice deleteSalePrice = new DeleteSalePrice();
            deleteSalePrice.ShowDialog();
        }

        public void ChangeData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from FullDetailParfum";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);

                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewShearch.Rows.Clear();
            string name = textSearchName.Text.Trim();
            List<string> lis = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {

                if (row["Name"].ToString().Trim() == name)
                {
                    foreach (DataColumn dataColumn in dataTable.Columns)
                    {
                        lis.Add(row[dataColumn].ToString());

                    }
                    dataGridViewShearch.Rows.Add(lis[0],lis[1],lis[2],lis[3],lis[4],lis[5],lis[6],lis[7], lis[8], lis[9]);
                    lis.Clear();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSalePrice updateSalePrice = new UpdateSalePrice();
            RefresData.updateSalePrice = updateSalePrice;
            updateSalePrice.ShowDialog();
        }
    }
}
