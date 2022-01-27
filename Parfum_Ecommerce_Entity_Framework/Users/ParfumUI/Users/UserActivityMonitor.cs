using ParfumUI.Common;
using ParfumUI.Load;
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

        string userNameMain = RefresData.salePriceLists.UserName;

        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void ChangeData()
        {
            var usingSaleuser = LoadCommonData._db.SaleActivityMonitors.Where(dr => dr.FullName == userNameMain).ToList();
            dataGridShearch.DataSource = usingSaleuser;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startdate = dateStartTime.Value;
            DateTime lasttime =  dateLastTime.Value;
           
            
            var usingSaleuser = LoadCommonData._db.SaleActivityMonitors
               .Where(dr => dr.FullName == userNameMain && dr.Date >= startdate && dr.Date <= lasttime).ToList();
            dataGridShearch.DataSource = usingSaleuser;
            // && dr.Date >= startdate && dr.Date <= lasttime
        }


        private void btnReferes_Click(object sender, EventArgs e)
        {
            ChangeData();
        }
    }
}
