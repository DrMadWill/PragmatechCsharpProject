using ParfumUI.Parfum.Load;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI
{
    public partial class Parfum_Function : Form
    {

        DataTable dataTable=null;

        public Parfum_Function()
        {
            InitializeComponent();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            // Parfum Load 
            ChangeParfum();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            ParfumAdd parfumAdd = new ParfumAdd();
            RefresData.parfumAdd = parfumAdd;
            parfumAdd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParfumeUpdate parfumeUpdate = new ParfumeUpdate();
            RefresData.parfumeUpdate = parfumeUpdate;
            parfumeUpdate.ShowDialog();
        }


        public void ChangeParfum()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                string command = "select * from MidDetalParfume";
                dataTable = LoadParfumItems.DataBeseRead(sqlConnection, command, true);
                dataGridView1.DataSource = dataTable;
            }
            
        }

       

        public bool IsAdd(string name,string brend)
        {
            bool isAdd = true;
            foreach (DataRow row in dataTable.Rows)
            {
                if(row["Name"].ToString().Trim()== name)
                {
                    if(row["Brend"].ToString().Trim()== brend)
                    {
                        isAdd = false;
                    }
                }
            }
            return isAdd;
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            ChangeParfum();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string shearch = textSearchName.Text.Trim();
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                string command = $"select * from MidDetalParfume where Name Like '%{shearch}%'";
                dataGridView1.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, command, true);
                labelGriidViewName.Text = "Search Parfum Resault";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                string Id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                pictureBox1.Image = null;
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command = $"select Image from Parfume where Id=" + Id;
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        if (!string.IsNullOrEmpty(sqlCommand.ExecuteScalar().ToString()))
                        {
                            byte[] imgloc = (byte[])sqlCommand.ExecuteScalar();
                            MemoryStream memory = new MemoryStream(imgloc);
                            Image ret = Image.FromStream(memory);
                            pictureBox1.Image = ret;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
        }
    }
}
