using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormQLHS : Form
    {
        public FormQLHS()
        {
            InitializeComponent();
        }

        private void KhoaThongTin(bool khoa)
        {

            txtHoTen.ReadOnly = khoa;
            txtSDT.ReadOnly = khoa;
            txtCCCD.ReadOnly = khoa;
            txtSoTaiKhoan.ReadOnly = khoa;

            dtpNgaySinh.Enabled = !khoa;
            rdoNam.Enabled = !khoa;
            rdoNu.Enabled = !khoa;
            rdoFullTime.Enabled = !khoa;
            rdoPartTime.Enabled = !khoa;


            txtMaNV.ReadOnly = true;
            tbvt.ReadOnly = true;
            tbcsdl.ReadOnly = true;
            cbmcs.Enabled = false;
        }


        private void LoadNhanVien(string maNV)
        {
            string sql = @"
                SELECT nv.MaNhanVien, nv.HoTen, nv.SDT, nv.CCCD, nv.STK,
                       nv.HinhThucLamViec, nv.MaCoSo, nv.MaVaiTro, pq.TenVaiTro,
                       nv.NgaySinh, nv.GioiTinh, cs.TenCoSo
                FROM dbo.NhanVien nv
                INNER JOIN dbo.CoSo cs ON nv.MaCoSo = cs.MaCoSo
                INNER JOIN PhanQuyen pq ON nv.MaVaiTro = pq.MaVaiTro
                WHERE nv.MaNhanVien = @MaNV";

            try
            {
                using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                using (SqlCommand cmd = new SqlCommand(sql, kn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = int.Parse(maNV);

                    kn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaNV.Text = reader["MaNhanVien"] != DBNull.Value ? reader["MaNhanVien"].ToString() : "";
                            txtHoTen.Text = reader["HoTen"] != DBNull.Value ? reader["HoTen"].ToString() : "";
                            txtSDT.Text = reader["SDT"] != DBNull.Value ? reader["SDT"].ToString() : "";
                            txtCCCD.Text = reader["CCCD"] != DBNull.Value ? reader["CCCD"].ToString() : "";
                            txtSoTaiKhoan.Text = reader["STK"] != DBNull.Value ? reader["STK"].ToString() : "";
                            cbmcs.Text = reader["MaCoSo"] != DBNull.Value ? reader["MaCoSo"].ToString() : "";
                            tbvt.Text = reader["TenVaiTro"] != DBNull.Value ? reader["TenVaiTro"].ToString() : "";
                            tbcsdl.Text = reader["TenCoSo"] != DBNull.Value ? reader["TenCoSo"].ToString() : "";

                            if (reader["NgaySinh"] != DBNull.Value)
                            {
                                dtpNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                            }

                            string hinhThuc = reader["HinhThucLamViec"] != DBNull.Value ? reader["HinhThucLamViec"].ToString() : "";
                            rdoFullTime.Checked = hinhThuc.Equals("Full-time", StringComparison.OrdinalIgnoreCase) || hinhThuc.Equals("fulltime", StringComparison.OrdinalIgnoreCase);
                            rdoPartTime.Checked = hinhThuc.Equals("Part-time", StringComparison.OrdinalIgnoreCase) || hinhThuc.Equals("parttime", StringComparison.OrdinalIgnoreCase);

                            string gioiTinh = reader["GioiTinh"] != DBNull.Value ? reader["GioiTinh"].ToString() : "";
                            rdoNam.Checked = gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase) || gioiTinh == "1";
                            rdoNu.Checked = gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase) || gioiTinh.Equals("Nu", StringComparison.OrdinalIgnoreCase) || gioiTinh == "0";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên có mã " + maNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    } 
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /
        private void cbcs2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcs2.Checked)
            {
                KhoaThongTin(false);
                btnLuu.Visible = true;
                cbcs2.Text = "Hủy chỉnh sửa";
            }
            else
            {
                KhoaThongTin(true);
                btnLuu.Visible = false;
                cbcs2.Text = "Chỉnh sửa";
            }
        }

       
        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cbmcs.Text, out int maCoSo))
            {
                MessageBox.Show("Mã cơ sở phải là số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbmcs.Focus();
                return;
            }

            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdoFullTime.Checked && !rdoPartTime.Checked)
            {
                MessageBox.Show("Vui lòng chọn hình thức làm việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            string hinhThuc = rdoFullTime.Checked ? "Full-time" : "Part-time";

            string sql = @"
                UPDATE dbo.NhanVien
                SET HoTen = @HoTen,
                    SDT = @SDT,
                    CCCD = @CCCD,
                    STK = @STK,
                    HinhThucLamViec = @HinhThuc,
                    MaCoSo = @MaCoSo,
                    
                    NgaySinh = @NgaySinh,
                    GioiTinh = @GioiTinh
                WHERE MaNhanVien = @MaNV";

            try
            {
                using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                using (SqlCommand cmd = new SqlCommand(sql, kn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = txtHoTen.Text.Trim();
                    cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 20).Value = txtSDT.Text.Trim();
                    cmd.Parameters.Add("@CCCD", SqlDbType.NVarChar, 20).Value = txtCCCD.Text.Trim();
                    cmd.Parameters.Add("@STK", SqlDbType.NVarChar, 50).Value = txtSoTaiKhoan.Text.Trim();
                    cmd.Parameters.Add("@HinhThuc", SqlDbType.NVarChar, 30).Value = hinhThuc;
                    cmd.Parameters.Add("@MaCoSo", SqlDbType.Int).Value = maCoSo;
                    cmd.Parameters.Add("@TenVaiTro", SqlDbType.NVarChar, 100).Value = tbvt.Text.Trim();
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value.Date;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value = gioiTinh;

                    kn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbcs2.Checked = false; // Tắt nút chỉnh sửa -> tự động khóa lại
                        LoadNhanVien(maNV.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    


        

 


        private void FormQLHS_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                if (btnLuu != null) btnLuu.Visible = false;


                KhoaThongTin(true);

               
                if (PhienDangNhap.MaNhanVien > 0)
                {
                    LoadNhanVien(PhienDangNhap.MaNhanVien.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hồ sơ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}