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


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WinFormsApp1.Properties.Settings.Setting"].ConnectionString;
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand = null;
            //SqlDataReader sqlDataReader = null;

            //try
            //{

            //    sqlConnection = new SqlConnection(connectionString);
            //    sqlConnection.Open();

            //    string command = "Select * from Groups";
            //    sqlCommand = new SqlCommand(command, sqlConnection);

            //    sqlDataReader = sqlCommand.ExecuteReader();

            //    while (sqlDataReader.Read())
            //    {
            //        combClass.Items.Add(sqlDataReader[1]); 
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from Groups";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combClass.Items.Add(sqlDataReader[1]);
                        }
                    }
                }
            }




        }
    }
}
