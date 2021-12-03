using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        public Form1()
        {
            people = new List<Person>();
            InitializeComponent();
        }

       
        private void button_Click(object sender, EventArgs e)
        {
            string fname = FirstNameBox.Text.Trim();
            string lname = LastNameBox.Text.Trim();
            string dadname = DadSNameBox.Text.Trim();

            Person person = null;
            try
            {
                person = new Person()
                {
                    Name = fname,
                    SureName = lname,
                    DadsName = dadname
                };
                people.Add(person);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            ShowInfo();
        }

        private void ShowInfo()
        {
            listBox1.Items.Clear();
            foreach (var item in people)
            {
                listBox1.Items.Add($">> Name : {item.Name} / SureName : {item.SureName} / Dad's Name : {item.SureName}");
            }
        }
    }
}
