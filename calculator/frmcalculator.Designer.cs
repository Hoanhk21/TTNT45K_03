
namespace Myapp
{
    partial class frmcalculator
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.SystemColors.Info;
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(281, 160);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(190, 34);
            this.txtKQ.TabIndex = 2;
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(114, 82);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(191, 22);
            this.txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(433, 82);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(200, 22);
            this.txtSo2.TabIndex = 1;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(65, 258);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(120, 64);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(269, 258);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(110, 67);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(453, 257);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(113, 67);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(626, 255);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(120, 70);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.txtKQ);
            this.Name = "frmcalculator";
            this.Text = "frmcalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmcalculator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

