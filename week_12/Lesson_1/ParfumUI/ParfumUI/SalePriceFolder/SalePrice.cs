using ParfumUI.Parfum.Load;
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

        DataTable dataTable;
        public SalePrice()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private void SalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);
                LoadParfumItems.LoadSize(sqlConnection, false, combSize);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                int size = Convert.ToInt32(combSize.SelectedItem.ToString().Trim());
                int price = Convert.ToInt32(textPrice.Text.Trim());
                int number = Convert.ToInt32(textNumber.Text.Trim());

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // Parfum to Sale Pirce
                    SalePriceSave(sqlConnection,Id,size,price,number);

                    // Refres datagridwiev
                    dataGridView1.DataSource = LoadParfumItems.LoadSalePriceDataTable(sqlConnection, false, Id);


                    RefresData.salePriceLists.ChangeData();
                }
            }
        }


        // Sale Price Add
        private void SalePriceSave(SqlConnection sqlConnection,int Id,int size,int price,int number)
        {
            if (!IsAdd(size))
            {
                MessageBox.Show("Is Already Added");
                return;
            }

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
            VolumeAdd volumeAdd = new VolumeAdd();
            volumeAdd.ShowDialog();
        }

        private void combSearchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                dataTable= LoadParfumItems.LoadSalePriceDataTable(sqlConnection, true, Id);
                dataGridView1.DataSource = dataTable;
            }
        }

        private bool IsAdd(int size)
        {
            bool isAdd = true;

            foreach (DataRow row in dataTable.Rows)
            {
                if(Convert.ToInt32(row["Size ML"]) == size)
                {
                    isAdd = false;
                }
            }


            return isAdd;
        }
        
    }
}
