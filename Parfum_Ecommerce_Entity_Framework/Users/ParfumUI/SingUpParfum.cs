using ParfumUI.Common;
using ParfumUI.Load;
using ParfumUI.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI
{
    public partial class SingUpParfum : Form
    {
        public SingUpParfum()
        {
            InitializeComponent();
        }

        private void SingUpParfum_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
            textCheckPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ParfumMessenge.IsAreYouSure("Are You Sure Login?"))
            {

                string fullname = textLogin.Text.Trim();
                string password = textPassword.Text.Trim();

                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(textCheckPassword.Text))
                {
                    ParfumMessenge.Error("You Must Be Wrtie Information");
                    return;
                }

                var isUsinUser = LoadCommonData._db.Users.FirstOrDefault(dr => dr.FullName == fullname);
                if (isUsinUser != null)
                {
                    ParfumMessenge.Error($"This {fullname} Already Using");
                    return;
                }

                if (LoadCommonData.CheckLogin(fullname))
                    return;

                if (LoadCommonData.CheckPassword(password))
                    return;

                if (textCheckPassword.Text != textPassword.Text)
                {
                    ParfumMessenge.Error("Check Password Wrong");
                    return;
                }


                DataModelMsSql.User user1 = new DataModelMsSql.User()
                {
                    FullName = fullname,
                    Password = Cryptography.Encode(password),
                    IsUser = true,
                    IsActive = false,
                    IsEmployee = false
                };

                LoadCommonData._db.Users.Add(user1);
                LoadCommonData._db.SaveChanges();

                ParfumMessenge.Warning($"User {fullname} Access Send");

                this.Close();
            }
        }
    }
}
