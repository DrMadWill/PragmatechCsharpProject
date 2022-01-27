
namespace ParfumUI.CatogoryView
{
    partial class CategoryAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridListCategory = new System.Windows.Forms.DataGridView();
            this.listCategory = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combSearchName = new System.Windows.Forms.ComboBox();
            this.ParfumCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridListCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1029, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 532);
            this.panel1.TabIndex = 63;
            // 
            // dataGridListCategory
            // 
            this.dataGridListCategory.AllowUserToAddRows = false;
            this.dataGridListCategory.AllowUserToDeleteRows = false;
            this.dataGridListCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridListCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParfumCategory});
            this.dataGridListCategory.Location = new System.Drawing.Point(3, 12);
            this.dataGridListCategory.Name = "dataGridListCategory";
            this.dataGridListCategory.ReadOnly = true;
            this.dataGridListCategory.RowHeadersWidth = 51;
            this.dataGridListCategory.RowTemplate.Height = 24;
            this.dataGridListCategory.Size = new System.Drawing.Size(270, 508);
            this.dataGridListCategory.TabIndex = 0;
            // 
            // listCategory
            // 
            this.listCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCategory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategory.FullRowSelect = true;
            this.listCategory.GridLines = true;
            this.listCategory.HideSelection = false;
            this.listCategory.Location = new System.Drawing.Point(269, 95);
            this.listCategory.Margin = new System.Windows.Forms.Padding(7);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(750, 334);
            this.listCategory.TabIndex = 68;
            this.listCategory.UseCompatibleStateImageBehavior = false;
            this.listCategory.View = System.Windows.Forms.View.List;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(12, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1007, 63);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 66;
            this.label1.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 36);
            this.label7.TabIndex = 65;
            this.label7.Text = "Search Parfum :";
            // 
            // combSearchName
            // 
            this.combSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSearchName.FormattingEnabled = true;
            this.combSearchName.Location = new System.Drawing.Point(269, 19);
            this.combSearchName.Name = "combSearchName";
            this.combSearchName.Size = new System.Drawing.Size(750, 37);
            this.combSearchName.TabIndex = 64;
            this.combSearchName.SelectedIndexChanged += new System.EventHandler(this.combSearchName_SelectedIndexChanged);
            // 
            // ParfumCategory
            // 
            this.ParfumCategory.HeaderText = "Category";
            this.ParfumCategory.MinimumWidth = 6;
            this.ParfumCategory.Name = "ParfumCategory";
            this.ParfumCategory.ReadOnly = true;
            // 
            // CategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1314, 532);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combSearchName);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryAdd";
            this.Text = "CategoryAdd";
            this.Load += new System.EventHandler(this.CategoryAdd_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridListCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParfumCategory;
        private System.Windows.Forms.ListView listCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combSearchName;
    }
}