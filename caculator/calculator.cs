using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_calculator
{
    public partial class Frmcaculator : Form
    {
        public Frmcaculator()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            string Sso1 = txt01.Text;
            decimal dso1 = Convert.ToDecimal(Sso1);
            string Sso2 = txt02.Text;
            decimal dso2 = Convert.ToDecimal(Sso2);
            decimal dKQ = dso1 + dso2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            string Sso1 = txt01.Text;
            decimal dso1 = Convert.ToDecimal(Sso1);
            string Sso2 = txt02.Text;
            decimal dso2 = Convert.ToDecimal(Sso2);
            decimal dKQ = dso1 - dso2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            string Sso1 = txt01.Text;
            decimal dso1 = Convert.ToDecimal(Sso1);
            string Sso2 = txt02.Text;
            decimal dso2 = Convert.ToDecimal(Sso2);
            decimal dKQ = dso1 * dso2;
            txtKQ.Text = dKQ.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            string Sso1 = txt01.Text;
            decimal dso1 = Convert.ToDecimal(Sso1);
            string Sso2 = txt02.Text;
            decimal dso2 = Convert.ToDecimal(Sso2);
            decimal dKQ = dso1 / dso2;
            txtKQ.Text = dKQ.ToString();
        }
    }
}
