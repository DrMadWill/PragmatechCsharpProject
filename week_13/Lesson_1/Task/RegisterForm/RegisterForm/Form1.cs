
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["RegisterForm.Properties.Settings.Setting"].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select * from Job";

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) 
                    {

                        while (sqlDataReader.Read())
                        {
                            combJob.DropDownStyle = ComboBoxStyle.DropDownList;
                            combJob.Items.Add(sqlDataReader[1].ToString().Trim());
                            combJob.SelectedIndex = 0;
                        }
                        
                    }
                }
            }

            // execute usp_SearchJobId @Name,@UserName,@Tel,@Region,@Job
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string username = textUserName.Text;
            string region = textRegion.Text;
            int tel = Convert.ToInt32(textTelb.Text);
            string job = combJob.SelectedItem.ToString();
            //MessageBox.Show(name + "--" + username + "--" + region + "--" + tel + "--" + job);

            string connectionString = ConfigurationManager.ConnectionStrings["RegisterForm.Properties.Settings.Setting"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = $"execute usp_SearchJobId @Name={name},@UserName={username},@Tel={tel},@Region={region},@Job={job}";

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Information added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textName.Text="";
                    textUserName.Text="";
                    textRegion.Text="";
                    textTelb.Text="";
                    combJob.SelectedIndex = 0;
                }
            }

        }

        private void listUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void copyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
