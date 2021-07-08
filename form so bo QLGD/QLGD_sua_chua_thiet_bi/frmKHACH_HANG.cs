using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLGD_sua_chua_thiet_bi
{
    public partial class frmKHACH_HANG : Form
    {
        String sCon = "Data Source=LAPTOP-83S7CNV8\\SQLEXPRESS;Initial Catalog=QLGD_suachua;Integrated Security=True";
        public frmKHACH_HANG()
        {
            InitializeComponent();
        }

        private void frmKHACH_HANG_Load(object sender, EventArgs e)
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
            string sQuery = "Select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
          dataGridView1.DataSource = ds.Tables["KhachHang"];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
            txtDC.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            int ithanthiet = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["THANTHIET"].Value);
            if (ithanthiet == 0)
            {
                rbco.Checked = true;
            }
            else
            {
                rbkhong.Checked = true;
            }
            txtSDT.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
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
            string sQuery = "Select * from KHACH_HANG where TenKH like N'%" + txttimkiem.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "KhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           dataGridView1.DataSource = ds.Tables["KhachHang"];
            con.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }

            try
            {
                string sSDT = txtSDT.Text;
                string sTenKH = txtHoTen.Text;
                string sDiachi = txtDC.Text;
                int ithanthiet = 0;
                if (rbco.Checked == true)
                {
                    ithanthiet = 1;
                }
                 string sQuery = "Insert into KHACH_HANG values(@MaKH, @TenKH, @DiaChi,@THANTHIET)";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaKH", sSDT);
                cmd.Parameters.AddWithValue("@TenKH", sTenKH);

                cmd.Parameters.AddWithValue("@DiaChi", sDiachi);
                cmd.Parameters.AddWithValue("@THANTHIET", ithanthiet);

                 cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công.");
            }
          catch (Exception)
            {
                MessageBox.Show("bạn chưa nhập đủ thông tin.");
            }
            string sQuery2 = "Select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery2, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            con.Close();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn thật sự muốn xóa??", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {//step 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
                }
                try
                {

                    string sSDT = txtSDT.Text;
                    string sQuery = "delete SUA_CHUA where MaKH = @SDT";
                    string sQuery1 = "delete KHACH_HANG where MaKH = @SDT";
                    SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("@SDT", sSDT);
                    cmd1.Parameters.AddWithValue("@SDT", sSDT);
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.");
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Không thể xóa khách hàng này vì có liên kết thông tin khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                txtSDT.Text = "";
                txtHoTen.Text = "";
                txtDC.Text = "";
                rbkhong.Checked = false;
                rbco.Checked = false;
                txtSDT.Enabled = true;

                string sQuery2 = "Select * from KHACH_HANG";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery2, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "KhachHang");
                dataGridView1.DataSource = ds.Tables["KhachHang"];
                con.Close();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            string sSDT = txtSDT.Text;
            string sTen = txtHoTen.Text;
            string sDC = txtDC.Text;
            int ithanthiet = 0;
            if (rbco.Checked == true)
            {
                ithanthiet = 1;
            }

            string sQuery = "update KHACH_HANG set TenKH = @TenKH, DiaChi = @DiaChi, ThanThiet = @Thanthiet where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaKH", sSDT);
            cmd.Parameters.AddWithValue("@TenKH", sTen);
            cmd.Parameters.AddWithValue("@DiaChi", sDC);
            cmd.Parameters.AddWithValue("@THANTHIET", ithanthiet);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật  thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu!!");
            }
            string sQuery1 = "Select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            con.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            string sSDT = txtSDT.Text;
            string sTen = txtHoTen.Text;
            string sDC = txtDC.Text;
            int ithanthiet = 0;
            if (rbco.Checked == true)
            {
                ithanthiet = 1;
            }

            string sQuery = "update KHACH_HANG set TenKH = @TenKH, DiaChi = @DiaChi, ThanThiet = @Thanthiet where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaKH", sSDT);
            cmd.Parameters.AddWithValue("@TenKH", sTen);
            cmd.Parameters.AddWithValue("@DiaChi", sDC);
            cmd.Parameters.AddWithValue("@THANTHIET", ithanthiet);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật  thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thay đổi dữ liệu!!");
            }
            string sQuery1 = "Select * from KHACH_HANG";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang");
          dataGridView1.DataSource = ds.Tables["KhachHang"];
            con.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            txtSDT.Text = "";
            txtHoTen.Text = "";
            txtDC.Text = "";
            rbkhong.Checked = false;
            rbco.Checked = false;
            txtSDT.Enabled = true;
        }
    }
}
