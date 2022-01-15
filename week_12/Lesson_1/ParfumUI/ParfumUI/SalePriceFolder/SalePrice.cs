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


namespace ParfumUI
{
    public partial class SalePrice : Form
    {
        private Dictionary<string, int> ParfumNameToID;

        public SalePrice()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
        }


        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private void SalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName, ParfumNameToID);

                LoadParfumItems.LoadSize(sqlConnection, false, combSize);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString().Trim()] ;
                int size = Convert.ToInt32(combSize.SelectedItem.ToString().Trim());
                int price = Convert.ToInt32(textPrice.Text.Trim());
                int number = Convert.ToInt32(textNumber.Text.Trim());

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    // Parfum to Sale Pirce
                    SalePriceSave(sqlConnection,Id,size,price,number);

                    // Refres datagridwiev
                    dataGridView1.DataSource = SelectedChangeSalePrice(sqlConnection, false, Id);
                }

                


            }
        }



        // Sale Price Add
        private void SalePriceSave(SqlConnection sqlConnection,int Id,int size,int price,int number)
        {
            string commandMain = $"EXECUTE usp_InsertSalePrice @ParfumId= {Id}, @Size={size} ,@Price={price} ,@Number ={number}";
            using (SqlCommand sqlCommand = new SqlCommand(commandMain, sqlConnection))
            {
                sqlConnection.Open();
                // Change DataBases
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Information Added ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ChangeSize()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadSize(sqlConnection, true, combSize);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int Id = ParfumNameToID[combSearchName.SelectedItem.ToString().Trim()];
                dataGridView1.DataSource = SelectedChangeSalePrice(sqlConnection,true,Id);
            }


        }

        private DataTable SelectedChangeSalePrice(SqlConnection sqlConnection,bool isConnectOpen, int Id)
        {
            string commad = "EXECUTE usp_SelectIdSalePirce " + Id;
            //Connect Open
            if(isConnectOpen)
                sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(commad, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
