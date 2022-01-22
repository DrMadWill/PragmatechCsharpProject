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
using ParfumUI.Parfum.Load;

namespace ParfumUI
{
    public partial class BrendAdd : Form
    {
        public BrendAdd()
        {
            InitializeComponent();
        }

        // Brend Add Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure("Create"))
            {

            string name = textName.Text.Trim();
            string descript = textDescript.Text.Trim();

            string command = $"Insert into dbo.Brend(Name,Decription)values('{name}','{descript}')";
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                LoadParfumItems.DataBases(sqlConnection, command);
            }
            LoadParfumItems.MessengeWarning("Created");
            textName.Text = "";
            textDescript.Text = "";
            }
        }
    }
}
