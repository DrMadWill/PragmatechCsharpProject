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

        DataTable dataTable = new DataTable();
        string PriceId = "";
        string Size = "";
        public SalePrice()
        {
            InitializeComponent();
        }


        private void SalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {

                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);
                LoadParfumItems.LoadSize(sqlConnection, false, combSize);

            }
        }
        //Save 
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Create"))
            {
                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                int size = Convert.ToInt32(combSize.SelectedItem.ToString().Trim());
                int price = Convert.ToInt32(textPrice.Text.Trim());
                int number = Convert.ToInt32(textNumber.Text.Trim());

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    // Parfum to Sale Pirce
                    if (!IsAdd(size))
                    {
                        MessageBox.Show("Is Already Added");
                        return;
                    }
                    SalePriceSave(sqlConnection,Id,size,price,number);

                    // Refres datagridwiev
                    dataTable= LoadParfumItems.LoadSalePriceDataTable(sqlConnection, false, Id);
                    dataGridView1.DataSource = dataTable;


                    RefresData.salePriceLists.ChangeData();
                }
                LoadParfumItems.MessengeWarning(": Created");
            }
        }


        // Sale Price Add
        private void SalePriceSave(SqlConnection sqlConnection,int Id,int size,int price,int number)
        {
            
            string commandMain = $"EXECUTE usp_InsertSalePrice @ParfumId= {Id}, @Size={size} ,@Price={price} ,@Number ={number}";
            LoadParfumItems.DataBases(sqlConnection, commandMain,true);
        }

        public void ChangeSize()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
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
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
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
                if(Convert.ToInt32(row["SizeML"]) == size)
                {
                    isAdd = false;
                }
            }


            return isAdd;
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Size Ml Problem
                string id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string SizeML = dataGridView1.Rows[e.RowIndex].Cells["SizeML"].Value.ToString();
                string Price = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string Count = dataGridView1.Rows[e.RowIndex].Cells["Count"].Value.ToString();

                PriceId = id;
                Size = SizeML;
                combSize.SelectedItem = SizeML;
                textPrice.Text = Price;
                textNumber.Text = Count;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Update"))
            {
                if (string.IsNullOrEmpty(PriceId))
                {
                    LoadParfumItems.MessengeWarning("Pleac select price");
                    return;
                }

                int newsize = int.Parse(combSize.SelectedItem.ToString().Trim());
                string price = textPrice.Text.Trim();
                string count = textNumber.Text.Trim();

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    if (!IsAdd(newsize) && newsize !=int.Parse(Size))
                    {
                        MessageBox.Show("Is Already Added");
                        return;
                    }
                    string commad = $"UPDATE SalePrice set SizeId=(select Id from Size where Size={newsize}),Price={price},number={count} where Id = {PriceId} ";

                    LoadParfumItems.DataBases(sqlConnection, commad);

                    // Refres data datagrid view
                    ChangeData(sqlConnection, false);

                    // SalePriceList Refres 
                    RefresData.salePriceLists.ChangeData();
                    LoadParfumItems.MessengeWarning("Udated");
                }
                PriceId = "";
            }

        }

        public void ChangeData(SqlConnection sqlConnection,bool isConnect)
        {
            int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
            // Refres datagridwiev
            dataTable = LoadParfumItems.LoadSalePriceDataTable(sqlConnection, isConnect, Id);
            dataGridView1.DataSource = dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (LoadParfumItems.IsAreYouSure("Delete? If delete this price, deleted connectid sales"))
            {
                if (string.IsNullOrEmpty(PriceId))
                {
                    LoadParfumItems.MessengeWarning("Pleac select price");
                    return;
                }
                string commad = "EXECUTE usp_DeletePrice @Id=" + PriceId;
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    LoadParfumItems.DataBases(sqlConnection, commad);

                    //  Main List Refres
                    RefresData.salePriceLists.ChangeData();

                    // Refres data datagrid view
                    ChangeData(sqlConnection, false);

                    LoadParfumItems.MessengeWarning("Deleted");
                }
                PriceId = "";
            }
        }
    }
}
