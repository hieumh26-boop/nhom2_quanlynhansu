using Microsoft.Data.SqlClient; 
using System;
using System.Data;
using System.Windows.Forms;

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
        }

        
        private void btdn_Click(object sender, EventArgs e)
        {
            string tdn = txtdn.Text.Trim();
            string mk = txtmk.Text.Trim();
            

            if (string.IsNullOrWhiteSpace(tdn) || string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlNguoiDung = @"
                SELECT nv.MaNhanVien, nv.HoTen, nv.SDT, nv.CCCD, nv.STK, 
                       nv.HinhThucLamViec, nv.MaCoSo, nv.MaVaiTro, nv.NgaySinh, nv.GioiTinh 
                FROM dbo.NhanVien nv 
                INNER JOIN dbo.NguoiDung nd ON nv.MaNhanVien = nd.MaNhanVien 
                WHERE nd.TenDangNhap = @tdn AND nd.MatKhau = @mk";
            

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    kn.Open();
                    using (SqlCommand lenh = new SqlCommand(sqlNguoiDung, kn))
                     
                    {
                        lenh.Parameters.Add("@tdn", SqlDbType.VarChar, 50).Value = tdn;
                        lenh.Parameters.Add("@mk", SqlDbType.NVarChar, 100).Value = mk;
                        
                        using (SqlDataReader doc = lenh.ExecuteReader())
                        {
                            if (doc.Read())
                            {
                                
                                PhienDangNhap.MaNhanVien = doc["MaNhanVien"] != DBNull.Value ? Convert.ToInt32(doc["MaNhanVien"]) : 0;
                                PhienDangNhap.HoTen = doc["HoTen"] != DBNull.Value ? doc["HoTen"].ToString() : "";
                                PhienDangNhap.SDT = doc["SDT"] != DBNull.Value ? doc["SDT"].ToString() : "";
                                PhienDangNhap.CCCD = doc["CCCD"] != DBNull.Value ? doc["CCCD"].ToString() : "";
                                PhienDangNhap.STK = doc["STK"] != DBNull.Value ? doc["STK"].ToString() : "";
                                PhienDangNhap.HinhThucLamViec = doc["HinhThucLamViec"] != DBNull.Value ? doc["HinhThucLamViec"].ToString() : "";
                                PhienDangNhap.MaCoSo = doc["MaCoSo"] != DBNull.Value ? Convert.ToInt32(doc["MaCoSo"]) : 0;

                                if (doc["NgaySinh"] != DBNull.Value)
                                {
                                    PhienDangNhap.NgaySinh = Convert.ToDateTime(doc["NgaySinh"]);
                                }

                                
                                PhienDangNhap.GioiTinh = doc["GioiTinh"] != DBNull.Value ? doc["GioiTinh"].ToString() : "";
                                PhienDangNhap.VaiTro = doc["MaVaiTro"] != DBNull.Value ? doc["MaVaiTro"].ToString() : "";

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        private void btttk_Click(object sender, EventArgs e)
        {
            Formtaotaikhoancs formttk = new Formtaotaikhoancs();
            this.Hide();            
            formttk.ShowDialog();  
            this.Show();           
        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}