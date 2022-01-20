
namespace ParfumUI.Users
{
    partial class UserActivity
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
            this.textUserName = new System.Windows.Forms.TextBox();
            this.checkUser = new System.Windows.Forms.CheckBox();
            this.checkEmloyee = new System.Windows.Forms.CheckBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViwUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoginUserCount = new System.Windows.Forms.Label();
            this.dataGridViewLoginUser = new System.Windows.Forms.DataGridView();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViwUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(12, 53);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(261, 38);
            this.textUserName.TabIndex = 0;
            // 
            // checkUser
            // 
            this.checkUser.AutoSize = true;
            this.checkUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkUser.Location = new System.Drawing.Point(608, 58);
            this.checkUser.Name = "checkUser";
            this.checkUser.Size = new System.Drawing.Size(86, 33);
            this.checkUser.TabIndex = 1;
            this.checkUser.Text = "User";
            this.checkUser.UseVisualStyleBackColor = true;
            // 
            // checkEmloyee
            // 
            this.checkEmloyee.AutoSize = true;
            this.checkEmloyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmloyee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkEmloyee.Location = new System.Drawing.Point(712, 58);
            this.checkEmloyee.Name = "checkEmloyee";
            this.checkEmloyee.Size = new System.Drawing.Size(144, 33);
            this.checkEmloyee.TabIndex = 2;
            this.checkEmloyee.Text = "Employee";
            this.checkEmloyee.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(295, 53);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(294, 38);
            this.textPassword.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(1178, 49);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 46);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1342, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 46);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViwUser
            // 
            this.dataGridViwUser.AllowUserToAddRows = false;
            this.dataGridViwUser.AllowUserToDeleteRows = false;
            this.dataGridViwUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViwUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViwUser.Location = new System.Drawing.Point(17, 146);
            this.dataGridViwUser.Name = "dataGridViwUser";
            this.dataGridViwUser.ReadOnly = true;
            this.dataGridViwUser.RowHeadersWidth = 51;
            this.dataGridViwUser.RowTemplate.Height = 24;
            this.dataGridViwUser.Size = new System.Drawing.Size(785, 375);
            this.dataGridViwUser.TabIndex = 6;
            this.dataGridViwUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViwUser_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(803, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Login :";
            // 
            // labelLoginUserCount
            // 
            this.labelLoginUserCount.AutoSize = true;
            this.labelLoginUserCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUserCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginUserCount.Location = new System.Drawing.Point(992, 111);
            this.labelLoginUserCount.Name = "labelLoginUserCount";
            this.labelLoginUserCount.Size = new System.Drawing.Size(31, 32);
            this.labelLoginUserCount.TabIndex = 9;
            this.labelLoginUserCount.Text = "0";
            // 
            // dataGridViewLoginUser
            // 
            this.dataGridViewLoginUser.AllowUserToAddRows = false;
            this.dataGridViewLoginUser.AllowUserToDeleteRows = false;
            this.dataGridViewLoginUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoginUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLoginUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginUser.Location = new System.Drawing.Point(809, 146);
            this.dataGridViewLoginUser.Name = "dataGridViewLoginUser";
            this.dataGridViewLoginUser.ReadOnly = true;
            this.dataGridViewLoginUser.RowHeadersWidth = 51;
            this.dataGridViewLoginUser.RowTemplate.Height = 24;
            this.dataGridViewLoginUser.Size = new System.Drawing.Size(705, 375);
            this.dataGridViewLoginUser.TabIndex = 10;
            this.dataGridViewLoginUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoginUser_CellDoubleClick);
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkActive.Location = new System.Drawing.Point(871, 58);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(99, 33);
            this.checkActive.TabIndex = 11;
            this.checkActive.Text = "Active";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(995, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "FullName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // UserActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1526, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.dataGridViewLoginUser);
            this.Controls.Add(this.labelLoginUserCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViwUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.checkEmloyee);
            this.Controls.Add(this.checkUser);
            this.Controls.Add(this.textUserName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UserActivity";
            this.Text = "User Activity";
            this.Load += new System.EventHandler(this.UserActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViwUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.CheckBox checkEmloyee;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViwUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoginUserCount;
        private System.Windows.Forms.DataGridView dataGridViewLoginUser;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}