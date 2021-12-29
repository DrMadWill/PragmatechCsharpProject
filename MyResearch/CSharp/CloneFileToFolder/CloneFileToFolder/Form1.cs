using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneFileToFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog data = new OpenFileDialog() { Filter = "All|*.*" })
            {
                if (data.ShowDialog() == DialogResult.OK)
                    textBoxFile.Text = data.FileName;
            }
        }

        private void CopyFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog data = new FolderBrowserDialog())
            {
                if (data.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(textBoxFile.Text);
                    textBoxHere.Text = Path.Combine(data.SelectedPath, file.Name);
                    File.Copy(textBoxFile.Text, textBoxHere.Text, true);

                    //Rename
                    if (!String.IsNullOrEmpty(textRename.Text.Trim()))
                        FileRename(file.Name, data.SelectedPath);
                    MessageBox.Show("You Copy File", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FileRename(string file_name,string selected_file)
        {
            string[] filename_Extensions = file_name.Split(".");
            string filenewname = textRename.Text.Trim().ToString();

            // Time Developer
            if (checkBoxDeveloperFile.Checked)
                filenewname = DeveloperFile(filenewname);

            string filename = Path.Combine(selected_file, $"{filenewname}.{filename_Extensions[1]}");
            File.Move(textBoxHere.Text, filename);
            textBoxHere.Text = filename;
        }



        private string DeveloperFile(string filenewname)
        {
            string[] developerfile = filenewname.Split(" ");
            StringBuilder convertnamefordevloper = new StringBuilder();
            bool isConinue = true;
            foreach (var item in developerfile)
            {
                if (isConinue == true)
                {
                    isConinue = false;
                    convertnamefordevloper.Append(item);
                    continue;
                }
                convertnamefordevloper.Append("-" + item);
            }
            return convertnamefordevloper.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
