using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Form4 : Form
    {        // 1. Danh sách tạm để lưu dữ liệu
        private List<CaLamViec> danhSachCaLam = new List<CaLamViec>();

        // 2. Class định nghĩa cấu trúc 1 ca làm việc
        public class CaLamViec
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public DateTime NgayLam { get; set; }
            public string Ca { get; set; }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dtpNgayLam.Value = DateTime.Now; // Mặc định ngày hôm nay

            // Nạp danh sách ca làm vào ComboBox
            cboCaLam.Items.AddRange(new object[] {
                "Ca Sáng (6h - 12h)",
                "Ca Chiều (12h - 18h)",
                "Ca Tối (18h - 22h)"
            });
            cboCaLam.SelectedIndex = 0; // Chọn mặc định ca đầu

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngayLam = dtpNgayLam.Value;
            string caLam = cboCaLam.SelectedItem?.ToString();

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên!", "Cảnh báo");
                txtMaNV.Focus(); return;
            }
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập Họ tên!", "Cảnh báo");
                txtHoTen.Focus(); return;
            }
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True";

            string query = "INSERT INTO DangKyCa (MaNV, HoTen, NgayLam, CaLam) VALUES (@MaNV, @HoTen, @NgayLam, @CaLam)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Dùng Parameter để tránh lỗi SQL Injection và lỗi định dạng ngày tháng
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@NgayLam", ngayLam);
                        cmd.Parameters.AddWithValue("@CaLam", caLam);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo");

                            // (Tùy chọn) Xóa trắng form sau khi đăng ký thành công
                            txtMaNV.Clear();
                            txtHoTen.Clear();
                            dtpNgayLam.Value = DateTime.Now;
                            cboCaLam.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại!", "Lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi hệ thống");
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboCaLam.SelectedIndex = 0;
            dtpNgayLam.Value = DateTime.Now;
            this.Close();

        }
    }
}
