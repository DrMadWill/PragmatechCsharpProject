using ParfumUI.Parfum.Load;
using ParfumUI.SalePriceFolder;
using ParfumUI.Users;
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

namespace ParfumUI.Users
{
    public partial class UserActivityMonitor : Form
    {
        public UserActivityMonitor()
        {
            InitializeComponent();
        }

        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                dataGridShearch.DataSource = null;

                string command = "select * from SaleActivity";
                dataGridShearch.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, command, true);

                
                string commandHeader = "select distinct Parfum from SaleActivity";
                LoadParfumItems.LoadItem(sqlConnection, commandHeader, false, comboParfum);
                

                string commandId = "select distinct Id from SaleActivity";
                LoadParfumItems.LoadItem(sqlConnection, commandId, false, combId);

                string commandFullName = "select distinct FullName from SaleActivity";
                LoadParfumItems.LoadItem(sqlConnection, commandFullName, false, combUser);



                for (int i = 1; i < 13; i++)
                {
                    comboStartMounth.Items.Add(i);
                    comboLastMonth.Items.Add(i);
                }
                for (int i = 1; i < 32; i++)
                {
                    combLastDay.Items.Add(i);
                    combStartDay.Items.Add(i);
                }

            }
        }
    }
}
