namespace POS_System.Controls
{
    partial class UcDashboard
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
            this.panelTitlDashboard = new System.Windows.Forms.Panel();
            this.labelTiltlforDashboard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitlDashboard
            // 
            this.panelTitlDashboard.BackColor = System.Drawing.Color.White;
            this.panelTitlDashboard.Controls.Add(this.labelTiltlforDashboard);
            this.panelTitlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelTitlDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitlDashboard.Name = "panelTitlDashboard";
            this.panelTitlDashboard.Size = new System.Drawing.Size(1095, 23);
            this.panelTitlDashboard.TabIndex = 0;
            // 
            // labelTiltlforDashboard
            // 
            this.labelTiltlforDashboard.AutoSize = true;
            this.labelTiltlforDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTiltlforDashboard.Location = new System.Drawing.Point(0, 0);
            this.labelTiltlforDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTiltlforDashboard.Name = "labelTiltlforDashboard";
            this.labelTiltlforDashboard.Size = new System.Drawing.Size(117, 20);
            this.labelTiltlforDashboard.TabIndex = 0;
            this.labelTiltlforDashboard.Text = "🏠  Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 226);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Total Customer";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total Sale";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Order";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTitlDashboard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(1095, 861);
            this.panelTitlDashboard.ResumeLayout(false);
            this.panelTitlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlDashboard;
        private System.Windows.Forms.Label labelTiltlforDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
