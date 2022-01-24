
namespace ParfumUI
{
    partial class Parfum_Function
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGriidViewName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHeaders = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearchName = new System.Windows.Forms.TextBox();
            this.btnRefres = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(903, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(1056, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(435, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parfum Function";
            // 
            // labelGriidViewName
            // 
            this.labelGriidViewName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGriidViewName.AutoSize = true;
            this.labelGriidViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGriidViewName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGriidViewName.Location = new System.Drawing.Point(12, 318);
            this.labelGriidViewName.Name = "labelGriidViewName";
            this.labelGriidViewName.Size = new System.Drawing.Size(235, 46);
            this.labelGriidViewName.TabIndex = 6;
            this.labelGriidViewName.Text = "All Parfums";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1187, 299);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panelHeaders
            // 
            this.panelHeaders.Controls.Add(this.pictureBox1);
            this.panelHeaders.Controls.Add(this.btnSearch);
            this.panelHeaders.Controls.Add(this.label3);
            this.panelHeaders.Controls.Add(this.textSearchName);
            this.panelHeaders.Controls.Add(this.btnRefres);
            this.panelHeaders.Controls.Add(this.label1);
            this.panelHeaders.Controls.Add(this.labelGriidViewName);
            this.panelHeaders.Controls.Add(this.button3);
            this.panelHeaders.Controls.Add(this.button4);
            this.panelHeaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaders.Location = new System.Drawing.Point(0, 0);
            this.panelHeaders.Name = "panelHeaders";
            this.panelHeaders.Size = new System.Drawing.Size(1211, 393);
            this.panelHeaders.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 221);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1031, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 46);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 38);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search Name : ";
            // 
            // textSearchName
            // 
            this.textSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textSearchName.Location = new System.Drawing.Point(291, 250);
            this.textSearchName.Name = "textSearchName";
            this.textSearchName.Size = new System.Drawing.Size(689, 34);
            this.textSearchName.TabIndex = 26;
            // 
            // btnRefres
            // 
            this.btnRefres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefres.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefres.Location = new System.Drawing.Point(479, 321);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(214, 46);
            this.btnRefres.TabIndex = 7;
            this.btnRefres.Text = "Refres";
            this.btnRefres.UseVisualStyleBackColor = false;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 317);
            this.panel1.TabIndex = 8;
            // 
            // Parfum_Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1211, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeaders);
            this.Name = "Parfum_Function";
            this.Text = "Parfum_Function";
            this.Load += new System.EventHandler(this.Parfum_Function_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeaders.ResumeLayout(false);
            this.panelHeaders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGriidViewName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelHeaders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSearchName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}