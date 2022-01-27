using ParfumUI.Common;
using ParfumUI.DataModelMsSql;
using ParfumUI.Load;
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
        List<string> userNames = new List<string>();
        List<SaleActivityMonitor> saleActivities = new List<SaleActivityMonitor>();
        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {

            userNames = LoadCommonData._db.Users 
                .Where(sd=> sd.IsUser==true)
                .Select(dr => dr.FullName).ToList();
          

            foreach (var user in userNames)
            {
                combUser.Items.Add(user);
            }

            combUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ChangeData();
        }


        private void ChangeData()
        {
            saleActivities.Clear();
            foreach (var item in userNames)
            {
                 saleActivities.AddRange(LoadCommonData._db.SaleActivityMonitors.Where(dr => dr.FullName == item).ToList());
            }

            dataGridShearch.DataSource = saleActivities;

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            DateTime startdate = dateStartTime.Value;
            DateTime lasttime =  dateLastTime.Value;


            if (combUser.SelectedItem != null)
            {
                string userName = combUser.SelectedItem.ToString();
                dataGridShearch.DataSource = SearchActivity(userName, startdate, lasttime);
            }
            else
            {
                ParfumMessenge.Error("Select User ");
                dataGridShearch.DataSource = null;
            }

        }

        private List<DataModelMsSql.SaleActivityMonitor> SearchActivity(string name, DateTime startdate, DateTime lasttime)
        {                                                                    
            var usingSaleuser = LoadCommonData._db.SaleActivityMonitors
                .Where(dr => dr.FullName.ToLower()== name.ToLower() && dr.Date >= startdate && dr.Date <= lasttime).ToList();
            return usingSaleuser;
        }



        private void btnReferes_Click(object sender, EventArgs e)
        {
            ChangeData();
        }
    }
}
