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
    public partial class frmTHONG_KE : Form
    {
        String sCon = "Data source= MAYTINH-SAB2R8I;Initial Catalog=QLGD_suachua;Integrated Security=True";
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
            string sQuery = "Select * from SUA_CHUA";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "suachua");
           con.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
               string sQuery1 = "select TrangThai, sum(TongTien)as TongTien from SUA_CHUA where NgayNhan between @NgayNhan and @NgayTra group by TrangThai";

               
                

                String sNgayNhan = dtungay.Value.ToString("yyyy-MM-dd");
                String sNgayTra = ddenngay.Value.ToString("yyyy-MM-dd");
                string sTrangthai;

                if (rbdangsua.Checked == true)
                {
                    sTrangthai = "Đang sửa";
                }
                if (rbsuaxong.Checked == true)
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
               
               
                dt.value.tostring = txtdoanhthu.Text;













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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void dateTimePicker2(object sender, EventArgs e)
        {

        }

        private void Datetimepicker1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
