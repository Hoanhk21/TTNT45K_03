
namespace QLGD_sua_chua_thiet_bi
{
    partial class frmKHACH_HANG
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.DTkhachhang = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtimkiem = new System.Windows.Forms.TextBox();
            this.rbco = new System.Windows.Forms.RadioButton();
            this.rbKhong = new System.Windows.Forms.RadioButton();
            this.btnreset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(554, 70);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 20);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtmaKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "SĐT Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách hàng thân thiết:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(548, 307);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 69);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(548, 407);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(110, 72);
            this.btnCapnhat.TabIndex = 8;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SpringGreen;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(708, 307);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 69);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // DTkhachhang
            // 
            this.DTkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTkhachhang.Location = new System.Drawing.Point(2, 115);
            this.DTkhachhang.Margin = new System.Windows.Forms.Padding(2);
            this.DTkhachhang.Name = "DTkhachhang";
            this.DTkhachhang.RowHeadersWidth = 51;
            this.DTkhachhang.RowTemplate.Height = 24;
            this.DTkhachhang.Size = new System.Drawing.Size(395, 405);
            this.DTkhachhang.TabIndex = 9;
            this.DTkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(19, 57);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(89, 31);
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(554, 122);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 18;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(554, 159);
            this.txtDC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(236, 20);
            this.txtDC.TabIndex = 19;
            // 
            // txtimkiem
            // 
            this.txtimkiem.Location = new System.Drawing.Point(119, 65);
            this.txtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtimkiem.Name = "txtimkiem";
            this.txtimkiem.Size = new System.Drawing.Size(218, 20);
            this.txtimkiem.TabIndex = 20;
            this.txtimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // rbco
            // 
            this.rbco.AutoSize = true;
            this.rbco.Location = new System.Drawing.Point(573, 237);
            this.rbco.Name = "rbco";
            this.rbco.Size = new System.Drawing.Size(38, 17);
            this.rbco.TabIndex = 21;
            this.rbco.TabStop = true;
            this.rbco.Text = "Có";
            this.rbco.UseVisualStyleBackColor = true;
            this.rbco.CheckedChanged += new System.EventHandler(this.rdco_CheckedChanged);
            // 
            // rbKhong
            // 
            this.rbKhong.AutoSize = true;
            this.rbKhong.Location = new System.Drawing.Point(705, 238);
            this.rbKhong.Name = "rbKhong";
            this.rbKhong.Size = new System.Drawing.Size(56, 17);
            this.rbKhong.TabIndex = 22;
            this.rbKhong.TabStop = true;
            this.rbKhong.Text = "Không";
            this.rbKhong.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Lime;
            this.btnreset.BackgroundImage = global::QLGD_sua_chua_thiet_bi.Properties.Resources.images2;
            this.btnreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreset.Location = new System.Drawing.Point(814, 79);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(79, 64);
            this.btnreset.TabIndex = 23;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmKHACH_HANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.rbKhong);
            this.Controls.Add(this.rbco);
            this.Controls.Add(this.txtimkiem);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.DTkhachhang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKHACH_HANG";
            this.Text = "frmKHACH_HANG";
            this.Load += new System.EventHandler(this.frmKHACH_HANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView DTkhachhang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtimkiem;
        private System.Windows.Forms.RadioButton rbco;
        private System.Windows.Forms.RadioButton rbKhong;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button button1;
    }
}

