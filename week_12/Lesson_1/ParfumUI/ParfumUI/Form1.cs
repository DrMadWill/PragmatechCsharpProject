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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKisi_Click(object sender, EventArgs e)
        {
            Male male = new Male();
            male.ShowDialog();
        }

        private void btnQadin_Click(object sender, EventArgs e)
        {
            Female female = new Female();
            female.ShowDialog();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            NewParfum newParfum = new NewParfum();
            newParfum.ShowDialog();
        }

        private void btnEksk_Click(object sender, EventArgs e)
        {
            Special special = new Special();
            special.ShowDialog();
        }

        private void parfumAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalePrice salePrice = new SalePrice();
            salePrice.salePrice = salePrice;
            salePrice.ShowDialog();
        }

        private void parfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parfum_Function parfum_Function = new Parfum_Function();
            parfum_Function.parfums = parfum_Function;
            parfum_Function.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            All alls = new All();
            alls.ShowDialog();
        }
    }
}
