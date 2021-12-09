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
        private GenreList genrelis;
        public Form1()
        {
            madwill = new Library();
            genrelis = new GenreList();
            genrelis.AddGenre("Novel");
            genrelis.AddGenre("Story");
            genrelis.AddGenre("Teatr");
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
            int genertype;
            string genreName;
            try
            {
                bookname = textNameBox1.Text.Trim();
                isbnn = textISBNNoBox.Text.Trim();
                price = int.Parse(textPriceBox.Text);
                genertype = genrelis.FindGenreId(comboGenereBox.Text);
                genreName = comboGenereBox.Text;
                this.madwill.AddBook(bookname, isbnn, genertype, price, genreName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ShowInfo();
            textNameBox1.Text = String.Empty;
            textISBNNoBox.Text = String.Empty;
            textPriceBox.Text = String.Empty;
            comboGenereBox.SelectedIndex = -1;
        }

        private void comboGenereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public string GetFindGenreName(int id)
        {
            string name = "";
            Genre genre = genrelis.genres.Find(e => e.GenreId == id);
            if (genre != null)
            {
                name = genre.Name;
            }
            return name;
        }

        private void ShowInfo()
        {
            Books.Items.Clear();
            foreach (var item in this.madwill.Books)
            {
                Books.Items.Add($">> Id : {item.Id} / Name : {item.Name} / ISBN No : {item.ISBNNo} / Price : {item.Price} / Genere : { GetFindGenreName(item.GenreType)}");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listSeachBox.Items.Clear();
            try
            {
                if (string.IsNullOrEmpty(textSearchBox.Text))
                {
                    throw new Exception("Empty Element");
                }
                else
                {
                    string name = textSearchBox.Text.Trim();
                    Book item = madwill.GetFindBook(name);
                    if (item != null)
                        listSeachBox.Items.Add($">> Id : {item.Id} / Name : {item.Name} / ISBN No : {item.ISBNNo} / Price : {item.Price} / Genere : {GetFindGenreName(item.GenreType)}");
                    else
                        throw new Exception("Not Found This Book");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboGenereBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGenereBox.Items.AddRange(genrelis.GetGenreNames().ToArray());
        }

        private void textSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
