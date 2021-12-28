
namespace CloneFileToFolder
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
            this.btnSelectInfo = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textRename = new System.Windows.Forms.TextBox();
            this.checkBoxDeveloperFile = new System.Windows.Forms.CheckBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxHere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectInfo
            // 
            this.btnSelectInfo.Location = new System.Drawing.Point(1003, 43);
            this.btnSelectInfo.Name = "btnSelectInfo";
            this.btnSelectInfo.Size = new System.Drawing.Size(116, 48);
            this.btnSelectInfo.TabIndex = 0;
            this.btnSelectInfo.Text = "Select";
            this.btnSelectInfo.UseVisualStyleBackColor = true;
            this.btnSelectInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select File :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Copy Here :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CopyFolder
            // 
            this.CopyFolder.Location = new System.Drawing.Point(1003, 264);
            this.CopyFolder.Name = "CopyFolder";
            this.CopyFolder.Size = new System.Drawing.Size(116, 48);
            this.CopyFolder.TabIndex = 3;
            this.CopyFolder.Text = "Copy Here";
            this.CopyFolder.UseVisualStyleBackColor = true;
            this.CopyFolder.Click += new System.EventHandler(this.CopyFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rename File Name :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textRename
            // 
            this.textRename.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRename.Location = new System.Drawing.Point(329, 153);
            this.textRename.Name = "textRename";
            this.textRename.Size = new System.Drawing.Size(606, 30);
            this.textRename.TabIndex = 7;
            // 
            // checkBoxDeveloperFile
            // 
            this.checkBoxDeveloperFile.AutoSize = true;
            this.checkBoxDeveloperFile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDeveloperFile.Location = new System.Drawing.Point(987, 153);
            this.checkBoxDeveloperFile.Name = "checkBoxDeveloperFile";
            this.checkBoxDeveloperFile.Size = new System.Drawing.Size(156, 27);
            this.checkBoxDeveloperFile.TabIndex = 9;
            this.checkBoxDeveloperFile.Text = "Developer-File";
            this.checkBoxDeveloperFile.UseVisualStyleBackColor = true;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFile.Location = new System.Drawing.Point(324, 52);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(606, 30);
            this.textBoxFile.TabIndex = 12;
            // 
            // textBoxHere
            // 
            this.textBoxHere.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHere.Location = new System.Drawing.Point(324, 264);
            this.textBoxHere.Name = "textBoxHere";
            this.textBoxHere.Size = new System.Drawing.Size(606, 30);
            this.textBoxHere.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 420);
            this.Controls.Add(this.textBoxHere);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.checkBoxDeveloperFile);
            this.Controls.Add(this.textRename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CopyFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRename;
        private System.Windows.Forms.CheckBox checkBoxDeveloperFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxHere;
    }
}

