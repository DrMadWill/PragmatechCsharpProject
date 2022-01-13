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
    public partial class BrendAdd : Form
    {
        public ParfumAdd parfums;
        public BrendAdd(ParfumAdd parfum)
        {
            InitializeComponent();
            parfums = parfum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string descript = textDescript.Text.Trim();

            string command = $"Insert into dbo.Brend(Name,Decription)values('{name}','{descript}')";
            string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    parfums.ChangeBrend();
                    MessageBox.Show("Information added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textName.Text = "";
                    textDescript.Text="";
                }
            }
        }
    }
}
