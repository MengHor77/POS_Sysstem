namespace POS_System.Controls
{
    partial class UcCustomers
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
            this.panelTitlCustomer = new System.Windows.Forms.Panel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.panelTitlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitlCustomer
            // 
            this.panelTitlCustomer.BackColor = System.Drawing.Color.White;
            this.panelTitlCustomer.Controls.Add(this.labelCustomer);
            this.panelTitlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelTitlCustomer.Name = "panelTitlCustomer";
            this.panelTitlCustomer.Size = new System.Drawing.Size(920, 24);
            this.panelTitlCustomer.TabIndex = 0;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(0, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(117, 20);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "👥  Customers";
            // 
            // UcCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panelTitlCustomer);
            this.Name = "UcCustomers";
            this.Size = new System.Drawing.Size(920, 605);
            this.panelTitlCustomer.ResumeLayout(false);
            this.panelTitlCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlCustomer;
        private System.Windows.Forms.Label labelCustomer;
    }
}
