
namespace FindWordGameApp
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
            this.combGameCount = new System.Windows.Forms.ComboBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.textGuessWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combGameCount
            // 
            this.combGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combGameCount.FormattingEnabled = true;
            this.combGameCount.Location = new System.Drawing.Point(302, 20);
            this.combGameCount.Name = "combGameCount";
            this.combGameCount.Size = new System.Drawing.Size(245, 39);
            this.combGameCount.TabIndex = 0;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(22, 217);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(82, 32);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "Word";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(212, 297);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(243, 68);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textGuessWord
            // 
            this.textGuessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuessWord.Location = new System.Drawing.Point(252, 208);
            this.textGuessWord.Name = "textGuessWord";
            this.textGuessWord.Size = new System.Drawing.Size(434, 41);
            this.textGuessWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Count :";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(229, 102);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(226, 48);
            this.btnBegin.TabIndex = 5;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnSelectCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textGuessWord);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.combGameCount);
            this.Name = "Form1";
            this.Text = "Find Word Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combGameCount;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textGuessWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBegin;
    }
}

