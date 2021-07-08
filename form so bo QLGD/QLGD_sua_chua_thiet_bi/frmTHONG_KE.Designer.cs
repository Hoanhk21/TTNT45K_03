
namespace QLGD_sua_chua_thiet_bi
{
    partial class frmTHONG_KE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdsuaxong = new System.Windows.Forms.RadioButton();
            this.rddangsua = new System.Windows.Forms.RadioButton();
            this.rdhuysua = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(855, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến Ngày";
            // 
            // dtdenngay
            // 
            this.dtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdenngay.Location = new System.Drawing.Point(1057, 133);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(156, 30);
            this.dtdenngay.TabIndex = 3;
            this.dtdenngay.UseWaitCursor = true;
            this.dtdenngay.Value = new System.DateTime(2021, 6, 17, 0, 2, 20, 0);
            this.dtdenngay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dttungay
            // 
            this.dttungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttungay.Location = new System.Drawing.Point(295, 135);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(167, 30);
            this.dttungay.TabIndex = 4;
            this.dttungay.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1244, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Lime;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Location = new System.Drawing.Point(851, 530);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(159, 67);
            this.btnThongke.TabIndex = 8;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = " Trạng Thái";
            // 
            // rdsuaxong
            // 
            this.rdsuaxong.AutoSize = true;
            this.rdsuaxong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsuaxong.Location = new System.Drawing.Point(401, 393);
            this.rdsuaxong.Name = "rdsuaxong";
            this.rdsuaxong.Size = new System.Drawing.Size(125, 29);
            this.rdsuaxong.TabIndex = 10;
            this.rdsuaxong.TabStop = true;
            this.rdsuaxong.Text = "Sửa xong";
            this.rdsuaxong.UseVisualStyleBackColor = true;
            // 
            // rddangsua
            // 
            this.rddangsua.AutoSize = true;
            this.rddangsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rddangsua.Location = new System.Drawing.Point(619, 391);
            this.rddangsua.Name = "rddangsua";
            this.rddangsua.Size = new System.Drawing.Size(125, 29);
            this.rddangsua.TabIndex = 11;
            this.rddangsua.TabStop = true;
            this.rddangsua.Text = "Đang sửa";
            this.rddangsua.UseVisualStyleBackColor = true;
            // 
            // rdhuysua
            // 
            this.rdhuysua.AutoSize = true;
            this.rdhuysua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdhuysua.Location = new System.Drawing.Point(898, 387);
            this.rdhuysua.Name = "rdhuysua";
            this.rdhuysua.Size = new System.Drawing.Size(112, 29);
            this.rdhuysua.TabIndex = 12;
            this.rdhuysua.TabStop = true;
            this.rdhuysua.Text = "Hủy sửa";
            this.rdhuysua.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Doanh Thu";
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.ForeColor = System.Drawing.Color.Red;
            this.txttk.Location = new System.Drawing.Point(531, 563);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(180, 34);
            this.txttk.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Lime;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(1092, 546);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(97, 51);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // frmTHONG_KE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1437, 771);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdhuysua);
            this.Controls.Add(this.rddangsua);
            this.Controls.Add(this.rdsuaxong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dttungay);
            this.Controls.Add(this.dtdenngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTHONG_KE";
            this.Text = "frmTHONG_KE";
            this.Load += new System.EventHandler(this.frmTHONG_KE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.DateTimePicker dttungay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdsuaxong;
        private System.Windows.Forms.RadioButton rddangsua;
        private System.Windows.Forms.RadioButton rdhuysua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btnreset;
    }
}