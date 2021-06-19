using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGD_sua_chua_thiet_bi
{
    public partial class frmQLGD : Form
    {
        public frmQLGD()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNHAN_VIEN nhan = new frmNHAN_VIEN();
            nhan.MdiParent = this;
            nhan.Show();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKHACH_HANG khach = new frmKHACH_HANG();
            khach.MdiParent = this;
            khach.Show();
        }

        private void thêmMớiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSUA_CHUA sua = new frmSUA_CHUA();
            sua.MdiParent = this;
            sua.Show();
        }

        private void frmQLGD_Load(object sender, EventArgs e)
        {

        }

        private void tkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTHONG_KE thong = new frmTHONG_KE();
            thong.MdiParent = this;
            thong.Show();
        }

        private void qlgdsuachuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSUA_CHUA sua = new frmSUA_CHUA();
            sua.MdiParent = this;
            sua.Show();
        }

        private void quanlynvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNHAN_VIEN nhan = new frmNHAN_VIEN();
            nhan.MdiParent = this;
            nhan.Show();
        }

        private void quanlykhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKHACH_HANG khach = new frmKHACH_HANG();
            khach.MdiParent = this;
            khach.Show();
        }
    }
}
