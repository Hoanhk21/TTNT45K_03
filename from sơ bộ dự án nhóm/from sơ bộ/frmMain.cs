using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from_sơ_bộ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmnhanvien nhan = new frmnhanvien();
            nhan.MdiParent = this;
            nhan.Show();
        }

        private void thêmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmhang Hang= new frmhang();
            Hang.MdiParent = this;
            Hang.Show();

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang khach = new frmkhachhang();
            khach.MdiParent = this;
            khach.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
