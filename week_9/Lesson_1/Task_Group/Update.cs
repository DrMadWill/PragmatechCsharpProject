using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P121021
{
    public partial class Update : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Update(List<Group> groups, ComboBox cmb, DataGridView dgv)
        {
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmbGroupUpdate.Items.AddRange(groups.ToArray());

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Group selectgroup = cmbGroupUpdate.SelectedItem as Group;
                Student selectStudent = cmbStuUpdate.SelectedItem as Student;
                string name = txtNameUpdate.Text;
                string surename = txtSurnameUpdate.Text;
                selectStudent.UpdateStudent(name, surename);

                if (selectgroup == (Group)_cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectgroup.GetAlLStudent();
                }

                txtNameUpdate.Text = "";
                txtSurnameUpdate.Text = "";
                MessageBox.Show("Update");
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            cmbGroupUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStuUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            //var item = cmbGroupUpdate.Items;
            //cmbGroupUpdate.Items.Remove(item);
            cmbGroupUpdate.SelectedIndex = 0;
            cmbStuUpdate.SelectedIndex = 0;

        }

        private void cmbStuUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Student selectStudent = cmbStuUpdate.SelectedItem as Student;
            txtNameUpdate.Text = selectStudent.Name;
            txtSurnameUpdate.Text = selectStudent.Surname;

        }

        private void txtNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGroupUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmbGroupUpdate.SelectedItem as Group;
            cmbStuUpdate.Items.Clear();
            cmbStuUpdate.Text = "";
            cmbStuUpdate.Items.AddRange(selected_group.GetAlLStudent().ToArray());
        }
    }
}
