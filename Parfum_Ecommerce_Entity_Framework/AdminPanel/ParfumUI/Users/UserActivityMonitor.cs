using ParfumUI.Common;
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

        private void UserActivityMonitor_Load(object sender, EventArgs e)
        {
            ChangeDate();
            var uusers = LoadCommonData._db.Users 
                .Where(sd=> sd.IsUser==true)
                .Select(dr => dr.FullName);

            var employees = LoadCommonData._db.Users
                .Where(dr => dr.IsEmployee == true)
                .Select(sd => sd.FullName);

            foreach (var user in uusers)
            {
                combUser.Items.Add(user);
            }

            foreach (var employee in employees)
            {
                combEmployee.Items.Add(employee);
            }

            combEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            combUser.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ChangeDate()
        {
            dataGridShearch.DataSource = LoadCommonData._db.SaleActivityMonitors.ToList();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            DateTime startdate = dateStartTime.Value;
            DateTime lasttime =  dateLastTime.Value;


            if (checkUser.Checked && combUser.SelectedItem != null)
            {
                string userName = combUser.SelectedItem.ToString();
                dataGridShearch.DataSource = SearchActivity(userName, startdate, lasttime);
            }
            else if(checkEmp.Checked && combEmployee.SelectedItem != null)
            {
                string emploName = combEmployee.SelectedItem.ToString();
                dataGridShearch.DataSource = SearchActivity(emploName, startdate, lasttime);
            }
            else
            {
                ParfumMessenge.Error("Select User Or Emloyee");
                dataGridShearch.DataSource = null;
            }

        }

        private List<DataModelMsSql.SaleActivityMonitor> SearchActivity(string name, DateTime startdate, DateTime lasttime)
        {                                                                    
            var usingSaleuser = LoadCommonData._db.SaleActivityMonitors
                .Where(dr => dr.FullName.ToLower()== name.ToLower() && dr.Date >= startdate && dr.Date <= lasttime).ToList();
            return usingSaleuser;
        }


        private void dataGridShearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridShearch.SelectedRows.Count > 0)
            {

                string id = dataGridShearch.Rows[e.RowIndex].Cells["SaleId"].Value.ToString();
                string PriceId = dataGridShearch.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                string Name = dataGridShearch.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string Brend = dataGridShearch.Rows[e.RowIndex].Cells["Brend"].Value.ToString();
                string Gender = dataGridShearch.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                string Density = dataGridShearch.Rows[e.RowIndex].Cells["Density"].Value.ToString();
                string Size = dataGridShearch.Rows[e.RowIndex].Cells["Size"].Value.ToString();
                string price = dataGridShearch.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                string Number = dataGridShearch.Rows[e.RowIndex].Cells["Sale_Count"].Value.ToString();
                string total = dataGridShearch.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                string date = dataGridShearch.Rows[e.RowIndex].Cells["Date"].Value.ToString();



                //Distinct
                foreach (DataGridViewRow item in dataGridViewDelete.Rows)
                {
                    if (item.Cells["SaleId"].Value.ToString().Trim() == id)
                    {
                        return;
                    }
                }
                dataGridViewDelete.Rows.Add(id, PriceId, Name, Brend, Gender, Density, Size, price, Number, total,date);


            }
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewDelete.Rows.Clear();
        }

        private void dataGridViewDelete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDelete.SelectedRows.Count > 0)
            {
                // Remove Dobul click elemet
                dataGridViewDelete.Rows.Remove(dataGridViewDelete.Rows[e.RowIndex]);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ParfumMessenge.IsAreYouSure("Are You Sure Delete? "))
            {

                int saleid =0;
                if (dataGridViewDelete.Rows.Count == 0)
                {
                    ParfumMessenge.Error("You Must Be Seleceted Sale");
                    return;
                }
            IsEmptyDataGrid:;
                // Foreach Last Elemet Prablem
                foreach (DataGridViewRow row in dataGridViewDelete.Rows)
                {
                    saleid = int.Parse(row.Cells["SaleId"].Value.ToString().Trim());
                    if (saleid == 0)
                    {
                        ParfumMessenge.Error("Not Deleted This Element");
                        return;
                    }

                    var users = LoadCommonData._db.Sales.FirstOrDefault(ed => ed.Id == saleid);
                    if (users != null)
                    {
                        LoadCommonData._db.Sales.Remove(users);
                        LoadCommonData._db.SaveChanges();
                    }

                    dataGridViewDelete.Rows.Remove(row);
                }
                if (dataGridViewDelete.Rows.Count > 0)
                    goto IsEmptyDataGrid;
                RefresData.salePriceLists.ChangeData();
                ParfumMessenge.Warning("Parfum Sales Deleted.");
                ChangeDate();
            }

        }

        private void btnReferes_Click(object sender, EventArgs e)
        {
            dataGridShearch.DataSource = LoadCommonData._db.SaleActivityMonitors.ToList();
        }
    }
}
