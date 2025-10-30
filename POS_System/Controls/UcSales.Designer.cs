namespace POS_System.Controls
{
    partial class panelSales
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
            this.panelTitlSales = new System.Windows.Forms.Panel();
            this.labelSales = new System.Windows.Forms.Label();
            this.panelTitlSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlSales
            // 
            this.panelTitlSales.BackColor = System.Drawing.Color.White;
            this.panelTitlSales.Controls.Add(this.labelSales);
            this.panelTitlSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlSales.Location = new System.Drawing.Point(0, 0);
            this.panelTitlSales.Name = "panelTitlSales";
            this.panelTitlSales.Size = new System.Drawing.Size(1095, 23);
            this.panelTitlSales.TabIndex = 0;
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSales.Location = new System.Drawing.Point(0, 0);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(77, 20);
            this.labelSales.TabIndex = 0;
            this.labelSales.Text = "💰  Sales";
            this.labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panelTitlSales);
            this.Name = "panelSales";
            this.Size = new System.Drawing.Size(1095, 861);
            this.panelTitlSales.ResumeLayout(false);
            this.panelTitlSales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlSales;
        private System.Windows.Forms.Label labelSales;
    }
}
