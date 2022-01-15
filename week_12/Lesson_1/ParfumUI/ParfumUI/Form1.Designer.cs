
namespace ParfumUI
{
    partial class Form1
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
            this.btnKisi = new System.Windows.Forms.Button();
            this.btnQadin = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnEksk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parfumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKisi
            // 
            this.btnKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKisi.Location = new System.Drawing.Point(56, 155);
            this.btnKisi.Name = "btnKisi";
            this.btnKisi.Size = new System.Drawing.Size(338, 92);
            this.btnKisi.TabIndex = 0;
            this.btnKisi.Text = "Kişi";
            this.btnKisi.UseVisualStyleBackColor = true;
            this.btnKisi.Click += new System.EventHandler(this.btnKisi_Click);
            // 
            // btnQadin
            // 
            this.btnQadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQadin.Location = new System.Drawing.Point(427, 155);
            this.btnQadin.Name = "btnQadin";
            this.btnQadin.Size = new System.Drawing.Size(338, 91);
            this.btnQadin.TabIndex = 1;
            this.btnQadin.TabStop = false;
            this.btnQadin.Text = "Qadın";
            this.btnQadin.UseVisualStyleBackColor = true;
            this.btnQadin.Click += new System.EventHandler(this.btnQadin_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.Location = new System.Drawing.Point(56, 295);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(338, 92);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnEksk
            // 
            this.btnEksk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEksk.Location = new System.Drawing.Point(427, 294);
            this.btnEksk.Name = "btnEksk";
            this.btnEksk.Size = new System.Drawing.Size(338, 92);
            this.btnEksk.TabIndex = 3;
            this.btnEksk.Text = "Ekskluziv";
            this.btnEksk.UseVisualStyleBackColor = true;
            this.btnEksk.Click += new System.EventHandler(this.btnEksk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catogory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parfumToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parfumToolStripMenuItem
            // 
            this.parfumToolStripMenuItem.Name = "parfumToolStripMenuItem";
            this.parfumToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.parfumToolStripMenuItem.Text = "Parfum";
            this.parfumToolStripMenuItem.Click += new System.EventHandler(this.parfumToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEksk);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnQadin);
            this.Controls.Add(this.btnKisi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisi;
        private System.Windows.Forms.Button btnQadin;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnEksk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parfumToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

