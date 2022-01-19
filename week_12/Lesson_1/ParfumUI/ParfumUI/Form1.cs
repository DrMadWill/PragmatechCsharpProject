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

       


        private void parfumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parfum_Function parfum_Function = new Parfum_Function();
            RefresData.parfum_Function = parfum_Function;
            parfum_Function.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatogoryView.SalePriceLists salePriceLists = new CatogoryView.SalePriceLists();
            RefresData.salePriceLists = salePriceLists;
            salePriceLists.ShowDialog();

        }
    }
}
