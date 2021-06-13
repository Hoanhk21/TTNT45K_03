
namespace My_calculator
{
    partial class Frmcaculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcaculator));
            this.btncong = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnchia = new System.Windows.Forms.Button();
            this.lbpheptinh = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncong
            // 
            this.btncong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncong.Location = new System.Drawing.Point(52, 97);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(60, 23);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = false;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhan.Location = new System.Drawing.Point(188, 97);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(55, 23);
            this.btnnhan.TabIndex = 5;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = false;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btntru
            // 
            this.btntru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntru.Location = new System.Drawing.Point(118, 97);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(54, 23);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = false;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // txt01
            // 
            this.txt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt01.Location = new System.Drawing.Point(93, 56);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(91, 20);
            this.txt01.TabIndex = 0;
            // 
            // txt02
            // 
            this.txt02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt02.Location = new System.Drawing.Point(190, 56);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(93, 20);
            this.txt02.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKQ.Location = new System.Drawing.Point(104, 144);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(157, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // btnchia
            // 
            this.btnchia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchia.Location = new System.Drawing.Point(253, 97);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(54, 23);
            this.btnchia.TabIndex = 6;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = false;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // lbpheptinh
            // 
            this.lbpheptinh.AutoSize = true;
            this.lbpheptinh.ForeColor = System.Drawing.Color.Teal;
            this.lbpheptinh.Location = new System.Drawing.Point(5, 56);
            this.lbpheptinh.Name = "lbpheptinh";
            this.lbpheptinh.Size = new System.Drawing.Size(82, 13);
            this.lbpheptinh.TabIndex = 7;
            this.lbpheptinh.Text = "Nhập phép tính";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbketqua.ForeColor = System.Drawing.Color.Teal;
            this.lbketqua.Location = new System.Drawing.Point(34, 151);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(44, 13);
            this.lbketqua.TabIndex = 8;
            this.lbketqua.Text = "Kết quả";
            // 
            // Frmcaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 212);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbpheptinh);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btncong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcaculator";
            this.Text = "Frmcaculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Label lbpheptinh;
        private System.Windows.Forms.Label lbketqua;
    }
}

