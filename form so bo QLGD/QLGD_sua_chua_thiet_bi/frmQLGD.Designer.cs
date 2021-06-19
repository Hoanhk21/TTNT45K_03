
namespace QLGD_sua_chua_thiet_bi
{
    partial class frmQLGD
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
            this.quanlykhachhangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlynvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qlgdsuachuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlykhachhangToolStripMenuItem,
            this.quanlynvToolStripMenuItem,
            this.qlgdsuachuaToolStripMenuItem,
            this.tkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlykhachhangToolStripMenuItem
            // 
            this.quanlykhachhangToolStripMenuItem.Name = "quanlykhachhangToolStripMenuItem";
            this.quanlykhachhangToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.quanlykhachhangToolStripMenuItem.Text = "Quản lý khách hàng ";
            this.quanlykhachhangToolStripMenuItem.Click += new System.EventHandler(this.quanlykhachhangToolStripMenuItem_Click);
            // 
            // quanlynvToolStripMenuItem
            // 
            this.quanlynvToolStripMenuItem.Name = "quanlynvToolStripMenuItem";
            this.quanlynvToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.quanlynvToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quanlynvToolStripMenuItem.Click += new System.EventHandler(this.quanlynvToolStripMenuItem_Click);
            // 
            // qlgdsuachuaToolStripMenuItem
            // 
            this.qlgdsuachuaToolStripMenuItem.Name = "qlgdsuachuaToolStripMenuItem";
            this.qlgdsuachuaToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.qlgdsuachuaToolStripMenuItem.Text = "Quản lý giao dịch sửa chữa";
            this.qlgdsuachuaToolStripMenuItem.Click += new System.EventHandler(this.qlgdsuachuaToolStripMenuItem_Click);
            // 
            // tkToolStripMenuItem
            // 
            this.tkToolStripMenuItem.Name = "tkToolStripMenuItem";
            this.tkToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.tkToolStripMenuItem.Text = "Thống kê";
            this.tkToolStripMenuItem.Click += new System.EventHandler(this.tkToolStripMenuItem_Click);
            // 
            // frmQLGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 547);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLGD";
            this.Text = "frmQLGD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLGD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlykhachhangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlynvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qlgdsuachuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tkToolStripMenuItem;
    }
}