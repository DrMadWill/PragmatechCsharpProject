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
    public partial class Parfum_Function : Form
    {

        public Parfum_Function parfums;
        public Parfum_Function()
        {
            InitializeComponent();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            ChangeParfum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParfumAdd parfumAdd = new ParfumAdd();
            parfumAdd.parfumAdd_Location = parfumAdd;
            parfumAdd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParfumeUpdate parfumeUpdate = new ParfumeUpdate();
            parfumeUpdate.parfums = parfums;
            parfumeUpdate.ShowDialog();
        }


        public void ChangeParfum()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from MidDetalParfume";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
