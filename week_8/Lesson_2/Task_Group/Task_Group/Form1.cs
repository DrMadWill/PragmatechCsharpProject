using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Group
{
    public partial class Form1 : Form
    {
        StudentList studentList;
        GroupList groupList;
        public Form1()
        {
            studentList = new StudentList();
            groupList = new GroupList();
            groupList.Add("P244");
            groupList.Add("P554");
            groupList.Add("A574");
            groupList.Add("B884");
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.AddRange(groupList.GetGroupNames().ToArray());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = TextName.Text; ;
            string surename = TextSureName.Text;
            int groupid;
            try
            {
                groupid = groupList.GetFindGroupId(comboBox.Text);
                studentList.AddStudent(name, surename, groupid);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TextName.Text = String.Empty;
            TextSureName.Text = String.Empty;
            comboBox.SelectedIndex = -1;
            dataGridView1.DataSource = studentList.Students;
            save.Text = studentList.Students.Count + " Added";

        }


        private void ShowData()
        {
            
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
