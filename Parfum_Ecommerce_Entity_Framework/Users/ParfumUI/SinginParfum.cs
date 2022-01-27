using ParfumUI.CatogoryView;
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
    public partial class SinginParfum : Form
    {
        public SinginParfum()
        {
            InitializeComponent();
        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text.Trim();

            string pass = textPassword.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                ParfumMessenge.Error("You Must Be Wrtie Information");
                return;
            }
            var user = LoadCommonData._db.Users.FirstOrDefault(dr => dr.FullName == login);
            if (user != null && user.IsUser && user.IsActive)
            {
                if (Cryptography.Decode(user.Password) == pass)
                {
                    SalePriceLists salePriceLists = new SalePriceLists(user.FullName);
                    RefresData.salePriceLists = salePriceLists;
                    salePriceLists.ShowDialog();
                    textLogin.Text = "";
                    textPassword.Text = "";
                }
                else
                    ParfumMessenge.Error("Login wrong !");
            }
            else
            {
                ParfumMessenge.Error("Login wrong Or Not Access!");
            }
        }

        private void SinginParfum_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SingUpParfum singUp = new SingUpParfum();
            singUp.ShowDialog();
        }
    }
}
