using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P121021
{
    public partial class Form1 : Form
    {
        private List<Group> groups = new List<Group>();
        public Form1()
        {
            InitializeComponent();
            Student s1 = new Student("Eli", "Eliyev");
            Student s2 = new Student("Mina", "Farzali");
            Student s3 = new Student("Xeyal", "Eliyev");
            Student s4 = new Student("Mad", "Will");
            Student s5 = new Student("Domation", "Road");

            Group group1 = new Group("P500");
            Group group2 = new Group("P505");

            group1.AddStudent(s1);
            group1.AddStudent(s2);
            group1.AddStudent(s4);
            group2.AddStudent(s3);
            group2.AddStudent(s5);

            groups.Add(group1);
            groups.Add(group2);
            cmbGroup.Items.AddRange(groups.ToArray());
            cmbGroup.SelectedIndex = 0;
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            string name = txtStuName.Text.Trim();
            string surname = txtStuSurname.Text.Trim();

            if (name =="" || surname == "")
            {
                MessageBox.Show("Doldur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student student = new Student(name, surname);
            Group selectGroup = (Group)cmbGroup.SelectedItem;
            selectGroup.AddStudent(student);
            dgv.DataSource = null;
            dgv.DataSource = selectGroup.GetAlLStudent();
            txtStuName.Text = "";
            txtStuSurname.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(groups, cmbGroup, dgv);
            delete.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update update = new Update(groups, cmbGroup, dgv);
            update.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtStuSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
