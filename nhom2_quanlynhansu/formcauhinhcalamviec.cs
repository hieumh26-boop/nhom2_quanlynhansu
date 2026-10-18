using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class formcauhinhcalamviec : Form 
    {
        private string connectionString = @"Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True;";
        public formcauhinhcalamviec()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaCa, TenCa, GioBatDau, GioKetThuc, ThoiLuongNghi, MoTa, TrangThai FROM CaLamViec";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCaLamViec.Rows.Clear();
                    int stt = 1;
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvCaLamViec.Rows.Add(
                            stt++,
                            row["MaCa"],
                            row["TenCa"],
                            row["GioBatDau"],
                            row["GioKetThuc"],
                            row["ThoiLuongNghi"],
                            row["MoTa"],
                            row["TrangThai"],
                            "Sửa/Xóa"
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            

        private void dgvCaLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtThemmoi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(label6.Text) || string.IsNullOrWhiteSpace(txtTenCa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã ca và Tên ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stt = dgvCaLamViec.Rows.Count;
            string maCa = label6.Text.Trim();
            string tenCa = txtTenCa.Text.Trim();
            string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
            string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
            string thoiLuong = numThoiLuongNghi.Value.ToString();
            string moTa = txtMoTa.Text.Trim();
            string trangThai = "Đang hoạt động";

            dgvCaLamViec.Rows.Add(stt, maCa, tenCa, gioBD, gioKT, thoiLuong, moTa, trangThai, "Sửa/Xóa");

            MessageBox.Show("Thêm ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void formcauhinhcalamviec_Load(object sender, EventArgs e)
        {

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCaLamViec.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCaLamViec.SelectedRows[0];

                row.Cells["colMaCa"].Value = label6.Text.Trim();
                row.Cells["colTenCa"].Value = txtTenCa.Text.Trim();
                row.Cells["colGioBatDau"].Value = dtpGioBatDau.Value.ToString("HH:mm");
                row.Cells["colGioKetThuc"].Value = dtpGioKetThuc.Value.ToString("HH:mm");
                row.Cells["colThoiLuongNghi"].Value = numThoiLuongNghi.Value.ToString();
                row.Cells["colMoTa"].Value = txtMoTa.Text.Trim();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCaLamViec.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCaLamViec.SelectedRows[0];

                row.Cells["colMaCa"].Value = label6.Text.Trim();
                row.Cells["colTenCa"].Value = txtTenCa.Text.Trim();
                row.Cells["colGioBatDau"].Value = dtpGioBatDau.Value.ToString("HH:mm");
                row.Cells["colGioKetThuc"].Value = dtpGioKetThuc.Value.ToString("HH:mm");
                row.Cells["colThoiLuongNghi"].Value = numThoiLuongNghi.Value.ToString();
                row.Cells["colMoTa"].Value = txtMoTa.Text.Trim();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCa.Clear();
            txtTenCa.Clear();
            txtMoTa.Clear();
            numThoiLuongNghi.Value = 60;
            dtpGioBatDau.Value = DateTime.Now;
            dtpGioKetThuc.Value = DateTime.Now;
            label6.Focus();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvCaLamViec.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa ca làm việc này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvCaLamViec.Rows.RemoveAt(dgvCaLamViec.SelectedRows[0].Index);

                    for (int i = 0; i < dgvCaLamViec.Rows.Count - 1; i++)
                    {
                        dgvCaLamViec.Rows[i].Cells["colSTT"].Value = (i + 1).ToString();
                    }

                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (dgvCaLamViec.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCaLamViec.SelectedRows[0];

                row.Cells["colMaCa"].Value = txtMaCa.Text.Trim();
                row.Cells["colTenCa"].Value = txtTenCa.Text.Trim();
                row.Cells["colGioBatDau"].Value = dtpGioBatDau.Value.ToString("HH:mm");
                row.Cells["colGioKetThuc"].Value = dtpGioKetThuc.Value.ToString("HH:mm");
                row.Cells["colThoiLuongNghi"].Value = numThoiLuongNghi.Value.ToString();
                row.Cells["colMoTa"].Value = txtMoTa.Text.Trim();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panelThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



