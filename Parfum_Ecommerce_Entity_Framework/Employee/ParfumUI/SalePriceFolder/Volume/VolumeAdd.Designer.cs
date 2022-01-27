
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
            this.btnSizeUpdate = new System.Windows.Forms.Button();
            this.combSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // textVolume
            // 
            this.textVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVolume.Location = new System.Drawing.Point(204, 66);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(297, 34);
            this.textVolume.TabIndex = 1;
            // 
            // btnVolumeAdd
            // 
            this.btnVolumeAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolumeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolumeAdd.Location = new System.Drawing.Point(18, 139);
            this.btnVolumeAdd.Name = "btnVolumeAdd";
            this.btnVolumeAdd.Size = new System.Drawing.Size(221, 67);
            this.btnVolumeAdd.TabIndex = 2;
            this.btnVolumeAdd.Text = "Add";
            this.btnVolumeAdd.UseVisualStyleBackColor = false;
            this.btnVolumeAdd.Click += new System.EventHandler(this.btnVolumeAdd_Click);
            // 
            // btnSizeUpdate
            // 
            this.btnSizeUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSizeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizeUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSizeUpdate.Location = new System.Drawing.Point(261, 139);
            this.btnSizeUpdate.Name = "btnSizeUpdate";
            this.btnSizeUpdate.Size = new System.Drawing.Size(240, 67);
            this.btnSizeUpdate.TabIndex = 3;
            this.btnSizeUpdate.Text = "Update";
            this.btnSizeUpdate.UseVisualStyleBackColor = false;
            this.btnSizeUpdate.Click += new System.EventHandler(this.btnSizeUpdate_Click);
            // 
            // combSize
            // 
            this.combSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combSize.FormattingEnabled = true;
            this.combSize.Location = new System.Drawing.Point(204, 19);
            this.combSize.Name = "combSize";
            this.combSize.Size = new System.Drawing.Size(297, 33);
            this.combSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Size :";
            // 
            // VolumeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(516, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combSize);
            this.Controls.Add(this.btnSizeUpdate);
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
        private System.Windows.Forms.Button btnSizeUpdate;
        private System.Windows.Forms.ComboBox combSize;
        private System.Windows.Forms.Label label2;
    }
}