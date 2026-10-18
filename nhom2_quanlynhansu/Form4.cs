using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Form4 : Form
    {
      string connectionString = @"Data Source=100.125.54.43,1433;Initial Catalog=qlhs;User ID=sa;Password=123456;TrustServerCertificate=True;Connect Timeout=30";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dtpNgayLam.Value = DateTime.Now;

            cboCaLam.Items.Clear();
            cboCaLam.Items.AddRange(new object[] { "Ca Sáng (6h - 12h)", "Ca Chiều (12h - 18h)", "Ca Tối (18h - 22h)" });
            cboCaLam.SelectedIndex = 0;

            LoadDanhSachNhanVien();
            LoadDanhSachCaLam();
        }

        // Load Mã và Tên từ bảng Nhân Viên
        private void LoadDanhSachNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen FROM NhanVien";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboMaNV.DataSource = dt;
                    cboMaNV.DisplayMember = "MaNhanVien" +
                        "";//day
                    cboMaNV.ValueMember = "MaNhanVien" +
                        "";//day
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi");
                }
            }
        }

        // Tự hiện tên khi chọn mã
        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedItem != null)
            {
                DataRowView row = cboMaNV.SelectedItem as DataRowView;
                if (row != null)
                {
                    txtHoTen.Text = row["HoTen"].ToString();
                }
            }
        }

        // Đổ dữ liệu vào DataGridView (Lấy từ 2 bảng)
        private void LoadDanhSachCaLam()
        {
            // Kết nối bảng DangKiCaLamViec và NhanVien
            string query = @"SELECT dk.MaDangKi, dk.MaNhanVien, nv.HoTen, dk.KhungGio, dk.ThoiGianDangKi, dk.TrangThaiDangKi 
                             FROM DangKiCaLamViec dk 
                             INNER JOIN NhanVien nv ON dk.MaNhanVien = nv.MaNhanVien";//day

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCaLam.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách ca làm: " + ex.Message, "Lỗi");
                }
            }
        }

        // Nút Đăng Ký (Chỉ INSERT 4 cột)
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Cảnh báo");
                return;
            }

            int maNV = Convert.ToInt32(cboMaNV.SelectedValue);
            DateTime thoiGianDangKi = dtpNgayLam.Value;
            string trangThai = "Chờ duyệt";

            TimeSpan khungGio;
            string caChon = cboCaLam.SelectedItem.ToString();
            if (caChon.Contains("Sáng")) khungGio = new TimeSpan(6, 0, 0);
            else if (caChon.Contains("Chiều")) khungGio = new TimeSpan(12, 0, 0);
            else khungGio = new TimeSpan(18, 0, 0);

            string query = @"INSERT INTO DangKiCaLamViec (MaNhanVien, KhungGio, ThoiGianDangKi, TrangThaiDangKi) 
                             VALUES (@MaNhanVien, @KhungGio, @ThoiGianDangKi, @TrangThaiDangKi)";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", maNV);
                        cmd.Parameters.AddWithValue("@KhungGio", khungGio);
                        cmd.Parameters.AddWithValue("@ThoiGianDangKi", thoiGianDangKi);
                        cmd.Parameters.AddWithValue("@TrangThaiDangKi", trangThai);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo");
                            cboMaNV.SelectedIndex = -1;
                            txtHoTen.Clear();
                            dtpNgayLam.Value = DateTime.Now;
                            cboCaLam.SelectedIndex = 0;
                            LoadDanhSachCaLam();
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
            cboMaNV.SelectedIndex = -1;
            txtHoTen.Clear();
            dtpNgayLam.Value = DateTime.Now;
            cboCaLam.SelectedIndex = 0;
            this.Close();
        }
    }
}