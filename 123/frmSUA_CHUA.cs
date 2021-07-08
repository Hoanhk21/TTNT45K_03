using System;
using System.Data;
using System.Data.SqlClient; // buoc 0
using System.Windows.Forms;
namespace QLGD_sua_chua_thiet_bi
{
    public partial class frmSUA_CHUA : Form
    {
        string sCon = "Data Source=LAPTOP-83S7CNV8\\SQLEXPRESS;Initial Catalog=QLGD_suachua;Integrated Security=True";
        public frmSUA_CHUA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmSUA_CHUA_Load(object sender, EventArgs e)
        {
            //khi mới mở form thì mặc định sẽ là nhập mới dữ liệu --> không hiển thị gì trong gridview
            //cần phải làm các việc sau:
            //1. Load ma khach hang vào combobox
            //2. Load mã nhân viên vào combobox mã nhân viên
            //3. load mã công việc và combobox mã công việc
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
           catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            // buoc 2: lay du lieu ve
           
            //o buoc nay lay du lieu ve do vao combo box MaKH, MaNV//Hoan thanh
            string sQuery1 = "select MaKH,TenKH from KHACH_HANG";
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "KH");
            cbMaKH.DataSource = ds1.Tables["KH"];
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.DisplayMember = "TenKH";

            string sQuery2 = "select MaNV,TenNV from NHAN_VIEN";
            SqlDataAdapter adapter2 = new SqlDataAdapter(sQuery2, con);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "NV");
            cbMaNV.DataSource = ds2.Tables["NV"];
            cbMaNV.ValueMember = "MaNV";
            cbMaNV.DisplayMember = "TenNV";


            //viet them code fill ten cong viec vao cboMaCV, tuong tu 2 cai tren//Hoan thanh
            string sQuery3 = "select MaCV,NoiDung from CONG_VIEC";
            SqlDataAdapter adapter3 = new SqlDataAdapter(sQuery3, con);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3, "CV");
            cbMaCV.DataSource = ds3.Tables["CV"];
            cbMaCV.ValueMember = "MaCV";
            cbMaCV.DisplayMember = "NoiDung";

            //cần phải lấy dữ liệu (MaHD trong bảng SUA CHUA) để đổ vào combobox Tìm kiếm
            string sQuery4 = "select MaHD from SUA_CHUA";
            SqlDataAdapter adapter4 = new SqlDataAdapter(sQuery4, con);
            DataSet ds4 = new DataSet();
            adapter4.Fill(ds4, "HD");
            cbTimkiem.DataSource = ds4.Tables["HD"];
            cbTimkiem.ValueMember = "MaHD";
            cbTimkiem.DisplayMember = "MaHD";
            con.Close(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*\
             Công việc cần làm:
            1. lấy dữ liệu của phần hóa đơn (mã hóa đơn, ngày nhận, giờ nhận, mã khách, mã nv, tổng tiền ở trên form) --> insert vào bảng SUA_CHUA
            2. Lấy từng dòng trong gridview + mã hóa đơn --> insert vào bảng SUA_CHUA_CHITIET --> cái này khó để sau khi làm xong hết những 
                phần kia cô sẽ hướng dẫn em viết cái này
             
             */
            //MessageBox.Show(cbMaKH.SelectedValue.ToString());

            //buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            //Them vao bang SUA_CHUA
            int iMaHD = Convert.ToInt32(txtMaHD.Text);
            string sMaKH = cbMaKH.SelectedValue.ToString();
            string sMaNV = cbMaNV.SelectedValue.ToString();
            string sNgaynhan = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string sGionhan = dateTimePicker1.Value.ToString("HH:mm:ss");
            string sNgaytra = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string sGiotra = dateTimePicker3.Value.ToString("HH:mm:ss");
            String sTongtien = txtTongtien.Text; //dang lay gia tri sai//xong
            string sTrangthai; //dang lay gia tri sai//xong
            if (rbDangsua.Checked == true)
            {
                sTrangthai = "Đang sửa"; //gia tri dua vao CSDL khong hien thi TV co dau --> xem lai  kieu du lieu//Hoan thanh
            }
            else if (rbDaxong.Checked == true)
            {
                sTrangthai = "Xong";
            }
            else
            {
                sTrangthai = "Hủy";
            }
            string sQuery = "insert into SUA_CHUA(MaHD,MaKH,MaNV,Gionhan,Ngaynhan,TrangThai,TongTien) values " +
                "(@MaHD,@MaKh,@MaNV,@GioNhan,@NgayNhan,@TrangThai,@TongTien)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", iMaHD);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@MaNV", sMaNV);
            cmd.Parameters.AddWithValue("@GioNhan", sGionhan);
            cmd.Parameters.AddWithValue("@NgayNhan", sNgaynhan);
            cmd.Parameters.AddWithValue("@TrangThai", sTrangthai);
            cmd.Parameters.AddWithValue("@TongTien", sTongtien);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            //Them giu lieu vao bang SUA_CHUA_CHI_TIET
            int iCount = dgSCCT.Rows.Count;
            for (int i = 0; i < iCount-1; i++)
            {
                string sQuery1 = "insert into SUA_CHUA_CHI_TIET(MaHD, MaCV, SoLuong, ThanhTien) values (@MaHD,@MaCV,@SoLuong,@ThanhTien)"; 
                SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                cmd1.Parameters.AddWithValue("@MaHD", iMaHD);
                cmd1.Parameters.AddWithValue("@MaCV", dgSCCT.Rows[i].Cells[0].Value);
                cmd1.Parameters.AddWithValue("@SoLuong", dgSCCT.Rows[i].Cells[3].Value);
                cmd1.Parameters.AddWithValue("@ThanhTien", dgSCCT.Rows[i].Cells[4].Value);
                try
                {
                    cmd1.ExecuteNonQuery();
                    //Messagebox.Show("Them moi thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            MessageBox.Show("Xử lý xong!");
            con.Close();//Buoc 3
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   txtMaHD.Text= dgSCCT.Rows[e.RowIndex].Cells ["MaHD"].Value.ToString();
            cbMaKH.Text = dgSCCT.Rows[e.RowIndex].Cells["MaKH"].Value.ToString(); 
            cbMaNV.Text = dgSCCT.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            txtTongtien.Text= dgSCCT.Rows[e.RowIndex].Cells["Tongtien"].Value.ToString();
            dateTimePicker2.Value =
                Convert.ToDateTime(dgSCCT.Rows[e.RowIndex].Cells["Ngaynhan"].Value.ToString());
            dateTimePicker1.Value =
                Convert.ToDateTime(dgSCCT.Rows[e.RowIndex].Cells["Gionhan"].Value.ToString());
            dateTimePicker4.Value =
                Convert.ToDateTime(dgSCCT.Rows[e.RowIndex].Cells["Ngaytra"].Value.ToString());
            dateTimePicker3.Value =
                Convert.ToDateTime(dgSCCT.Rows[e.RowIndex].Cells["Giotra"].Value.ToString());
            string sTrangthai =
               dgSCCT.Rows[e.RowIndex].Cells["Trangthai"].Value.ToString();
            if (sTrangthai == "Đang sửa")
            {
                rbDangsua.Checked = true;
            }
            if (sTrangthai == "Đã xong")
            {
                rbDaxong.Checked = true;
            }
            else
            {
                rbHuy.Checked = true;
            }
            txtThanhtien.Text =
           dgSCCT.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            cbMaKH.Enabled = false;
            cbMaNV.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắn chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
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

                //phần này xóa sửa chữa chi tiêt --> Dùng vòng lặp
                int iCount = dgSCCT.Rows.Count;
                for (int i = 0; i < iCount - 1; i++)
                {
                    //lấy mã công việc từ gridview
                    string sMaCV = dgSCCT.Rows[i].Cells[0].Value.ToString(); //cô ko chắc nó ở ô nào, em xem lại code                                       //viết lệnh sql 
                    string sQuery1 = "delete SUA_CHUA_CHI_TIET where Mahd=@MaHD and MaCV=@MaCV";
                    SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                    //add parameter
                    cmd1.Parameters.AddWithValue("@MaCV", dgSCCT.Rows[i].Cells[0].Value);
                    cmd1.Parameters.AddWithValue("@MaHD", txtMaHD.Text);


                    try
                    {
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
                //phần này xóa sửa chữa
                string sMaHD = txtMaHD.Text;
                string sQuery = "delete SUA_CHUA where mahd=@MaDH ";  
                SqlCommand cmd = new SqlCommand(sQuery, con);     
                cmd.Parameters.AddWithValue("@MaDH", sMaHD);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

             
                //đưa ra thông báo: xóa thánh công
                MessageBox.Show("Xóa thành công!"); 
                con.Close();

                //xóa đã ok
                //sau khi xóa xong cần clear màn hình
                txtMaHD.Text = "";
                cbMaCV.Text = "";
                cbMaKH.Text = "";
                cbMaNV.Text = "";
                txtSL.Text = "";
                txtThanhtien.Text = "";
                txtTongtien.Text = "";
                txtGia.Text = "";
                dgSCCT.Rows.Clear();
                //em tự add thêm những thứ khác nữa
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
  
            //để cho đơn giản, cô nghĩ nên xử lý thế này cho nhẹ nhàng: hóa đơn này chỉ cho sửa trạng thái và giờ trả, ngày trả thôi
            //để cho sửa các mục khác sợ 1 tuần nữa em code ko xong :D
             SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }

            //lấy ra ngày trả, giờ trả và trạng thái 
            string sMaHD = txtMaHD.Text;
            string sNgaytra = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string sGiotra = dateTimePicker3.Value.ToString("HH:mm:ss");
            string sTrangthai; 
            if (rbDangsua.Checked == true)
            {
                sTrangthai = "Đang sửa";
            }
            else if (rbDaxong.Checked == true)
            {
                sTrangthai = "Xong";
            }
            else
            {
                sTrangthai = "Hủy";
            }
            string sQuery = "update SUA_CHUA set ngaytra=@ngaytra, giotra = @giotra, trangthai = @trangthai where mahd = @mahd";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            //còn chưa khai báo các biên @ngaytra, @giotra, @trangthai, @mahd cho lệnh
            cmd.Parameters.AddWithValue("@maHD", sMaHD);
            cmd.Parameters.AddWithValue("@ngaytra", sNgaytra);
            cmd.Parameters.AddWithValue("@giotra", sGiotra);
            cmd.Parameters.AddWithValue("@trangthai", sTrangthai);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật!");
            }
            con.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             *Cong viec can lam:
             *1. select du lieu tu bang sua_chua voi dieu kien mahd = ma hoa don vua chon tren o tim kiem
             *2. hien thi du lieu len cac muc: ma hoa don, makhach, manv, tong tien, ngay nhan, gio nhan, ngay tra, gio tra,...
             *3. khong cho nguoi dung sua ma hoa don --> .Enable = false
             *4. select du lieu tu bang sua_chua_chi_tiet voi dieu kien mahd = ma hoa don vua chon tren o tim kiem
             *5. hien thi du lieu vua tìm duoc len datagridview
             */
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            string sQuery = "Select * from SUA_CHUA where MaHD=" + cbTimkiem.SelectedValue.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "giaodich");
            txtMaHD.Text = ds.Tables["giaodich"].Rows[0][0].ToString();
            cbMaKH.Text = ds.Tables["giaodich"].Rows[0][1].ToString();
            cbMaNV.Text = ds.Tables["giaodich"].Rows[0][2].ToString();
           // txtMaHD.Text = ds.Tables["giaodich"].Rows[0][3].ToString();
            try
            {
                dateTimePicker2.Text = ds.Tables["giaodich"].Rows[0][4].ToString();
                dateTimePicker1.Text = ds.Tables["giaodich"].Rows[0][3].ToString();
                dateTimePicker4.Text = ds.Tables["giaodich"].Rows[0][5].ToString();
                dateTimePicker3.Text = ds.Tables["giaodich"].Rows[0][6].ToString();
            }
            catch (Exception ex) { }

            if (ds.Tables["giaodich"].Rows[0][7].ToString() == "Đang sửa")
            {
                rbDangsua.Checked = true;
            }
            else if (ds.Tables["giaodich"].Rows[0][7].ToString() == "Xong")
            {
                rbDaxong.Checked = true;
            }
            else
            {
                rbHuy.Checked = true;
            }
            txtTongtien.Text = ds.Tables["giaodich"].Rows[0][8].ToString();
            txtMaHD.Enabled = false;
            string sQuery1 = "Select CONG_VIEC.MaCV, NoiDung, Cong_Viec.ThanhTien, SoLuong, SUA_CHUA_CHI_TIET.ThanhTien from SUA_CHUA_CHI_TIET join CONG_VIEC  on SUA_CHUA_CHI_TIET.MaCV = CONG_VIEC.MaCV  where MaHD = " + cbTimkiem.SelectedValue.ToString();
            SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1, "giaodichchitiet");

            int iCount = ds1.Tables[0].Rows.Count;
            for (int i=0; i < iCount; i++)
            {
                dgSCCT.Rows.Add(ds1.Tables[0].Rows[i][0], ds1.Tables[0].Rows[i][1], ds1.Tables[0].Rows[i][2], ds1.Tables[0].Rows[i][3], ds1.Tables[0].Rows[i][4]);
            }    

            //để người dùng ko sửa được các mục khác ngày, giờ trả và trạng thái thì ở đây cần phải disable các item khác đi, ví dụ:
            txtMaHD.Enabled = false;
            cbMaKH.Enabled = false;
            cbMaNV.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtTongtien.Enabled = false;
            dgSCCT.Enabled = false;
            //tương tự với các control khác
            con.Close();
        }

        private void txtMaNV_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)


        { 
    }

        private void cbNoidung_Click(object sender, EventArgs e)
        {

        }

        private void cbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            //Buoc 1: Lay don hang tu co so du lieu
          SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            // Buoc 2 - Lay du lieu ve
            //cau lenh sai -> can phai lay ve gia cua cong viec --> lay trong bang congviec//Hoan thanh
            try
            {
                string sQuery1 = "select ThanhTien from Cong_viec where MaCV =" + cbMaCV.SelectedValue.ToString();
                SqlDataAdapter adapter1 = new SqlDataAdapter(sQuery1, con);
                DataSet ds1 = new DataSet();
                adapter1.Fill(ds1, "CV");
                txtGia.Text = ds1.Tables["CV"].Rows[0][0].ToString();
            }
            catch(Exception ex)
            { }
            

            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //sau khi nguoi dung nhập số lượng --> tinh thanh tiền = so luong * don gia rồi hiển thị trên ô thành tiền
            try
            {
                int iSoluong = Convert.ToInt32(txtSL.Text);
                int iGia = Convert.ToInt32(txtGia.Text);
                int iThanhtien = iSoluong * iGia;
                txtThanhtien.Text = iThanhtien.ToString();
                //thêm mới 1 dòng vào gridview
                dgSCCT.Rows.Add(cbMaCV.SelectedValue, cbMaCV.Text, iGia, iSoluong, iThanhtien);
                //tính tổng tiền của hóa đơn: tổng tiên = tổng tiền cũ + thành tiền
                int iTongtien;
                if (txtTongtien.Text == "")
                    iTongtien = 0;
                else
                    iTongtien = Convert.ToInt32(txtTongtien.Text);

                iTongtien = iTongtien + iThanhtien;
                txtTongtien.Text = iTongtien.ToString();
                
            }
            catch(Exception ex)
            { }
            
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            //buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối dữ liệu");
            }
            //Them vao bang SUA_CHUA
            int iMaHD = Convert.ToInt32(txtMaHD.Text);
            string sMaKH = cbMaKH.SelectedValue.ToString();
            string sMaNV = cbMaNV.SelectedValue.ToString();
            string sNgaynhan = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string sGionhan = dateTimePicker1.Value.ToString("HH:mm:ss");
            string sNgaytra = dateTimePicker4.Value.ToString("yyyy-MM-dd");
            string sGiotra = dateTimePicker3.Value.ToString("HH:mm:ss");
            String sTongtien = txtTongtien.Text;
            string sTrangthai;
            if (rbDangsua.Checked == true)
            {
                sTrangthai = "Đang sửa";
            }
            if (rbDaxong.Checked == true)
            {
                sTrangthai = "Xong";
            }
            else
            {
                sTrangthai = "Hủy";
            }
            string sQuery = "insert into SUA_CHUA(MaHD,MaKH,MaNV,Gionhan,Ngaynhan,Ngaytra,Giotra,TrangThai,TongTien) values " +
                "(@MaHD,@MaKh,@MaNV,@Gionhan,@NgayNhan,@NgayTra,@GioTra,@TrangThai,@TongTien)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaHD", iMaHD);
            cmd.Parameters.AddWithValue("@MaKH", sMaKH);
            cmd.Parameters.AddWithValue("@Gionhan", sGionhan);
            cmd.Parameters.AddWithValue("@Ngaynhan", sNgaynhan);
            cmd.Parameters.AddWithValue("@Ngaytra", sNgaytra);
            cmd.Parameters.AddWithValue("@Giotra", sGiotra);
            cmd.Parameters.AddWithValue("@Tongtien", sTongtien);
            cmd.Parameters.AddWithValue("@Trangthai", sTrangthai);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //Them giu lieu vao bang SUA_CHUA_CHI_TIET
            int iCount = dgSCCT.Rows.Count;
            for (int i=0; i<iCount; i++)
            {
                string sQuery1 = "insert into SUA_CHUA_CHI_TIET values (@MaHD,@MaCV,@Soluong,@Thanhtien)";
                SqlCommand cmd1 = new SqlCommand(sQuery1, con);
                cmd1.Parameters.AddWithValue("@MaHD", iMaHD);
                cmd1.Parameters.AddWithValue("@MaCV", dgSCCT.Rows[i].Cells[0].Value);
                cmd1.Parameters.AddWithValue("@Soluong", dgSCCT.Rows[i].Cells[3].Value);
                cmd1.Parameters.AddWithValue("@Thanhtien", dgSCCT.Rows[i].Cells[4].Value);
                try
                {
                    cmd1.ExecuteNonQuery();
                    //Messagebox.Show("Them moi thanh cong!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            MessageBox.Show("Sử lý xong!");
            con.Close();//Buoc 3

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
