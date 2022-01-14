using EFapp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFapp
{
    public partial class Form1 : Form
    {
        private readonly AcademyEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new AcademyEntities();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.People.ToList<Person>();
        }
    }
}
