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
        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        public Parfum_Function()
        {
            InitializeComponent();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            // Parfum Load 
            ChangeParfum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Parfum Data Load 
                dataGridView1.DataSource = Parfum.Parfum.ReadParfum(sqlConnection);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteParfum deleteParfum = new DeleteParfum();
            deleteParfum.ShowDialog();
        }
    }
}
