
namespace ParfumUI.SalePriceFolder.Volume
{
    partial class VolumeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textVolume = new System.Windows.Forms.TextBox();
            this.btnVolumeAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume :";
            // 
            // textVolume
            // 
            this.textVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVolume.Location = new System.Drawing.Point(194, 43);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(170, 34);
            this.textVolume.TabIndex = 1;
            // 
            // btnVolumeAdd
            // 
            this.btnVolumeAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolumeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolumeAdd.Location = new System.Drawing.Point(33, 123);
            this.btnVolumeAdd.Name = "btnVolumeAdd";
            this.btnVolumeAdd.Size = new System.Drawing.Size(331, 67);
            this.btnVolumeAdd.TabIndex = 2;
            this.btnVolumeAdd.Text = "Add";
            this.btnVolumeAdd.UseVisualStyleBackColor = false;
            this.btnVolumeAdd.Click += new System.EventHandler(this.btnVolumeAdd_Click);
            // 
            // VolumeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(401, 221);
            this.Controls.Add(this.btnVolumeAdd);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.label1);
            this.Name = "VolumeAdd";
            this.Text = "VolumeAdd";
            this.Load += new System.EventHandler(this.VolumeAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVolume;
        private System.Windows.Forms.Button btnVolumeAdd;
    }
}