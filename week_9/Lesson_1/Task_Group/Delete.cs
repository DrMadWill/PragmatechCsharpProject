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
    public partial class Delete : Form
    {
        private ComboBox _cmb;
        private DataGridView _dgv;
        public Delete(List<Group> groups,ComboBox cmb, DataGridView dgv)
        { 
            InitializeComponent();
            _cmb = cmb;
            _dgv = dgv;
            cmbGroupDelete.Items.AddRange(groups.ToArray());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Group selectgroup = cmbGroupDelete.SelectedItem as Group;
                Student selectStudent = cmbStuDelete.SelectedItem as Student;
                selectgroup.DeleteStudent(selectStudent);
                if (selectgroup ==(Group) _cmb.SelectedItem)
                {
                    _dgv.DataSource = null;
                    _dgv.DataSource = selectgroup.GetAlLStudent();
                }
                cmbGroupDelete.Text = "";
                cmbStuDelete.Text = "";
                MessageBox.Show("Deleted");
            }
        }

        private void cmbGroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selected_group = cmbGroupDelete.SelectedItem as Group;
            cmbStuDelete.Items.Clear();
            cmbStuDelete.Text = "";
            cmbStuDelete.Items.AddRange(selected_group.GetAlLStudent().ToArray());
            cmbStuDelete.SelectedIndex = 0;
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            cmbGroupDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStuDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbStuDelete.SelectedIndex = 0;
            //cmbGroupDelete.SelectedIndex = 0;
            cmbGroupDelete.SelectedIndex = 0;
            cmbStuDelete.SelectedIndex = 0;
        }
    }
}
