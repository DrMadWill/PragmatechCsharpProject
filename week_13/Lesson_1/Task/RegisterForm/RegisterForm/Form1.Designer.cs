
namespace RegisterForm
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
            this.combJob = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRegion = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.Label();
            this.textTelb = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combJob
            // 
            this.combJob.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combJob.FormattingEnabled = true;
            this.combJob.Location = new System.Drawing.Point(762, 109);
            this.combJob.Name = "combJob";
            this.combJob.Size = new System.Drawing.Size(239, 43);
            this.combJob.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(73, 109);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(246, 41);
            this.textName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(837, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(441, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUserName.Location = new System.Drawing.Point(413, 109);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(260, 41);
            this.textUserName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(199, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Region";
            // 
            // textRegion
            // 
            this.textRegion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRegion.Location = new System.Drawing.Point(84, 243);
            this.textRegion.Name = "textRegion";
            this.textRegion.Size = new System.Drawing.Size(377, 41);
            this.textRegion.TabIndex = 6;
            // 
            // textTel
            // 
            this.textTel.AutoSize = true;
            this.textTel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textTel.Location = new System.Drawing.Point(765, 192);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(53, 38);
            this.textTel.TabIndex = 9;
            this.textTel.Text = "Tel";
            // 
            // textTelb
            // 
            this.textTelb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTelb.Location = new System.Drawing.Point(640, 243);
            this.textTelb.Name = "textTelb";
            this.textTelb.Size = new System.Drawing.Size(324, 41);
            this.textTelb.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(153, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(832, 64);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 483);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1132, 104);
            this.listBox1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUserToolStripMenuItem,
            this.copyUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listUserToolStripMenuItem
            // 
            this.listUserToolStripMenuItem.Name = "listUserToolStripMenuItem";
            this.listUserToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.listUserToolStripMenuItem.Text = "ListUser";
            this.listUserToolStripMenuItem.Click += new System.EventHandler(this.listUserToolStripMenuItem_Click);
            // 
            // copyUserToolStripMenuItem
            // 
            this.copyUserToolStripMenuItem.Name = "copyUserToolStripMenuItem";
            this.copyUserToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.copyUserToolStripMenuItem.Text = "CopyUser";
            this.copyUserToolStripMenuItem.Click += new System.EventHandler(this.copyUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 576);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textTelb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.combJob);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combJob;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRegion;
        private System.Windows.Forms.Label textTel;
        private System.Windows.Forms.TextBox textTelb;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUserToolStripMenuItem;
    }
}

