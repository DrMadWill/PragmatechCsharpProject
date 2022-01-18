using ParfumUI.Parfum.Load;
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
    public partial class DeleteParfum : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public DeleteParfum()
        {
            InitializeComponent();
        }

        private void DeleteParfum_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Load Parum Header
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you  sure delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                int Id = ((ParfumHeader)combSearchName.SelectedItem).Id;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    Parfum.Parfum.DeleteParfum(Id, sqlConnection);

                    // Refres Search ComboBox
                    LoadParfumItems.LoadSearchName(sqlConnection, false, combSearchName);

                    // Change DataGridVeiw
                    RefresData.parfum_Function.ChangeParfum();
                }
            }
        }
    }
}
