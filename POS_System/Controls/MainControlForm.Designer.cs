namespace POS_System.Controls
{
    partial class MainControlForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.labelLogout = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelReports = new System.Windows.Forms.Label();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHelloAdmin = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.tableLayoutPanelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Silver;
            this.panelSidebar.Controls.Add(this.tableLayoutPanelSidebar);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(199, 763);
            this.panelSidebar.TabIndex = 0;
            // 
            // tableLayoutPanelSidebar
            // 
            this.tableLayoutPanelSidebar.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanelSidebar.ColumnCount = 1;
            this.tableLayoutPanelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSidebar.Controls.Add(this.labelLogout, 0, 6);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelSettings, 0, 5);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelReports, 0, 4);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelCustomers, 0, 3);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelProducts, 0, 2);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelSales, 0, 1);
            this.tableLayoutPanelSidebar.Controls.Add(this.labelDashboard, 0, 0);
            this.tableLayoutPanelSidebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelSidebar.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanelSidebar.Name = "tableLayoutPanelSidebar";
            this.tableLayoutPanelSidebar.RowCount = 7;
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91926F));
            this.tableLayoutPanelSidebar.Size = new System.Drawing.Size(199, 537);
            this.tableLayoutPanelSidebar.TabIndex = 1;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(3, 462);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(193, 75);
            this.labelLogout.TabIndex = 6;
            this.labelLogout.Text = "🔓  Logout";
            this.labelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.Location = new System.Drawing.Point(3, 385);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(193, 77);
            this.labelSettings.TabIndex = 5;
            this.labelSettings.Text = "⚙️  Settings";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            // 
            // labelReports
            // 
            this.labelReports.AutoSize = true;
            this.labelReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReports.Location = new System.Drawing.Point(3, 308);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(193, 77);
            this.labelReports.TabIndex = 4;
            this.labelReports.Text = "📊  Reports";
            this.labelReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelReports.Click += new System.EventHandler(this.labelReports_Click);
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.Location = new System.Drawing.Point(3, 231);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(193, 77);
            this.labelCustomers.TabIndex = 3;
            this.labelCustomers.Text = "👥  Customers";
            this.labelCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCustomers.Click += new System.EventHandler(this.labelCustomers_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(3, 154);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(193, 77);
            this.labelProducts.TabIndex = 2;
            this.labelProducts.Text = "📦  Products";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProducts.Click += new System.EventHandler(this.labelProducts_Click);
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(3, 77);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(193, 77);
            this.labelSales.TabIndex = 1;
            this.labelSales.Text = "💰  Sales";
            this.labelSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSales.Click += new System.EventHandler(this.labelSales_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(3, 0);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(193, 77);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "🏠  Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(74, 39);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(38, 16);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Logo";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.labelHelloAdmin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(199, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1061, 102);
            this.panelTop.TabIndex = 1;
            // 
            // labelHelloAdmin
            // 
            this.labelHelloAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHelloAdmin.AutoSize = true;
            this.labelHelloAdmin.Location = new System.Drawing.Point(79, 56);
            this.labelHelloAdmin.Name = "labelHelloAdmin";
            this.labelHelloAdmin.Size = new System.Drawing.Size(83, 16);
            this.labelHelloAdmin.TabIndex = 0;
            this.labelHelloAdmin.Text = "Hello, Admin";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(199, 102);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1061, 661);
            this.panelContent.TabIndex = 2;
            // 
            // MainControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 763);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Name = "MainControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControlForm";
            this.panelSidebar.ResumeLayout(false);
            this.tableLayoutPanelSidebar.ResumeLayout(false);
            this.tableLayoutPanelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelHelloAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSidebar;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelSettings;
    }
}