namespace POS_System.Controls
{
    partial class UcSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelsetting = new System.Windows.Forms.Panel();
            this.labelSetting = new System.Windows.Forms.Label();
            this.panelsetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsetting
            // 
            this.panelsetting.BackColor = System.Drawing.Color.White;
            this.panelsetting.Controls.Add(this.labelSetting);
            this.panelsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsetting.Location = new System.Drawing.Point(0, 0);
            this.panelsetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelsetting.Name = "panelsetting";
            this.panelsetting.Size = new System.Drawing.Size(1095, 23);
            this.panelsetting.TabIndex = 0;
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSetting.Location = new System.Drawing.Point(0, 0);
            this.labelSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(96, 20);
            this.labelSetting.TabIndex = 0;
            this.labelSetting.Text = "⚙️  Settings";
            // 
            // UcSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelsetting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcSettings";
            this.Size = new System.Drawing.Size(1095, 861);
            this.panelsetting.ResumeLayout(false);
            this.panelsetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsetting;
        private System.Windows.Forms.Label labelSetting;
    }
}
