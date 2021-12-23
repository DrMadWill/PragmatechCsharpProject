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
    public partial class PersonAdd : Form
    {
        private List<Person> people;
        private List<String> fileLocation;
        public PersonAdd()
        {
            people = new List<Person>();
            fileLocation = new List<string>();
            InitializeComponent();
        }

        private void PersonAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox_SureName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                if (fileLocation.Count != 0)
                {
                    fileLocation.Clear();
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
                fileLocation.Add(openFileDialog1.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string surename = textBox_SureName.Text;
            string email = textBox_Email.Text;
            string file_location;

            try
            {
                file_location = fileLocation[0];
                Person person = new Person(name, surename, email, file_location);
                if (person != null)
                {
                    people.Add(person);
                    MessageBox.Show("Person Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_Name.Text = "";
                    textBox_SureName.Text = "";
                    textBox_Email.Text = "";
                    pictureBox1.Image = null;
                }
                else
                    throw new Exception("Not Use This Person");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonList persons = new PersonList(people);
            persons.ShowDialog();
        }
    }
}
