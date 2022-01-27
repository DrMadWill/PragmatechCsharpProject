using ParfumUI.Common;
using ParfumUI.Load;
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
        private int UserId = 0;
        private void UserActivity_Load(object sender, EventArgs e)
        {
            ChangeData();
        }

        private void ChangeData()
        {
            // Clear Data
            dataGridViewLoginUser.DataSource = null;
            dataGridViwUser.DataSource = null;
            // User Data
            dataGridViwUser.DataSource = LoadCommonData._db.ActiveUserTables.ToList();

            // Login User Data
            dataGridViewLoginUser.DataSource = LoadCommonData._db.ParfumLoginUsers.ToList();
            labelLoginUserCount.Text ="User Login :" + dataGridViewLoginUser.Rows.Count.ToString();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldname) || UserId == 0)
            {
                ParfumMessenge.Error("You Must Be Slecet Information");
                return;
            }
            if (ParfumMessenge.IsAreYouSure($"Are You Sure Update {oldname}? "))
            {
                
                string fullname = textUserName.Text.Trim();
                string password = textPassword.Text.Trim();

                // null  check
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password))
                {
                    ParfumMessenge.Error("You Must Be Wrtie Information");
                    return;
                }

                if (LoadCommonData.CheckLogin(fullname))
                    return;
                


                if (LoadCommonData.CheckPassword(password))
                    return;

                var checkuser = LoadCommonData._db.Users.FirstOrDefault(dr => dr.FullName == fullname && dr.Id!=UserId);
                if (checkuser != null)
                {
                    ParfumMessenge.Error($" This {fullname} Are Using");
                    return;
                }


                var userUpdate = LoadCommonData._db.Users.Find(UserId);
                userUpdate.FullName = fullname;
                userUpdate.Password = Cryptography.Encode(password);
                userUpdate.IsActive = checkActive.Checked;
                userUpdate.IsEmployee = checkEmloyee.Checked;
                userUpdate.IsUser = checkUser.Checked;

                LoadCommonData._db.SaveChanges();
                ParfumMessenge.Warning($"{oldname} Changed");

                ChangeData();
                ClearData();
                RefresData.salePriceLists.LoginUserChange();

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

                textPassword.Text =  Cryptography.Decode(password);
                textUserName.Text = fullname;

                UserId = Convert.ToInt32(dataGridViwUser.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Are You Sure Add"))
            {

                string fullname = textUserName.Text.Trim();
                string password = textPassword.Text.Trim();
                
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password) )
                {
                    ParfumMessenge.Error("You Must Be Wrtie Information");
                    return;
                }

                if (LoadCommonData.CheckLogin(fullname))
                    return;

                if (LoadCommonData.CheckPassword(password))
                    return;

                if (IsAdded(fullname))
                {
                    ParfumMessenge.Error($"This {fullname} Alredy Added ");
                    return;
                }

               

                DataModelMsSql.User user1 = new DataModelMsSql.User()
                {
                    FullName = fullname,
                    Password = Cryptography.Encode(password),
                    IsUser = checkUser.Checked,
                    IsActive = checkActive.Checked,
                    IsEmployee = checkEmloyee.Checked
                };

                LoadCommonData._db.Users.Add(user1);
                LoadCommonData._db.SaveChanges();

                ParfumMessenge.Warning($"User{fullname} Created");

                ChangeData();
                ClearData();
                RefresData.salePriceLists.LoginUserChange();
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
            UserId = 0;
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

                textPassword.Text = Cryptography.Decode(password); ;
                textUserName.Text = fullname;
                UserId = Convert.ToInt32(dataGridViewLoginUser.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldname) || UserId == 0)
            {
                ParfumMessenge.Error("You Must Be Slecet Information");
                return;
            }
            if (ParfumMessenge.IsAreYouSure($"Are you Delete {oldname} user ?"))
            {
                // Sale Table Chack 
                var parfum_sales = LoadCommonData._db.Sales.FirstOrDefault(dr => dr.User.FullName.Trim() == oldname);
                if(parfum_sales != null)
                {
                    ParfumMessenge.Error($" This {oldname} Are Using");
                    return;
                }

                // Dont Deleted Admin
                var ParfumUser = LoadCommonData._db.Users.Find(UserId);
                LoadCommonData._db.Users.Remove(ParfumUser);
                LoadCommonData._db.SaveChanges();
                ParfumMessenge.Warning($"{oldname} user Deleted");
                ChangeData();
                ClearData();
                RefresData.salePriceLists.LoginUserChange();

            }
            
        }

        private bool IsAdded(string name)
        {
            bool isAdd = false;
            var isAddedName = LoadCommonData._db.Users.FirstOrDefault(dr => dr.FullName == name);
            if (isAddedName != null)
            {
                isAdd = true;
            }
            return isAdd;
        }
    }
}
