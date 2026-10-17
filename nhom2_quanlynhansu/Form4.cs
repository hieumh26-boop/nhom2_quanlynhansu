using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Form4 : Form
    {
        // Khai báo chuỗi kết nối dùng chung cho cả form
       

        public Form4()
        {
            InitializeComponent();
        }

        // 1. Sự kiện Load Form
        private void Form4_Load(object sender, EventArgs e)
        {
            dtpNgayLam.Value = DateTime.Now;

            // Load danh sách ca làm vào ComboBox
            cboCaLam.Items.Clear();
            cboCaLam.Items.AddRange(new object[] {
                "Ca Sáng (6h - 12h)",
                "Ca Chiều (12h - 18h)",
                "Ca Tối (18h - 22h)"
            });
            cboCaLam.SelectedIndex = 0;

            // Gọi 2 hàm tải dữ liệu từ SQL
            LoadDanhSachNhanVien();
            LoadDanhSachCaLam();
        }

        // 2. Hàm tải danh sách nhân viên vào ComboBox
        private void LoadDanhSachNhanVien()
        {
            string query = "SELECT MaNV, HoTen FROM NhanVien";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
                
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboMaNV.DataSource = dt;
                    cboMaNV.DisplayMember = "HoTen";
                    cboMaNV.ValueMember = "MaNV";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi");
                }
            }
        }

        // 3. Hàm tải danh sách ca đã đăng ký lên DataGridView
        private void LoadDanhSachCaLam()
        {
            string query = "SELECT MaNV, HoTen, NgayLam, CaLam FROM DangKyCa";

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

        // 4. Sự kiện nút Đăng Ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Cảnh báo");
                return;
            }

            string maNV = cboMaNV.SelectedValue.ToString();
            string hoTen = cboMaNV.Text;
            DateTime ngayLam = dtpNgayLam.Value;
            string caLam = cboCaLam.SelectedItem.ToString();

            string query = "INSERT INTO DangKyCa (MaNV, HoTen, NgayLam, CaLam) VALUES (@MaNV, @HoTen, @NgayLam, @CaLam)";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@NgayLam", ngayLam);
                        cmd.Parameters.AddWithValue("@CaLam", caLam);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo");

                            // Làm sạch form
                            cboMaNV.SelectedIndex = -1;
                            dtpNgayLam.Value = DateTime.Now;
                            cboCaLam.SelectedIndex = 0;

                            // Load lại bảng để thấy dữ liệu mới
                            LoadDanhSachCaLam();
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

        // 5. Sự kiện nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = -1;
            dtpNgayLam.Value = DateTime.Now;
            cboCaLam.SelectedIndex = 0;
            this.Close();
        }
    }
}