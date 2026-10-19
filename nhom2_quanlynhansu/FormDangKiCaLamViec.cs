using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormDangKiCaLamViec : Form
    {
        public FormDangKiCaLamViec()
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

      
        private void LoadDanhSachNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen FROM dbo.NhanVien";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    
                    cboMaNV.SelectedIndexChanged -= cboMaNV_SelectedIndexChanged;

                    cboMaNV.DataSource = dt;
                    cboMaNV.DisplayMember = "MaNhanVien";
                    cboMaNV.ValueMember = "MaNhanVien";
                    cboMaNV.SelectedIndex = -1;
                    txtHoTen.Clear();

                    cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex != -1 && cboMaNV.SelectedItem != null)
            {
                DataRowView row = cboMaNV.SelectedItem as DataRowView;
                if (row != null)
                {
                    txtHoTen.Text = row["HoTen"].ToString();
                }
            }
            else
            {
                txtHoTen.Clear();
            }
        }

       
        private void LoadDanhSachCaLam()
        {
            string query = @"SELECT dk.MaDangKi, 
                                    dk.MaNhanVien, 
                                    nv.HoTen, 
                                    CONVERT(VARCHAR(10), dk.ThoiGianDangKi, 103) AS NgayLam,
                                    CASE 
                                        WHEN dk.KhungGio = '06:00:00' THEN N'Ca Sáng (6h - 12h)'
                                        WHEN dk.KhungGio = '12:00:00' THEN N'Ca Chiều (12h - 18h)'
                                        WHEN dk.KhungGio = '18:00:00' THEN N'Ca Tối (18h - 22h)'
                                        ELSE CAST(dk.KhungGio AS VARCHAR(8))
                                    END AS TenCaLam,
                                    dk.TrangThaiDangKi 
                             FROM dbo.DangKiCaLamViec dk 
                             INNER JOIN dbo.NhanVien nv ON dk.MaNhanVien = nv.MaNhanVien";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCaLam.AutoGenerateColumns = true; 
                    dgvCaLam.DataSource = dt;

                    
                    if (dgvCaLam.Columns["MaDangKi"] != null) dgvCaLam.Columns["MaDangKi"].HeaderText = "Mã ĐK";
                    if (dgvCaLam.Columns["MaNhanVien"] != null) dgvCaLam.Columns["MaNhanVien"].HeaderText = "Mã NV";
                    if (dgvCaLam.Columns["HoTen"] != null) dgvCaLam.Columns["HoTen"].HeaderText = "Họ tên";
                    if (dgvCaLam.Columns["NgayLam"] != null) dgvCaLam.Columns["NgayLam"].HeaderText = "Ngày làm";
                    if (dgvCaLam.Columns["TenCaLam"] != null) dgvCaLam.Columns["TenCaLam"].HeaderText = "Ca làm việc";
                    if (dgvCaLam.Columns["TrangThaiDangKi"] != null) dgvCaLam.Columns["TrangThaiDangKi"].HeaderText = "Trạng thái";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách ca làm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1 || cboMaNV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strMaNV = cboMaNV.SelectedValue is DataRowView drv ? drv["MaNhanVien"].ToString() : cboMaNV.SelectedValue.ToString();
            if (!int.TryParse(strMaNV, out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime thoiGianDangKi = dtpNgayLam.Value.Date; 
            string trangThai = "Chờ duyệt";

            TimeSpan khungGio;
            string caChon = cboCaLam.SelectedItem != null ? cboCaLam.SelectedItem.ToString() : "";

            if (caChon.Contains("Sáng"))
                khungGio = new TimeSpan(6, 0, 0);
            else if (caChon.Contains("Chiều"))
                khungGio = new TimeSpan(12, 0, 0);
            else
                khungGio = new TimeSpan(18, 0, 0);

            string query = @"INSERT INTO dbo.DangKiCaLamViec (MaNhanVien, KhungGio, ThoiGianDangKi, TrangThaiDangKi) 
                             VALUES (@MaNhanVien, @KhungGio, @ThoiGianDangKi, @TrangThaiDangKi)";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = maNV;
                        cmd.Parameters.Add("@KhungGio", SqlDbType.Time).Value = khungGio;
                        cmd.Parameters.Add("@ThoiGianDangKi", SqlDbType.Date).Value = thoiGianDangKi;
                        cmd.Parameters.Add("@TrangThaiDangKi", SqlDbType.NVarChar, 50).Value = trangThai;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
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
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}