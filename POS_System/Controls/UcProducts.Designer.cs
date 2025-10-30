namespace POS_System.Controls
{
    partial class panelProducts
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
            this.panelProduct = new System.Windows.Forms.Panel();
            this.labelProduct = new System.Windows.Forms.Label();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.White;
            this.panelProduct.Controls.Add(this.labelProduct);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProduct.Location = new System.Drawing.Point(0, 0);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1095, 23);
            this.panelProduct.TabIndex = 0;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(0, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(102, 20);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "📦  Products";
            // 
            // panelProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panelProduct);
            this.Name = "panelProducts";
            this.Size = new System.Drawing.Size(1095, 861);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label labelProduct;
    }
}
