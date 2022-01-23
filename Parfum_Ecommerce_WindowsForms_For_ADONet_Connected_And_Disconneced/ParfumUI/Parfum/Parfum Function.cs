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
    public partial class Parfum_Function : Form
    {

        DataTable dataTable=null;

        public Parfum_Function()
        {
            InitializeComponent();
        }

        private void Parfum_Function_Load(object sender, EventArgs e)
        {
            // Parfum Load 
            ChangeParfum();
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
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                //dataTable=Parfum.Parfum.ReadParfum(sqlConnection);
                string command = "select * from MidDetalParfume";
                dataTable = LoadParfumItems.DataBeseRead(sqlConnection, command, true);
                // Parfum Data Load 
                dataGridView1.DataSource = dataTable;
            }
            
        }

       

        public bool IsAdd(string name,string brend)
        {
            bool isAdd = true;
            foreach (DataRow row in dataTable.Rows)
            {
                if(row["Name"].ToString().Trim()== name)
                {
                    if(row["Brend"].ToString().Trim()== brend)
                    {
                        isAdd = false;
                    }
                }
            }
            return isAdd;
        }
    }
}
