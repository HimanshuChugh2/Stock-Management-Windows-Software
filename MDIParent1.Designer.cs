namespace Stock_management
{
    partial class MDIParent1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEESALEBYDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLSALEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEEBYDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jUSTSHOEMEALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addedTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1326, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.menuToolStripMenuItem.Text = "Add";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.addedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEESALEBYDATEToolStripMenuItem,
            this.aLLSALEToolStripMenuItem,
            this.todaysSaleToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saleToolStripMenuItem.Text = "SALE";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // sEESALEBYDATEToolStripMenuItem
            // 
            this.sEESALEBYDATEToolStripMenuItem.Name = "sEESALEBYDATEToolStripMenuItem";
            this.sEESALEBYDATEToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.sEESALEBYDATEToolStripMenuItem.Text = "SEE SALE BY DATE";
            this.sEESALEBYDATEToolStripMenuItem.Click += new System.EventHandler(this.sEESALEBYDATEToolStripMenuItem_Click);
            // 
            // aLLSALEToolStripMenuItem
            // 
            this.aLLSALEToolStripMenuItem.Name = "aLLSALEToolStripMenuItem";
            this.aLLSALEToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.aLLSALEToolStripMenuItem.Text = "JUST SHOW ME ALL";
            this.aLLSALEToolStripMenuItem.Click += new System.EventHandler(this.aLLSALEToolStripMenuItem_Click);
            // 
            // todaysSaleToolStripMenuItem
            // 
            this.todaysSaleToolStripMenuItem.Name = "todaysSaleToolStripMenuItem";
            this.todaysSaleToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.todaysSaleToolStripMenuItem.Text = "Today\'s Sale";
            this.todaysSaleToolStripMenuItem.Click += new System.EventHandler(this.todaysSaleToolStripMenuItem_Click);
            // 
            // addedToolStripMenuItem
            // 
            this.addedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEEBYDATEToolStripMenuItem,
            this.jUSTSHOEMEALLToolStripMenuItem,
            this.addedTodayToolStripMenuItem});
            this.addedToolStripMenuItem.Name = "addedToolStripMenuItem";
            this.addedToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.addedToolStripMenuItem.Text = "ADDED";
            this.addedToolStripMenuItem.Click += new System.EventHandler(this.addedToolStripMenuItem_Click);
            // 
            // sEEBYDATEToolStripMenuItem
            // 
            this.sEEBYDATEToolStripMenuItem.Name = "sEEBYDATEToolStripMenuItem";
            this.sEEBYDATEToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.sEEBYDATEToolStripMenuItem.Text = "SEE BY DATE";
            this.sEEBYDATEToolStripMenuItem.Click += new System.EventHandler(this.sEEBYDATEToolStripMenuItem_Click);
            // 
            // jUSTSHOEMEALLToolStripMenuItem
            // 
            this.jUSTSHOEMEALLToolStripMenuItem.Name = "jUSTSHOEMEALLToolStripMenuItem";
            this.jUSTSHOEMEALLToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.jUSTSHOEMEALLToolStripMenuItem.Text = "JUST SHOW ME ALL";
            this.jUSTSHOEMEALLToolStripMenuItem.Click += new System.EventHandler(this.jUSTSHOEMEALLToolStripMenuItem_Click);
            // 
            // addedTodayToolStripMenuItem
            // 
            this.addedTodayToolStripMenuItem.Name = "addedTodayToolStripMenuItem";
            this.addedTodayToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.addedTodayToolStripMenuItem.Text = "Added Today";
            this.addedTodayToolStripMenuItem.Click += new System.EventHandler(this.addedTodayToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1326, 631);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEESALEBYDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLSALEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEEBYDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jUSTSHOEMEALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaysSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addedTodayToolStripMenuItem;

    }
}



