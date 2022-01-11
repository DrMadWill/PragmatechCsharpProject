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

namespace RegisterForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RegisterForm.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from FullInfoUser";

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                //using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                //{
                    
                //    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                //    {

                //        while (sqlDataReader.Read())
                //        {
                            
                //            dataGridView1.Rows.Add(sqlDataReader.);
                //        }

                //    }
                //}
            }
        }
    }
}
