using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class formcauhinhcalamviec : Form
    {
        public formcauhinhcalamviec()
        {
            InitializeComponent();
        }

        // Tự động load dữ liệu từ SQL lên DataGridView khi mở Form
        private void formcauhinhcalamviec_Load(object sender, EventArgs e)
        {
            txtMaCa.ReadOnly = true; // Khóa ô Mã ca vì MaCa là cột tự tăng trong SQL
            LoadDanhSachCaLamViec();
        }

        // 1. Tải danh sách ca làm việc từ CSDL
        private void LoadDanhSachCaLamViec()
        {
            string query = @"SELECT MaCa, GioBatDau, GioKetThuc, ThoiGianNghiGiuaCa, 
                                   [KhungThoiGianChoPhepDiTre/VeSom] 
                            FROM dbo.CaLamViec";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCaLamViec.Rows.Clear();
                    int stt = 1;

                    foreach (DataRow row in dt.Rows)
                    {
                        // Đổ trực tiếp các cột chuẩn từ SQL vào DataGridView
                        dgvCaLamViec.Rows.Add(
                            stt++,
                            row["MaCa"],
                            row["GioBatDau"],
                            row["GioKetThuc"],
                            row["ThoiGianNghiGiuaCa"],
                            row["KhungThoiGianChoPhepDiTre/VeSom"]
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. Nút Thêm Mới Ca Làm Việc vào CSDL
        private void txtThemmoi_Click(object sender, EventArgs e)
        {
            string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
            string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
            string thoiGianNghi = numThoiLuongNghi.Value.ToString();
            string khungChoPhep = string.IsNullOrWhiteSpace(txtMoTa.Text) ? "15" : txtMoTa.Text.Trim();

            string query = @"INSERT INTO dbo.CaLamViec (GioBatDau, GioKetThuc, ThoiGianNghiGiuaCa, [KhungThoiGianChoPhepDiTre/VeSom]) 
                             VALUES (@GioBatDau, @GioKetThuc, @ThoiGianNghiGiuaCa, @KhungChoPhep)";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GioBatDau", gioBD);
                        cmd.Parameters.AddWithValue("@GioKetThuc", gioKT);
                        cmd.Parameters.AddWithValue("@ThoiGianNghiGiuaCa", thoiGianNghi);
                        cmd.Parameters.AddWithValue("@KhungChoPhep", khungChoPhep);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachCaLamViec();
                            btnLamMoi_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm ca làm việc: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. Nút Sửa Ca Làm Việc trong CSDL
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCa.Text) || !int.TryParse(txtMaCa.Text, out int maCa))
            {
                MessageBox.Show("Vui lòng chọn ca làm việc từ bảng bên dưới để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
            string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
            string thoiGianNghi = numThoiLuongNghi.Value.ToString();
            string khungChoPhep = string.IsNullOrWhiteSpace(txtMoTa.Text) ? "15" : txtMoTa.Text.Trim();

            string query = @"UPDATE dbo.CaLamViec 
                             SET GioBatDau = @GioBatDau, 
                                 GioKetThuc = @GioKetThuc, 
                                 ThoiGianNghiGiuaCa = @ThoiGianNghiGiuaCa,
                                 [KhungThoiGianChoPhepDiTre/VeSom] = @KhungChoPhep
                             WHERE MaCa = @MaCa";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCa", maCa);
                        cmd.Parameters.AddWithValue("@GioBatDau", gioBD);
                        cmd.Parameters.AddWithValue("@GioKetThuc", gioKT);
                        cmd.Parameters.AddWithValue("@ThoiGianNghiGiuaCa", thoiGianNghi);
                        cmd.Parameters.AddWithValue("@KhungChoPhep", khungChoPhep);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachCaLamViec();
                            btnLamMoi_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Nút Xóa Ca Làm Việc trong CSDL
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaCa.Text) || !int.TryParse(txtMaCa.Text, out int maCa))
            {
                MessageBox.Show("Vui lòng chọn ca làm việc cần xóa từ bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa Ca số {maCa}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "DELETE FROM dbo.CaLamViec WHERE MaCa = @MaCa";

                using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaCa", maCa);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Đã xóa ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDanhSachCaLamViec();
                                btnLamMoi_Click(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: Ca này có thể đang được nhân viên chọn làm việc nên không thể xóa!\nChi tiết: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 5. Sự kiện CellClick: Nhấp chuột vào bất kỳ vị trí nào trên dòng dữ liệu để lấy thông tin lên ô nhập
        private void dgvCaLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCaLamViec.Rows.Count)
            {
                DataGridViewRow row = dgvCaLamViec.Rows[e.RowIndex];

                // Cột 1: MaCa
                if (row.Cells[1].Value != null && row.Cells[1].Value != DBNull.Value)
                    txtMaCa.Text = row.Cells[1].Value.ToString();

                // Cột 2: GioBatDau
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value &&
                    DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime gbd))
                    dtpGioBatDau.Value = gbd;

                // Cột 3: GioKetThuc
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value &&
                    DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime gkt))
                    dtpGioKetThuc.Value = gkt;

                // Cột 4: ThoiGianNghiGiuaCa
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value &&
                    decimal.TryParse(row.Cells[4].Value.ToString(), out decimal nghi))
                    numThoiLuongNghi.Value = nghi;

                // Cột 5: Cho phap tre/ve som
                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                    txtMoTa.Text = row.Cells[5].Value.ToString();
            }
        }

        // 6. Nút Làm Mới Ô Nhập
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCa.Clear();
            txtMoTa.Clear();
            numThoiLuongNghi.Value = 0;
            dtpGioBatDau.Value = DateTime.Now;
            dtpGioKetThuc.Value = DateTime.Now;
        }

        // Xóa hàm trống không sử dụng
        private void dgvCaLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}