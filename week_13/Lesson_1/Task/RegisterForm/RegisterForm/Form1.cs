
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
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string name;
                string username;
                string region;
                int tel;
                string job;
                string command;
                try
                {

                    name = textName.Text.Trim();
                    username = textUserName.Text.Trim();
                    region = textRegion.Text.Trim();
                    tel = Convert.ToInt32(textTelb.Text.Trim());
                    job = combJob.SelectedItem.ToString().Trim();
                    if (name.Length > 40 || username.Length > 40 || region.Length > 40)
                    {
                        throw new Exception("So Long Information");
                    }

                    command = $"execute usp_SearchJobId @Name={name},@UserName={username},@Tel={tel},@Region={region},@Job={job}";
                    string connectionString = ConfigurationManager.ConnectionStrings["RegisterForm.Properties.Settings.Setting"].ConnectionString;
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                        {
                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Information added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textName.Text = "";
                            textUserName.Text = "";
                            textRegion.Text = "";
                            textTelb.Text = "";
                            combJob.SelectedIndex = 0;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }
    }
}
