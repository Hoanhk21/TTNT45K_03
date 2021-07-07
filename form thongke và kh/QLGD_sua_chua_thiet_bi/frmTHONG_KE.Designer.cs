
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
            this.ddenngay = new System.Windows.Forms.DateTimePicker();
            this.dtungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthongke = new System.Windows.Forms.Button();
            this.rbhuysc = new System.Windows.Forms.RadioButton();
            this.rbdangsua = new System.Windows.Forms.RadioButton();
            this.rbsuaxong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến Ngày";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ddenngay
            // 
            this.ddenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ddenngay.Location = new System.Drawing.Point(662, 79);
            this.ddenngay.Margin = new System.Windows.Forms.Padding(2);
            this.ddenngay.Name = "ddenngay";
            this.ddenngay.Size = new System.Drawing.Size(126, 26);
            this.ddenngay.TabIndex = 3;
            this.ddenngay.UseWaitCursor = true;
            this.ddenngay.Value = new System.DateTime(2021, 6, 17, 0, 2, 20, 0);
            this.ddenngay.ValueChanged += new System.EventHandler(this.dateTimePicker2);
            // 
            // dtungay
            // 
            this.dtungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtungay.Location = new System.Drawing.Point(257, 85);
            this.dtungay.Margin = new System.Windows.Forms.Padding(2);
            this.dtungay.Name = "dtungay";
            this.dtungay.Size = new System.Drawing.Size(126, 26);
            this.dtungay.TabIndex = 4;
            this.dtungay.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            this.dtungay.ValueChanged += new System.EventHandler(this.Datetimepicker1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnthongke.ForeColor = System.Drawing.Color.Black;
            this.btnthongke.Location = new System.Drawing.Point(470, 243);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(126, 44);
            this.btnthongke.TabIndex = 11;
            this.btnthongke.Text = "THỐNG KÊ";
            this.btnthongke.UseVisualStyleBackColor = false;
            this.btnthongke.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbhuysc
            // 
            this.rbhuysc.AutoSize = true;
            this.rbhuysc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbhuysc.Location = new System.Drawing.Point(629, 181);
            this.rbhuysc.Name = "rbhuysc";
            this.rbhuysc.Size = new System.Drawing.Size(136, 24);
            this.rbhuysc.TabIndex = 13;
            this.rbhuysc.TabStop = true;
            this.rbhuysc.Text = "Hủy sửa chữa";
            this.rbhuysc.UseVisualStyleBackColor = true;
            // 
            // rbdangsua
            // 
            this.rbdangsua.AutoSize = true;
            this.rbdangsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbdangsua.Location = new System.Drawing.Point(343, 181);
            this.rbdangsua.Name = "rbdangsua";
            this.rbdangsua.Size = new System.Drawing.Size(104, 24);
            this.rbdangsua.TabIndex = 14;
            this.rbdangsua.TabStop = true;
            this.rbdangsua.Text = "Đang sửa";
            this.rbdangsua.UseVisualStyleBackColor = true;
            // 
            // rbsuaxong
            // 
            this.rbsuaxong.AutoSize = true;
            this.rbsuaxong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbsuaxong.Location = new System.Drawing.Point(470, 181);
            this.rbsuaxong.Name = "rbsuaxong";
            this.rbsuaxong.Size = new System.Drawing.Size(106, 24);
            this.rbsuaxong.TabIndex = 15;
            this.rbsuaxong.TabStop = true;
            this.rbsuaxong.Text = "Sửa Xong";
            this.rbsuaxong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(196, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doanh thu";
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.AutoSize = true;
            this.lbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbtrangthai.Location = new System.Drawing.Point(206, 180);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(96, 24);
            this.lbtrangthai.TabIndex = 18;
            this.lbtrangthai.Text = "trạng thái";
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(452, 343);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(162, 20);
            this.txtdoanhthu.TabIndex = 19;
            // 
            // frmTHONG_KE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(999, 468);
            this.Controls.Add(this.txtdoanhthu);
            this.Controls.Add(this.lbtrangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbsuaxong);
            this.Controls.Add(this.rbdangsua);
            this.Controls.Add(this.rbhuysc);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtungay);
            this.Controls.Add(this.ddenngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DateTimePicker ddenngay;
        private System.Windows.Forms.DateTimePicker dtungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.RadioButton rbhuysc;
        private System.Windows.Forms.RadioButton rbdangsua;
        private System.Windows.Forms.RadioButton rbsuaxong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.TextBox txtdoanhthu;
    }
}