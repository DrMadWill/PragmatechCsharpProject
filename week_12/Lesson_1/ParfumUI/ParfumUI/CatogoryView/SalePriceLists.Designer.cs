
namespace ParfumUI.CatogoryView
{
    partial class SalePriceLists
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridShearch = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parfumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catogoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combCatogory = new System.Windows.Forms.ComboBox();
            this.btn_allparfums = new System.Windows.Forms.Button();
            this.textcatogory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1279, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 46);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearchName
            // 
            this.textSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchName.Location = new System.Drawing.Point(369, 61);
            this.textSearchName.Name = "textSearchName";
            this.textSearchName.Size = new System.Drawing.Size(886, 34);
            this.textSearchName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Catogory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1435, 398);
            this.dataGridView1.TabIndex = 17;
            // 
            // dataGridShearch
            // 
            this.dataGridShearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridShearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShearch.Location = new System.Drawing.Point(12, 110);
            this.dataGridShearch.Name = "dataGridShearch";
            this.dataGridShearch.RowHeadersWidth = 51;
            this.dataGridShearch.RowTemplate.Height = 24;
            this.dataGridShearch.Size = new System.Drawing.Size(1435, 219);
            this.dataGridShearch.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parfumToolStripMenuItem,
            this.salePriceToolStripMenuItem,
            this.catogoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1459, 33);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parfumToolStripMenuItem
            // 
            this.parfumToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parfumToolStripMenuItem.Name = "parfumToolStripMenuItem";
            this.parfumToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.parfumToolStripMenuItem.Text = "Parfum";
            this.parfumToolStripMenuItem.Click += new System.EventHandler(this.parfumToolStripMenuItem_Click);
            // 
            // salePriceToolStripMenuItem
            // 
            this.salePriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateDeleteToolStripMenuItem});
            this.salePriceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePriceToolStripMenuItem.Name = "salePriceToolStripMenuItem";
            this.salePriceToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.salePriceToolStripMenuItem.Text = "Sale Price";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.updateDeleteToolStripMenuItem.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // catogoryToolStripMenuItem
            // 
            this.catogoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catogoryToolStripMenuItem.Name = "catogoryToolStripMenuItem";
            this.catogoryToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.catogoryToolStripMenuItem.Text = "Catogory";
            this.catogoryToolStripMenuItem.Click += new System.EventHandler(this.catogoryToolStripMenuItem_Click);
            // 
            // combCatogory
            // 
            this.combCatogory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combCatogory.FormattingEnabled = true;
            this.combCatogory.Location = new System.Drawing.Point(244, 344);
            this.combCatogory.Name = "combCatogory";
            this.combCatogory.Size = new System.Drawing.Size(336, 37);
            this.combCatogory.TabIndex = 29;
            this.combCatogory.SelectedIndexChanged += new System.EventHandler(this.combCatogory_SelectedIndexChanged);
            // 
            // btn_allparfums
            // 
            this.btn_allparfums.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_allparfums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allparfums.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_allparfums.Location = new System.Drawing.Point(1215, 339);
            this.btn_allparfums.Name = "btn_allparfums";
            this.btn_allparfums.Size = new System.Drawing.Size(232, 46);
            this.btn_allparfums.TabIndex = 30;
            this.btn_allparfums.Text = "All Parfums";
            this.btn_allparfums.UseVisualStyleBackColor = false;
            this.btn_allparfums.Click += new System.EventHandler(this.btn_allparfums_Click);
            // 
            // textcatogory
            // 
            this.textcatogory.AutoSize = true;
            this.textcatogory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcatogory.Location = new System.Drawing.Point(754, 339);
            this.textcatogory.Name = "textcatogory";
            this.textcatogory.Size = new System.Drawing.Size(191, 46);
            this.textcatogory.TabIndex = 31;
            this.textcatogory.Text = "Catogory";
            // 
            // SalePriceLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 806);
            this.Controls.Add(this.textcatogory);
            this.Controls.Add(this.btn_allparfums);
            this.Controls.Add(this.combCatogory);
            this.Controls.Add(this.dataGridShearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalePriceLists";
            this.Text = "SalePriceLists";
            this.Load += new System.EventHandler(this.SalePriceLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridShearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parfumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salePriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catogoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox combCatogory;
        private System.Windows.Forms.Button btn_allparfums;
        private System.Windows.Forms.Label textcatogory;
    }
}