namespace POS_System.Controls
{
    partial class UcReports
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
            this.panelReport = new System.Windows.Forms.Panel();
            this.labelreport = new System.Windows.Forms.Label();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.White;
            this.panelReport.Controls.Add(this.labelreport);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1095, 23);
            this.panelReport.TabIndex = 0;
            // 
            // labelreport
            // 
            this.labelreport.AutoSize = true;
            this.labelreport.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreport.Location = new System.Drawing.Point(0, 0);
            this.labelreport.Name = "labelreport";
            this.labelreport.Size = new System.Drawing.Size(94, 20);
            this.labelreport.TabIndex = 0;
            this.labelreport.Text = "📊  Reports";
            // 
            // UcReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelReport);
            this.Name = "UcReports";
            this.Size = new System.Drawing.Size(1095, 861);
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label labelreport;
    }
}
