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
    public partial class frmKHACH_HANG : Form
    {
        public frmKHACH_HANG()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtmaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKH.Text;
            string sTen = txtTen.Text;
            string sDC = txtDC.Text;
            string skhthan = txtKHthanthiet.Text;
            MessageBox.Show("Bạn vừa nhập mã khách hàng là:" + sMaKH,
                             "Ban vua nhap Ho va Ten KH la:" + sTen);


        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
