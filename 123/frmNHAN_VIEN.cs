using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGD_sua_chua_thiet_bi
{
    public partial class frmNHAN_VIEN : Form
    {
        string sCon = "Data Source=LAPTOP-83S7CNV8\\SQLEXPRESS;Initial Catalog=QLGD_suachua;Integrated Security=True";
        public frmNHAN_VIEN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            string sMaNV = txtmanv.Text;
            string sTenNV = txttennv.Text;
            string sSoDT = txtsodt.Text;

            string sQuery = "insert into NHAN_VIEN values(@MaNV, @TenNV, @SoDT)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@TenNV", sTenNV);
            cmd.Parameters.AddWithValue("@SoDT", sSoDT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu");
            }
            string sQuery1 = "select * from NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Nhanvien");

            dataGridView1.DataSource = ds.Tables["Nhanvien"];

            con.Close();
        }

        private void frmNHAN_VIEN_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nỗi dữ liệu");
            }
            string sQuery = "select * from NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Nhanvien");

            dataGridView1.DataSource = ds.Tables["Nhanvien"];
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

            string sMaNV = txtmanv.Text;
            string sTenNV = txttennv.Text;
            string sSoDT = txtsodt.Text;

            //Khởi tạo sql command
            string sQuery = "update NHAN_VIEN set TenNV = @TenNV, SoDT = @SoDT where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@TenNV", sTenNV);
            cmd.Parameters.AddWithValue("@SoDT", sSoDT);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay đổi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Xảy ra lỗi trong quá trình thay đổi dữ liệu");
            }
            string sQuery1 = "select * from NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery1, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Nhanvien");
            dataGridView1.DataSource = ds.Tables["Nhanvien"];

            con.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
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
            string snhanvien = txtmanv.Text;

            string sQuery = "delete SUA_CHUA where MaNV = @nhanvien";
            string sQuery1 = "delete NHAN_VIEN where MaNV = @nhanvien";


            SqlCommand cmd = new SqlCommand(sQuery, con);
            SqlCommand cmd1 = new SqlCommand(sQuery1, con);
            cmd.Parameters.AddWithValue("@nhanvien", snhanvien);
            cmd1.Parameters.AddWithValue("@nhanvien", snhanvien);

            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Xảy ra lỗi trong quá trình xóa dữ liệu");
            }

            string sQuery2 = "select * from NHAN_VIEN";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery2, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Nhanvien");

            dataGridView1.DataSource = ds.Tables["Nhanvien"];

            con.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntk_Click(object sender, EventArgs e)
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

            string sQuery = "select * from NHAN_VIEN where TenNV like N'%" + txttk.Text + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "Nhanvien");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Xảy ra lỗi trong quá trình tìm kiếm");
            }
            dataGridView1.DataSource = ds.Tables["Nhanvien"];
            con.Close();
        }

        private void dataGridView1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtmanv.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txtsodt.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
