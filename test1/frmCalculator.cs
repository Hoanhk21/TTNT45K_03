using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            string SSO1 = txt1.Text;
            decimal dSO1 = Convert.ToDecimal(SSO1);
            string SSO2 = txt2.Text;
            decimal dSO2 = Convert.ToDecimal(SSO2);
            decimal dKQ = dSO1 + dSO2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            string SSO1 = txt1.Text;
            decimal dSO1 = Convert.ToDecimal(SSO1);
            string SSO2 = txt2.Text;
            decimal dSO2 = Convert.ToDecimal(SSO2);
            decimal dKQ = dSO1 - dSO2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            string SSO1 = txt1.Text;
            decimal dSO1 = Convert.ToDecimal(SSO1);
            string SSO2 = txt2.Text;
            decimal dSO2 = Convert.ToDecimal(SSO2);
            decimal dKQ = dSO1 * dSO2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            string SSO1 = txt1.Text;
            decimal dSO1 = Convert.ToDecimal(SSO1);
            string SSO2 = txt2.Text;
            decimal dSO2 = Convert.ToDecimal(SSO2);
            decimal dKQ = dSO1 / dSO2;
            txtKQ.Text = dKQ.ToString();
        }
    }
}
