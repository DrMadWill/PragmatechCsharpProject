using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindWordGameApp
{
    public partial class UserInformation : Form
    {
        private User _user;
        public UserInformation(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            labelFalseWords.Text = labelFalseWords.Text.Trim() + _user.FalseWords;
            labelGameCount.Text = labelGameCount.Text.Trim() + _user.CommonGameCount;
            labelTrueWords.Text = labelTrueWords.Text.Trim() + _user.TrueWords;
            labelScore.Text = labelScore.Text.Trim() + _user.Score;
            foreach (var item in _user.userFalseWords)
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
