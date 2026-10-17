using System.Data.SqlClient;
using System;
using Microsoft.Data.SqlClient;
namespace nhom2_quanlynhansu
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }
        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbmk.Checked)
            {
                txtmk.PasswordChar = '\0';
                cbmk.Image = Properties.Resources.matmo;
            }
            else
            {
                txtmk.PasswordChar = '*';
                cbmk.Image = Properties.Resources.mătdong;
            }
            {
            }
        }
        private void btdn_Click(object sender, EventArgs e)
        {
             //string csdl_nguoidung = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @tdn AND MatKhau = @mak";// truy van SQL để kiểm tra thông tin đăng nhập
            string NguoiDung = "SELECT nv.MaNhanVien,nv.HoTen, nv.SDT,nv.CCCD, nv.STK, nv.HinhThucLamViec, nv.MaCoSo, nv.TenVaiTro, nv.NgaySinh, nv.GioiTinh FROM NhanVien nv INNER JOIN NguoiDung nd ON nv.MaNhanVien = nd.MaNhanVien WHERE nd.TenDangNhap = @tdn AND nd.MatKhau = @mk ";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                try
                {

                    kn.Open();
                    SqlCommand lenh = new SqlCommand(NguoiDung, kn);
                    string tdn = txtdn.Text.Trim();
                    string mk = txtmk.Text.Trim();
                    if (String.IsNullOrWhiteSpace(txtdn.Text) || String.IsNullOrWhiteSpace(txtmk.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhậpp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        
                        lenh.Parameters.AddWithValue("@tdn", tdn);
                        lenh.Parameters.AddWithValue("@mk", mk);
                        SqlDataReader doc = lenh.ExecuteReader();// thuc thi bien "lenh"

                        if (doc.Read() )//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
                        {
                            PhienDangNhap.MaNhanVien = Convert.ToInt32(doc["MaNhanVien"]);
                            PhienDangNhap.HoTen = Convert.ToString(doc["HoTen"])??"";
                            PhienDangNhap.SDT = Convert.ToString(doc["SDT"]) ?? "";
                            PhienDangNhap.CCCD = Convert.ToString(doc["CCCD"]) ?? "";
                            PhienDangNhap.STK = Convert.ToString(doc["STK"]) ?? "";
                            PhienDangNhap.HinhThucLamViec = Convert.ToString(doc["HinhThucLamViec"]) ?? "";
                            PhienDangNhap.MaCoSo = Convert.ToInt32(doc["MaCoSo"]);
                            PhienDangNhap.NgaySinh = Convert.ToDateTime(doc["NgaySinh"]);
                            PhienDangNhap.GioiTinh = Convert.ToString(doc["GioiTinh"]) ?? "";
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {

                }
        }
        private void btttk_Click(object sender, EventArgs e)
        {

            Formtaotaikhoancs formttk = new Formtaotaikhoancs();
            this.Hide();
            formttk.ShowDialog();
            
        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
        }
    }
}



