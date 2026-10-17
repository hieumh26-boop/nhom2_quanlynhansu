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
            // Các thông tin được phép chỉnh sửa
            txtHoTen.ReadOnly = khoa;
            txtSDT.ReadOnly = khoa;
            txtCCCD.ReadOnly = khoa;
            txtSoTaiKhoan.ReadOnly = khoa;

            dtpNgaySinh.Enabled = !khoa;
            rdoNam.Enabled = !khoa;
            rdoNu.Enabled = !khoa;
            rdoFullTime.Enabled = !khoa;
            rdoPartTime.Enabled = !khoa;

            // Các thông tin chỉ được xem, không được sửa
            txtMaNV.ReadOnly = true;
            tbvt.ReadOnly = true;
            txtMaCoSo.ReadOnly = true;
        }

        // Lấy thông tin nhân viên từ SQL
        private void LoadNhanVien(string maNV)
        {
            string sql = @"
                SELECT MaNhanVien, HoTen, SDT, CCCD, STK,
                       HinhThucLamViec, MaCoSo, TenVaiTro,
                       NgaySinh, GioiTinh
                FROM dbo.NhanVien
                WHERE MaNhanVien = @MaNV";

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
                            txtMaCoSo.Text = reader["MaCoSo"] != DBNull.Value ? reader["MaCoSo"].ToString() : "";
                            tbvt.Text = reader["TenVaiTro"] != DBNull.Value ? reader["TenVaiTro"].ToString() : "";

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
                            MessageBox.Show("Không tìm thấy nhân viên có mã " + maNV);
                            return;
                        }
                    }
                }

                // Nạp lương của nhân viên
                LoadBangLuong(maNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lấy dữ liệu từ bảng BangLuong
        private void LoadBangLuong(string maNV)
        {
            string sql = @"
                SELECT MaPhieuLuong,
                       [Luong/Thang],
                       TienThuong,
                       TongTienPhat
                FROM dbo.BangLuong
                WHERE MaNhanVien = @MaNV";

            try
            {
                using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                using (SqlCommand cmd = new SqlCommand(sql, kn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = int.Parse(maNV);

                    kn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvLichLamViec.Rows.Clear();

                        while (reader.Read())
                        {
                            dgvLichLamViec.Rows.Add(
                                reader["MaPhieuLuong"],
                                reader["Luong/Thang"],
                                reader["TienThuong"],
                                reader["TongTienPhat"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải bảng lương: " + ex.Message);
            }
        }

        // Cấu hình bảng bên phải để hiển thị lương
        private void CauHinhBangLuong()
        {
            dgvLichLamViec.Columns.Clear();

            dgvLichLamViec.Columns.Add("MaPhieuLuong", "Mã phiếu lương");
            dgvLichLamViec.Columns.Add("LuongThang", "Lương/tháng");
            dgvLichLamViec.Columns.Add("TienThuong", "Tiền thưởng");
            dgvLichLamViec.Columns.Add("TongTienPhat", "Tổng tiền phạt");

            dgvLichLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichLamViec.AllowUserToAddRows = false;
            dgvLichLamViec.ReadOnly = true;
            dgvLichLamViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Nút Toggle CheckBox Chỉnh sửa
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

        // Nút Lưu thay đổi
        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            if (!int.TryParse(txtMaNV.Text, out int maNV))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên!");
                return;
            }

            if (!int.TryParse(txtMaCoSo.Text, out int maCoSo))
            {
                MessageBox.Show("Mã cơ sở phải là số nguyên!");
                txtMaCoSo.Focus();
                return;
            }

            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (!rdoFullTime.Checked && !rdoPartTime.Checked)
            {
                MessageBox.Show("Vui lòng chọn hình thức làm việc!");
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
                    TenVaiTro = @TenVaiTro,
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
                        MessageBox.Show("Lưu thay đổi thành công!");
                        cbcs2.Checked = false; // Tắt nút chỉnh sửa -> tự động khóa lại
                        LoadNhanVien(maNV.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để cập nhật!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu SQL: " + ex.Message);
            }
        }

        // Nút Xem bảng lương
        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Chưa có mã nhân viên!");
                return;
            }

            LoadBangLuong(txtMaNV.Text.Trim());
        }

        // Nút Xem phiếu lương chi tiết
        private void btnXemPhieuLuong_Click(object sender, EventArgs e)
        {
            if (dgvLichLamViec.CurrentRow == null || dgvLichLamViec.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn một phiếu lương!");
                return;
            }

            DataGridViewRow row = dgvLichLamViec.CurrentRow;

            MessageBox.Show(
                "Mã nhân viên: " + txtMaNV.Text +
                "\nHọ tên: " + txtHoTen.Text +
                "\nMã phiếu lương: " + row.Cells["MaPhieuLuong"].Value +
                "\nLương/tháng: " + row.Cells["LuongThang"].Value +
                "\nTiền thưởng: " + row.Cells["TienThuong"].Value +
                "\nTổng tiền phạt: " + row.Cells["TongTienPhat"].Value,
                "Chi tiết phiếu lương");
        }

        private void formquanlyhoso_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;

                if (btnLuu != null) btnLuu.Visible = false;

                CauHinhBangLuong();
                KhoaThongTin(true);

                // Nạp đúng mã nhân viên đang đăng nhập
                if (PhienDangNhap.MaNhanVien > 0)
                {
                    LoadNhanVien(PhienDangNhap.MaNhanVien.ToString());
                }

                // Gán an toàn dữ liệu từ phiên đăng nhập
                txtMaNV.Text = PhienDangNhap.MaNhanVien > 0 ? PhienDangNhap.MaNhanVien.ToString() : "";
                txtHoTen.Text = PhienDangNhap.HoTen ?? "";
                tbvt.Text = PhienDangNhap.VaiTro ?? "";
                txtCCCD.Text = PhienDangNhap.CCCD ?? "";
                txtSDT.Text = PhienDangNhap.SDT ?? "";
                txtSoTaiKhoan.Text = PhienDangNhap.STK ?? "";
                txtMaCoSo.Text = PhienDangNhap.MaCoSo > 0 ? PhienDangNhap.MaCoSo.ToString() : "";

                if (PhienDangNhap.NgaySinh != DateTime.MinValue)
                {
                    dtpNgaySinh.Value = PhienDangNhap.NgaySinh;
                }

                if (!string.IsNullOrEmpty(PhienDangNhap.GioiTinh))
                {
                    rdoNam.Checked = PhienDangNhap.GioiTinh.Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase);
                    rdoNu.Checked = !rdoNam.Checked;
                }

                if (!string.IsNullOrEmpty(PhienDangNhap.HinhThucLamViec))
                {
                    rdoFullTime.Checked = PhienDangNhap.HinhThucLamViec.Trim().Equals("Full-time", StringComparison.OrdinalIgnoreCase) || PhienDangNhap.HinhThucLamViec.Trim().Equals("fulltime", StringComparison.OrdinalIgnoreCase);
                    rdoPartTime.Checked = !rdoFullTime.Checked;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị hồ sơ: " + ex.Message);
            }
        }
    }
}