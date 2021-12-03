using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        private Library madwill;
        public Form1()
        {
            madwill = new Library();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            string bookname;
            string isbnn;
            int price;
            Genre genertype;
            try
            {
                bookname = textNameBox1.Text.Trim();
                isbnn = textISBNNoBox.Text.Trim();
                price = int.Parse(textPriceBox.Text);
                genertype = comboGenereBox.Text switch
                {
                    "Novel" => Genre.Novel,
                    "Story" => Genre.Story,
                    "Theater" => Genre.Theater,
                    _ => throw new Exception("You Dont Use Ture Genre"),
                };
                this.madwill.AddBook(bookname, isbnn, genertype, price);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ShowInfo();


        }

        private void comboGenereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ShowInfo()
        {
            Books.Items.Clear();
            foreach (var item in this.madwill.Books)
            {
                Books.Items.Add($">> Id : {item.Id} / Name : {item.Name} / ISBN No : {item.ISBNNo} / Price : {item.Price} / Genere {item.GenreType}");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listSeachBox.Items.Clear();
            string name = textSearchBox.Text.Trim();
            Book item = madwill.GetFindBook(name);
            listSeachBox.Items.Add($">> Id : {item.Id} / Name : {item.Name} / ISBN No : {item.ISBNNo} / Price : {item.Price} / Genere {item.GenreType}");
        }
    }
}
