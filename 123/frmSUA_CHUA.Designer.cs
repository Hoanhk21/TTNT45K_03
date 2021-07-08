
namespace QLGD_sua_chua_thiet_bi
{
    partial class frmSUA_CHUA
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbDangsua = new System.Windows.Forms.RadioButton();
            this.rbDaxong = new System.Windows.Forms.RadioButton();
            this.rbHuy = new System.Windows.Forms.RadioButton();
            this.dgSCCT = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaCV = new System.Windows.Forms.ComboBox();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSCCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giờ nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(900, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(900, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giờ trả";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Lime;
            this.btnTimkiem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimkiem.Location = new System.Drawing.Point(1005, 11);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(131, 41);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LemonChiffon;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trạng thái";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rbDangsua
            // 
            this.rbDangsua.AutoSize = true;
            this.rbDangsua.Checked = true;
            this.rbDangsua.Location = new System.Drawing.Point(33, 246);
            this.rbDangsua.Name = "rbDangsua";
            this.rbDangsua.Size = new System.Drawing.Size(90, 21);
            this.rbDangsua.TabIndex = 5;
            this.rbDangsua.TabStop = true;
            this.rbDangsua.Text = "Đang sửa";
            this.rbDangsua.UseVisualStyleBackColor = true;
            // 
            // rbDaxong
            // 
            this.rbDaxong.AutoSize = true;
            this.rbDaxong.Location = new System.Drawing.Point(177, 246);
            this.rbDaxong.Name = "rbDaxong";
            this.rbDaxong.Size = new System.Drawing.Size(81, 21);
            this.rbDaxong.TabIndex = 6;
            this.rbDaxong.Text = "Đã xong";
            this.rbDaxong.UseVisualStyleBackColor = true;
            // 
            // rbHuy
            // 
            this.rbHuy.AutoSize = true;
            this.rbHuy.Location = new System.Drawing.Point(309, 246);
            this.rbHuy.Name = "rbHuy";
            this.rbHuy.Size = new System.Drawing.Size(116, 21);
            this.rbHuy.TabIndex = 7;
            this.rbHuy.Text = "Hủy sửa chữa";
            this.rbHuy.UseVisualStyleBackColor = true;
            // 
            // dgSCCT
            // 
            this.dgSCCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSCCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgSCCT.Location = new System.Drawing.Point(33, 421);
            this.dgSCCT.Name = "dgSCCT";
            this.dgSCCT.RowHeadersWidth = 51;
            this.dgSCCT.RowTemplate.Height = 24;
            this.dgSCCT.Size = new System.Drawing.Size(917, 220);
            this.dgSCCT.TabIndex = 15;
            this.dgSCCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgSCCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaCV
            // 
            this.MaCV.HeaderText = "Mã công việc";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.Width = 125;
            // 
            // TenCV
            // 
            this.TenCV.HeaderText = "Tên công việc";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(632, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(1005, 127);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(175, 22);
            this.dateTimePicker3.TabIndex = 12;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(1005, 73);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(175, 22);
<<<<<<< HEAD
            this.dateTimePicker4.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Lime;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1133, 531);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(137, 110);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lime;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1349, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 106);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Lime;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1349, 531);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 104);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1133, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 106);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
=======
            this.dateTimePicker4.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(754, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SpringGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(636, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 41);
            this.button4.TabIndex = 21;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SpringGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(754, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 39);
            this.button5.TabIndex = 22;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SpringGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(636, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 38);
            this.button6.TabIndex = 23;
            this.button6.Text = "Thêm";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
>>>>>>> 0d7e0594863140437e16ca04c547301c5220ae65
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1082, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thành tiền:";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(1205, 324);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(243, 22);
            this.txtThanhtien.TabIndex = 8;
            this.txtThanhtien.TextChanged += new System.EventHandler(this.txtThanhtien_TextChanged);
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.Lime;
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(1122, 659);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(163, 59);
            this.btnInHD.TabIndex = 17;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(489, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(632, 216);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(264, 22);
            this.txtTongtien.TabIndex = 31;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Mã công việc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PeachPuff;
            this.label12.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(470, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 47);
            this.label12.TabIndex = 36;
            this.label12.Text = "HÓA ĐƠN SỬA CHỮA";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106"});
            this.cbMaNV.Location = new System.Drawing.Point(145, 167);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(234, 24);
            this.cbMaNV.TabIndex = 38;
            // 
            // cbMaCV
            // 
            this.cbMaCV.FormattingEnabled = true;
            this.cbMaCV.Items.AddRange(new object[] {
            "11111",
            "11112",
            "11113",
            "11114",
            "11115",
            "11116",
            "11117",
            "11118",
            "11119",
            "11120"});
            this.cbMaCV.Location = new System.Drawing.Point(145, 324);
            this.cbMaCV.Name = "cbMaCV";
            this.cbMaCV.Size = new System.Drawing.Size(234, 24);
            this.cbMaCV.TabIndex = 41;
            this.cbMaCV.SelectedIndexChanged += new System.EventHandler(this.cbMaCV_SelectedIndexChanged);
            this.cbMaCV.SelectionChangeCommitted += new System.EventHandler(this.cbMaCV_SelectedIndexChanged);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "1111",
            "223",
            "1124",
            "1125",
            "1126",
            "1127",
            "1128",
            "1129",
            "1130"});
            this.cbTimkiem.Location = new System.Drawing.Point(1162, 21);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(286, 24);
            this.cbTimkiem.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LemonChiffon;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(145, 58);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(234, 22);
            this.txtMaHD.TabIndex = 43;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Items.AddRange(new object[] {
            "037 4191 656",
            "035 4139 267",
            "097 7474 811",
            "097 3002 948",
            "033 4072 043",
            "097 9562 702",
            "090 5112 345",
            "086 8396 077",
            "039 2901 892",
            "090 5413 710"});
            this.cbMaKH.Location = new System.Drawing.Point(145, 109);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(234, 24);
            this.cbMaKH.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LemonChiffon;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(776, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 22);
            this.label14.TabIndex = 45;
            this.label14.Text = "Số lượng";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(888, 328);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(148, 22);
            this.txtSL.TabIndex = 46;
            this.txtSL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LemonChiffon;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(474, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 22);
            this.label15.TabIndex = 47;
            this.label15.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(542, 328);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(153, 22);
            this.txtGia.TabIndex = 48;
            // 
            // frmSUA_CHUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1840, 919);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.cbMaCV);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgSCCT);
            this.Controls.Add(this.rbHuy);
            this.Controls.Add(this.rbDaxong);
            this.Controls.Add(this.rbDangsua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmSUA_CHUA";
            this.Text = "frmSUA_CHUA";
            this.Load += new System.EventHandler(this.frmSUA_CHUA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSCCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbDangsua;
        private System.Windows.Forms.RadioButton rbDaxong;
        private System.Windows.Forms.RadioButton rbHuy;
        private System.Windows.Forms.DataGridView dgSCCT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaCV;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}