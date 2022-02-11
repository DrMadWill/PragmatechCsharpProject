
namespace FindWordGameApp
{
    partial class UserInformation
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelFalseWords = new System.Windows.Forms.Label();
            this.labelTrueWords = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGameCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(12, 31);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(111, 32);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "Score : ";
            // 
            // labelFalseWords
            // 
            this.labelFalseWords.AutoSize = true;
            this.labelFalseWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFalseWords.Location = new System.Drawing.Point(12, 96);
            this.labelFalseWords.Name = "labelFalseWords";
            this.labelFalseWords.Size = new System.Drawing.Size(181, 32);
            this.labelFalseWords.TabIndex = 1;
            this.labelFalseWords.Text = "FalseWords :";
            // 
            // labelTrueWords
            // 
            this.labelTrueWords.AutoSize = true;
            this.labelTrueWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrueWords.Location = new System.Drawing.Point(12, 173);
            this.labelTrueWords.Name = "labelTrueWords";
            this.labelTrueWords.Size = new System.Drawing.Size(169, 32);
            this.labelTrueWords.TabIndex = 2;
            this.labelTrueWords.Text = "TrueWords :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(491, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 338);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "False Words";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // labelGameCount
            // 
            this.labelGameCount.AutoSize = true;
            this.labelGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameCount.Location = new System.Drawing.Point(12, 256);
            this.labelGameCount.Name = "labelGameCount";
            this.labelGameCount.Size = new System.Drawing.Size(311, 32);
            this.labelGameCount.TabIndex = 4;
            this.labelGameCount.Text = "Common Game Count :";
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 364);
            this.Controls.Add(this.labelGameCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTrueWords);
            this.Controls.Add(this.labelFalseWords);
            this.Controls.Add(this.labelScore);
            this.Name = "UserInformation";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelFalseWords;
        private System.Windows.Forms.Label labelTrueWords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label labelGameCount;
    }
}