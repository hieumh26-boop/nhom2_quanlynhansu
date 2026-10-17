using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormQuanLyNhanSu : Form
    {
        // 1. Chuỗi kết nối (Giữ nguyên như bạn đã làm thành công)
        string connectionString = @"Data Source=LAPTOP-QHBQP008\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True";

        public FormQuanLyNhanSu()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form bắt đầu chạy
        private void FormQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu lên lưới
            LoadData();

            // Đổ dữ liệu vào ComboBox Cơ sở
            cboCoSo.Items.Add("Tất cả");
            cboCoSo.Items.Add("Cơ sở 1");
            cboCoSo.Items.Add("Cơ sở 2");
            cboCoSo.SelectedIndex = 0; // Mặc định chọn "Tất cả"
        }

        // Hàm tải toàn bộ danh sách
        private void LoadData()
        {
            // Sửa lại tên cột (MaNV, HoTen, ChucVu, CoSo) cho khớp với bảng trong SQL của bạn
            string query = "SELECT MaNV, HoTen, ChucVu, CoSo FROM NhanVien";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDanhSachNhanVien.DataSource = dt; // Đổ dữ liệu vào DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi hệ thống");
                }
            }
        }

        // Sự kiện khi bấm nút "Lọc"
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string coSoDuocChon = cboCoSo.SelectedItem.ToString();

            // Nếu chọn "Tất cả" thì load lại toàn bộ
            if (coSoDuocChon == "Tất cả")
            {
                LoadData();
                return;
            }

            // Ngược lại thì lọc theo cơ sở
            string query = "SELECT MaNV, HoTen, ChucVu, CoSo FROM NhanVien WHERE CoSo = @CoSo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    // Dùng Parameter để tránh lỗi SQL Injection
                    adapter.SelectCommand.Parameters.AddWithValue("@CoSo", coSoDuocChon);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSachNhanVien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}