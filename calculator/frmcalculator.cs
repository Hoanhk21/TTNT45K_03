using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myapp
{
    public partial class frmcalculator : Form
    {
        public frmcalculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 / dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 - dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            //Lay gia tri so 1
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            //Lay gia tri so 2
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            //KQ
            decimal dKQ = dSo1 + dSo2;
            //Hien ra man hinh
            txtKQ.Text = dKQ.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string sSo1 = txtSo1.Text;
            decimal dSo1 = Convert.ToDecimal(sSo1);
            string sSo2 = txtSo2.Text;
            decimal dSo2 = Convert.ToDecimal(sSo2);
            decimal dKQ = dSo1 * dSo2;
            txtKQ.Text = dKQ.ToString();
        }

        private void frmcalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Cảm ơn, hẹn gặp lại =))", "Thông báo");
        }
    }
}
