using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork
{
    public partial class PersonList : Form
    {
        private List<Person> _people;
        public PersonList(List<Person> people)
        {
            _people = people;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PersonList_Load(object sender, EventArgs e)
        {
            comboBoxpeople.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxpeople.Items.AddRange(_people.ToArray());
            comboBoxpeople.SelectedIndex = 0;
            dataGridView_people.DataSource = _people.ToArray();
        }

        private void comboBoxpeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person person = comboBoxpeople.SelectedItem as Person;
            id.Text = person.Id.ToString();
            name.Text = person.Name;
            surename.Text = person.SureName;
            labele_mail.Text = person.E_mail;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load(person.Img_Location);
        }

        private void dataGridView_people_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
