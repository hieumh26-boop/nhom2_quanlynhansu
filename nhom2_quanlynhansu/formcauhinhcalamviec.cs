using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class formcauhinhcalamviec : Form
    {
        public formcauhinhcalamviec()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvCaLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtThemmoi_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMaCa.Text) || string.IsNullOrWhiteSpace(txtTenCa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã ca và Tên ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stt = dgvCaLamViec.Rows.Count;
            string maCa = txtMaCa.Text.Trim();
            string tenCa = txtTenCa.Text.Trim();
            string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
            string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
            string thoiLuong = numThoiLuongNghi.Value.ToString();
            string moTa = txtMoTa.Text.Trim();
            string trangThai = "Đang hoạt động";

            dgvCaLamViec.Rows.Add(stt, maCa, tenCa, gioBD, gioKT, thoiLuong, moTa, trangThai, "Sửa/Xóa");

            MessageBox.Show("Thêm ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
}
