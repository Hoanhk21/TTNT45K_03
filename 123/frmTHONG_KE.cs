using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                                        //Done
using System.Data.SqlClient; // buoc 0
namespace QLGD_sua_chua_thiet_bi
{
    public partial class frmTHONG_KE : Form
    {
        String sCon = "Data Source=LAPTOP-83S7CNV8\\SQLEXPRESS;Initial Catalog = QLGD_suachua; Integrated Security = True";
        public frmTHONG_KE()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmTHONG_KE_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu!!");
            }
            string sQuery = "Select TongTien from SUA_CHUA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SUA_CHUA");


            con.Close();


        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            try
            {
                string sQuery1 = "select TrangThai, sum(TongTien)as TongTien from SUA_CHUA " +
                    "where  NgayNhan between @NgayNhan and @NgayTra" + txttk.SelectedText.ToString() + " group by TrangThai";




                String sNgayNhan = dttungay.Value.ToString("yyyy-MM-dd");
                String sNgayTra = dtdenngay.Value.ToString("yyyy-MM-dd");
                string sTrangthai;

                if (rddangsua.Checked == true)
                {
                    sTrangthai = "Đang sửa";
                }
                if (rdsuaxong.Checked == true)
                {
                    sTrangthai = "Sửa Xong";
                }
                else
                {
                    sTrangthai = "Hủy sửa chữa";
                }


                SqlCommand cmd = new SqlCommand(sQuery1, con);
                cmd.Parameters.AddWithValue("@NgayNhan", sNgayNhan);
                cmd.Parameters.AddWithValue("@NgayTra", sNgayTra);
                cmd.Parameters.AddWithValue("@TrangThai", sTrangthai);


                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                txttk.Text = dt.Rows[0][1].ToString();//hiển thị tổng tiền lên fỏm

            }



            catch (Exception ex)
            {
                MessageBox.Show("Thống kê không thành công!\n" + ex.Message, "Thông báo!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
        }
    }
}