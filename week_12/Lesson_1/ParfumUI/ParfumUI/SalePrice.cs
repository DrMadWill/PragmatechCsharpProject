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
    public partial class SalePrice : Form
    {
        private Dictionary<string, int> ParfumNameToID;

        public SalePrice()
        {
            InitializeComponent();
            ParfumNameToID = new Dictionary<string, int>();
        }


        string connectionString = ConfigurationManager.ConnectionStrings["ParfumUI.Properties.Settings.Setting"].ConnectionString;

        private void SalePrice_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string commandSearch = "select * from SearchHead";
                using (SqlCommand sqlCommand = new SqlCommand(commandSearch, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            combSearchName.Items.Add(sqlDataReader[1].ToString().Trim());
                            ParfumNameToID.Add(sqlDataReader[1].ToString().Trim(), Convert.ToInt32(sqlDataReader[0]));
                        }
                    }
                    combSearchName.DropDownStyle = ComboBoxStyle.DropDownList;
                    combSearchName.SelectedIndex = 0;
                }
            }
        }
    }
}
