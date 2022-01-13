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
    public partial class NewParfum : Form
    {
        public NewParfum()
        {
            InitializeComponent();
        }

        private void NewParfum_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "EXECUTE usp_ShowMeCatogoryParfumId 3";
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
