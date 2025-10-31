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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHelloAdmin = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.tableLayoutPanelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Silver;
            this.panelSidebar.Controls.Add(this.tableLayoutPanelSidebar);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(149, 620);
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
            this.tableLayoutPanelSidebar.Location = new System.Drawing.Point(0, 83);
            this.tableLayoutPanelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelSidebar.Name = "tableLayoutPanelSidebar";
            this.tableLayoutPanelSidebar.RowCount = 7;
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34679F));
            this.tableLayoutPanelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91926F));
            this.tableLayoutPanelSidebar.Size = new System.Drawing.Size(149, 436);
            this.tableLayoutPanelSidebar.TabIndex = 1;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.Location = new System.Drawing.Point(2, 372);
            this.labelLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(145, 64);
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
            this.labelSettings.Location = new System.Drawing.Point(2, 310);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(145, 62);
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
            this.labelReports.Location = new System.Drawing.Point(2, 248);
            this.labelReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReports.Name = "labelReports";
            this.labelReports.Size = new System.Drawing.Size(145, 62);
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
            this.labelCustomers.Location = new System.Drawing.Point(2, 186);
            this.labelCustomers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(145, 62);
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
            this.labelProducts.Location = new System.Drawing.Point(2, 124);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(145, 62);
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
            this.labelSales.Location = new System.Drawing.Point(2, 62);
            this.labelSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(145, 62);
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
            this.labelDashboard.Location = new System.Drawing.Point(2, 0);
            this.labelDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(145, 62);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "🏠  Dashboard";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(149, 83);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.labelHelloAdmin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(149, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(796, 83);
            this.panelTop.TabIndex = 1;
            // 
            // labelHelloAdmin
            // 
            this.labelHelloAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelHelloAdmin.AutoSize = true;
            this.labelHelloAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelHelloAdmin.ForeColor = System.Drawing.Color.White;
            this.labelHelloAdmin.Location = new System.Drawing.Point(666, 28);
            this.labelHelloAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelloAdmin.Name = "labelHelloAdmin";
            this.labelHelloAdmin.Size = new System.Drawing.Size(119, 24);
            this.labelHelloAdmin.TabIndex = 0;
            this.labelHelloAdmin.Text = "Hello, Admin";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(149, 83);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(796, 537);
            this.panelContent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::POS_System.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControlForm";
            this.panelSidebar.ResumeLayout(false);
            this.tableLayoutPanelSidebar.ResumeLayout(false);
            this.tableLayoutPanelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelHelloAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSidebar;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label labelReports;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}