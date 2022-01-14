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
    public partial class DeleteForm : Form
    {


        Dictionary<string, int> SearchData;

        public DeleteForm()
        {
            InitializeComponent();
            // instance
            SearchData = new Dictionary<string, int>();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["RegisterForm.Properties.Settings.Setting"].ConnectionString;

        private void DeleteForm_Load(object sender, EventArgs e)
        {

            RefresDeleteForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int Id = SearchData[combSearchName.SelectedItem.ToString()];

                string command = $"delete dbo.[User] where Id = " + Id;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Information delete", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }

            }
        }


        public void RefresDeleteForm()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "select Id,dbo.FUNC_MyConcat(UserName,Name) as 'SearchName' from  dbo.[User]";
                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        combSearchName.Items.Clear();
                        SearchData.Clear();
                        while (sqlDataReader.Read())
                        {
                            combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                            // Combo Add
                            combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                            
                            // Index Zero
                            combSearchName.SelectedIndex = 0;

                            // list add
                            SearchData.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                        }

                    }
                }
            }
        }
    }
}
