
namespace My_App
{
    partial class frmmaytinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmaytinh));
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.btnchia = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncong
            // 
            this.btncong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncong.Location = new System.Drawing.Point(73, 169);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(80, 27);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = false;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntru.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntru.Location = new System.Drawing.Point(150, 169);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(76, 27);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = false;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhan.Location = new System.Drawing.Point(223, 169);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(77, 27);
            this.btnnhan.TabIndex = 5;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = false;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // txt01
            // 
            this.txt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt01.Location = new System.Drawing.Point(95, 98);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(108, 22);
            this.txt01.TabIndex = 0;
            this.txt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtKQ.Location = new System.Drawing.Point(95, 261);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(222, 22);
            this.txtKQ.TabIndex = 4;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // txt02
            // 
            this.txt02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txt02.Location = new System.Drawing.Point(209, 98);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(108, 22);
            this.txt02.TabIndex = 2;
            this.txt02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnchia
            // 
            this.btnchia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnchia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchia.Location = new System.Drawing.Point(296, 169);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(72, 27);
            this.btnchia.TabIndex = 6;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = false;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ForeColor = System.Drawing.Color.Teal;
            this.lb1.Location = new System.Drawing.Point(21, 98);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(50, 15);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Nhập số";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.ForeColor = System.Drawing.Color.Teal;
            this.lb2.Location = new System.Drawing.Point(21, 261);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(47, 15);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "kết quả";
            // 
            // frmmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 304);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmaytinh";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.frmmaytinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
    }
}

