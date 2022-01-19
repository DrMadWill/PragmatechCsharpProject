using ParfumUI.Parfum.Load;
using ParfumUI.SalePriceFolder;
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

namespace ParfumUI.CatogoryView
{
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadParfumItems.LoadSearchName(sqlConnection, true, combSearchName);
                LoadCategory(sqlConnection,false);
            }
        }

        private void LoadCategory(SqlConnection sqlConnection,bool isConnection)
        {
            string commandSize = "select * from Catogory";
            using (SqlCommand sqlCommand = new SqlCommand(commandSize, sqlConnection))
            {
                // Connection Candition 
                LoadParfumItems.ConnectionCadditon(sqlConnection, isConnection);

                // Data Clear
                combCategory.Items.Clear();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        combCategory.Items.Add(sqlDataReader[1].ToString().Trim());
                    }
                }
                combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
                combCategory.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
