namespace SMS
{
    partial class GUI_Menu
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
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.qLSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuManage,
            this.mnuSearch,
            this.mnuPrint});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuClose});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(57, 20);
            this.mnuSystem.Text = "System";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(152, 22);
            this.mnuLogin.Text = "Log in";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(152, 22);
            this.mnuLogout.Text = "Log out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(152, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNV,
            this.mnuHoSoNV,
            this.qLSảnPhẩmToolStripMenuItem,
            this.qLLoạiSảnPhẩmToolStripMenuItem});
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(62, 20);
            this.mnuManage.Text = "Manage";
            // 
            // mnuNV
            // 
            this.mnuNV.Name = "mnuNV";
            this.mnuNV.Size = new System.Drawing.Size(152, 22);
            this.mnuNV.Text = "NhanVien";
            this.mnuNV.Click += new System.EventHandler(this.mnuNV_Click);
            // 
            // mnuHoSoNV
            // 
            this.mnuHoSoNV.Name = "mnuHoSoNV";
            this.mnuHoSoNV.Size = new System.Drawing.Size(152, 22);
            this.mnuHoSoNV.Text = "HoSoNV";
            this.mnuHoSoNV.Click += new System.EventHandler(this.mnuHoSoNV_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchNV});
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(54, 20);
            this.mnuSearch.Text = "Search";
            // 
            // mnuSearchNV
            // 
            this.mnuSearchNV.Name = "mnuSearchNV";
            this.mnuSearchNV.Size = new System.Drawing.Size(152, 22);
            this.mnuSearchNV.Text = "NhanVien";
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(44, 20);
            this.mnuPrint.Text = "Print";
            // 
            // qLSảnPhẩmToolStripMenuItem
            // 
            this.qLSảnPhẩmToolStripMenuItem.Name = "qLSảnPhẩmToolStripMenuItem";
            this.qLSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.qLSảnPhẩmToolStripMenuItem.Text = "QL Sản Phẩm";
            this.qLSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.qLSảnPhẩmToolStripMenuItem_Click);
            // 
            // qLLoạiSảnPhẩmToolStripMenuItem
            // 
            this.qLLoạiSảnPhẩmToolStripMenuItem.Name = "qLLoạiSảnPhẩmToolStripMenuItem";
            this.qLLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.qLLoạiSảnPhẩmToolStripMenuItem.Text = "QL Loại Sản Phẩm";
            // 
            // GUI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GUI_Menu";
            this.Text = "GUI_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.GUI_Menu_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuNV;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSoNV;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchNV;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem qLSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLLoạiSảnPhẩmToolStripMenuItem;
    }
}