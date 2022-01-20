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

namespace ParfumUI.Users
{
    public partial class UserActivity : Form
    {
        public UserActivity()
        {
            InitializeComponent();
        }

        private string oldname="";
        private void UserActivity_Load(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void ChangeData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
            {
                // Clear Data
                dataGridViewLoginUser.DataSource = null;
                dataGridViwUser.DataSource = null;
                // User Data
                string commandUser = "select * from ActiveUserTable";
                dataGridViwUser.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, commandUser, true);

                // Login User Data
                string commandLogin = "select * from ParfumLoginUsers";
                dataGridViewLoginUser.DataSource = LoadParfumItems.DataBeseRead(sqlConnection, commandLogin, false);
                labelLoginUserCount.Text = dataGridViewLoginUser.Rows.Count.ToString();

            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure())
            {
                string fullname = textUserName.Text.Trim();
                string password = textPassword.Text.Trim();

                int user = 0;
                if (checkUser.Checked)
                    user = 1;


                int isEmploye = 0;
                if (checkEmloyee.Checked)
                    isEmploye = 1;


                int isActive = 0;
                if (checkActive.Checked)
                    isActive = 1;

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command = $"update Parfume.dbo.Users set FullName='{fullname}',[Password]='{password}',IsUser={user},IsEmployee={isEmploye},IsActive={isActive} where FullName = '{oldname}'";
                    LoadParfumItems.DataBases(sqlConnection, command);
                    LoadParfumItems.MessengeWarning("Updated");
                    ChangeData();
                    ClearData();
                }
            }
        }

        

        private void dataGridViwUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViwUser.SelectedRows.Count > 0)
            {
                ClearData();
                string fullname = dataGridViwUser.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                oldname = fullname;
                string password = dataGridViwUser.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                bool isActive = Convert.ToBoolean(dataGridViwUser.Rows[e.RowIndex].Cells["IsActive"].Value.ToString());
                bool isUser = Convert.ToBoolean(dataGridViwUser.Rows[e.RowIndex].Cells["IsUser"].Value.ToString());
                bool isEmploye = Convert.ToBoolean(dataGridViwUser.Rows[e.RowIndex].Cells["IsEmployee"].Value.ToString());
                if (isActive)
                    checkActive.Checked = true;
                if (isEmploye)
                    checkEmloyee.Checked = true;
                if (isUser)
                    checkUser.Checked = true;

                textPassword.Text = password;
                textUserName.Text = fullname;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure())
            {
                string fullname = textUserName.Text.Trim();
                string password = textPassword.Text.Trim();

                int user = 0;
                if (checkUser.Checked)
                    user = 1;


                int isEmploye = 0;
                if (checkEmloyee.Checked)
                    isEmploye = 1;


                int isActive = 0;
                if (checkActive.Checked)
                    isActive = 1;

                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command = $"insert into Parfume.dbo.Users(FullName,[Password],IsUser,IsEmployee,IsActive)values('{fullname}','{password}',{user},{isEmploye},{isActive})";
                    LoadParfumItems.DataBases(sqlConnection, command);
                    LoadParfumItems.MessengeCreate();
                    ChangeData();
                    ClearData();
                }
            }
        }

        
        private void ClearData()
        {
            textUserName.Text = "";
            textPassword.Text = "";
            checkUser.Checked = false;
            checkEmloyee.Checked = false;
            checkActive.Checked = false;
            oldname = "";
        }

        private void dataGridViewLoginUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearData();
            if (dataGridViewLoginUser.SelectedRows.Count > 0)
            {
                string fullname = dataGridViewLoginUser.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                oldname = fullname;
                string password = dataGridViewLoginUser.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                bool isActive = Convert.ToBoolean(dataGridViewLoginUser.Rows[e.RowIndex].Cells["IsActive"].Value.ToString());
                bool isUser = Convert.ToBoolean(dataGridViewLoginUser.Rows[e.RowIndex].Cells["IsUser"].Value.ToString());
                bool isEmploye = Convert.ToBoolean(dataGridViewLoginUser.Rows[e.RowIndex].Cells["IsEmployee"].Value.ToString());
                if (isActive)
                    checkActive.Checked = true;
                if (isEmploye)
                    checkEmloyee.Checked = true;
                if (isUser)
                    checkUser.Checked = true;

                textPassword.Text = password;
                textUserName.Text = fullname;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LoadParfumItems.IsAreYouSure())
            {
                string fullname = textUserName.Text.Trim();
                using (SqlConnection sqlConnection = new SqlConnection(LoadParfumItems.connectionString))
                {
                    string command = $"delete dbo.Users where FullName ='{fullname}'";
                    LoadParfumItems.DataBases(sqlConnection, command);
                    LoadParfumItems.MessengeWarning("Deleted");
                    ChangeData();
                    ClearData();
                }
            }
            
        }
    }
}
