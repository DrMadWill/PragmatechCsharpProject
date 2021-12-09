
namespace Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGenereBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNameBox1 = new System.Windows.Forms.TextBox();
            this.textISBNNoBox = new System.Windows.Forms.TextBox();
            this.textPriceBox = new System.Windows.Forms.TextBox();
            this.BookAdd = new System.Windows.Forms.Button();
            this.Books = new System.Windows.Forms.ListBox();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.listSeachBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Header.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.Lime;
            this.Header.Location = new System.Drawing.Point(460, 19);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(205, 49);
            this.Header.TabIndex = 0;
            this.Header.Text = "Book Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(74, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(397, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(690, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // comboGenereBox
            // 
            this.comboGenereBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboGenereBox.FormattingEnabled = true;
            this.comboGenereBox.Location = new System.Drawing.Point(897, 179);
            this.comboGenereBox.Name = "comboGenereBox";
            this.comboGenereBox.Size = new System.Drawing.Size(245, 49);
            this.comboGenereBox.TabIndex = 4;
            this.comboGenereBox.SelectedIndexChanged += new System.EventHandler(this.comboGenereBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(938, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genere";
            // 
            // textNameBox1
            // 
            this.textNameBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNameBox1.Location = new System.Drawing.Point(39, 179);
            this.textNameBox1.Name = "textNameBox1";
            this.textNameBox1.Size = new System.Drawing.Size(291, 47);
            this.textNameBox1.TabIndex = 6;
            this.textNameBox1.TextChanged += new System.EventHandler(this.textNameBox1_TextChanged);
            // 
            // textISBNNoBox
            // 
            this.textISBNNoBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textISBNNoBox.Location = new System.Drawing.Point(364, 180);
            this.textISBNNoBox.Name = "textISBNNoBox";
            this.textISBNNoBox.Size = new System.Drawing.Size(258, 47);
            this.textISBNNoBox.TabIndex = 7;
            // 
            // textPriceBox
            // 
            this.textPriceBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPriceBox.Location = new System.Drawing.Point(690, 180);
            this.textPriceBox.Name = "textPriceBox";
            this.textPriceBox.Size = new System.Drawing.Size(124, 47);
            this.textPriceBox.TabIndex = 8;
            // 
            // BookAdd
            // 
            this.BookAdd.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookAdd.Location = new System.Drawing.Point(285, 258);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(529, 49);
            this.BookAdd.TabIndex = 9;
            this.BookAdd.Text = "Add";
            this.BookAdd.UseVisualStyleBackColor = true;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(12, 333);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(1171, 204);
            this.Books.TabIndex = 10;
            // 
            // textSearchBox
            // 
            this.textSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSearchBox.Location = new System.Drawing.Point(296, 597);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(436, 45);
            this.textSearchBox.TabIndex = 12;
            this.textSearchBox.TextChanged += new System.EventHandler(this.textSearchBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Book";
            this.label5.UseWaitCursor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(796, 597);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(363, 49);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listSeachBox
            // 
            this.listSeachBox.FormattingEnabled = true;
            this.listSeachBox.ItemHeight = 20;
            this.listSeachBox.Location = new System.Drawing.Point(12, 668);
            this.listSeachBox.Name = "listSeachBox";
            this.listSeachBox.Size = new System.Drawing.Size(1171, 44);
            this.listSeachBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 801);
            this.Controls.Add(this.listSeachBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.BookAdd);
            this.Controls.Add(this.textPriceBox);
            this.Controls.Add(this.textISBNNoBox);
            this.Controls.Add(this.textNameBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboGenereBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGenereBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNameBox1;
        private System.Windows.Forms.TextBox textISBNNoBox;
        private System.Windows.Forms.TextBox textPriceBox;
        private System.Windows.Forms.Button BookAdd;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox listSeachBox;
    }
}

