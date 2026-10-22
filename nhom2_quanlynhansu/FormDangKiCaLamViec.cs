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

            LoadDanhSachNhanVien();
            LoadDanhSachCaLamViecCombox(); 
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

        
        private void LoadDanhSachCaLamViecCombox()
        {
            string query = "SELECT MaCa, (N'Ca ' + CAST(MaCa AS NVARCHAR(10)) + ' (' + GioBatDau + ' - ' + GioKetThuc + ')') AS TenCa FROM dbo.CaLamViec";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboCaLam.SelectedIndexChanged -= cboCaLam_SelectedIndexChanged;

                    cboCaLam.DataSource = dt;
                    cboCaLam.DisplayMember = "TenCa";
                    cboCaLam.ValueMember = "MaCa";
                    cboCaLam.SelectedIndex = -1;

                    tbbd.Clear();
                    tbkt.Clear();

                    cboCaLam.SelectedIndexChanged += cboCaLam_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách ca làm việc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       
        private void cboCaLam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCaLam.SelectedIndex != -1 && cboCaLam.SelectedValue != null)
            {
                string maCa = cboCaLam.SelectedValue.ToString();
                string query = "SELECT GioBatDau, GioKetThuc FROM dbo.CaLamViec WHERE MaCa = @mc";

                using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mc", maCa);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader doc = cmd.ExecuteReader())
                        {
                            if (doc.Read())
                            {
                                tbbd.Text = doc["GioBatDau"] != DBNull.Value ? doc["GioBatDau"].ToString() : "";
                                tbkt.Text = doc["GioKetThuc"] != DBNull.Value ? doc["GioKetThuc"].ToString() : "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lấy thông tin ca làm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                tbbd.Clear();
                tbkt.Clear();
            }
        }

      
        private void LoadDanhSachCaLam()
        {
            string query = @"SELECT dk.MaDangKi, 
                                    dk.MaNhanVien, 
                                    nv.HoTen, 
                                    dk.MaCa,
                                    (cl.GioBatDau + ' - ' + cl.GioKetThuc) AS KhungGio,
                                    dk.TrangThaiDangKi 
                             FROM dbo.DangKiCaLamViec dk 
                             INNER JOIN dbo.NhanVien nv ON dk.MaNhanVien = nv.MaNhanVien
                             INNER JOIN dbo.CaLamViec cl ON dk.MaCa = cl.MaCa";

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
                    if (dgvCaLam.Columns["MaCa"] != null) dgvCaLam.Columns["MaCa"].HeaderText = "Mã Ca";
                    if (dgvCaLam.Columns["KhungGio"] != null) dgvCaLam.Columns["KhungGio"].HeaderText = "Khung giờ làm";
                    if (dgvCaLam.Columns["TrangThaiDangKi"] != null) dgvCaLam.Columns["TrangThaiDangKi"].HeaderText = "Trạng thái";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách đăng ký ca: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

           
            if (cboCaLam.SelectedIndex == -1 || cboCaLam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ca làm việc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string strMaNV = cboMaNV.SelectedValue is DataRowView drvNV ? drvNV["MaNhanVien"].ToString() : cboMaNV.SelectedValue.ToString();
            string strMaCa = cboCaLam.SelectedValue is DataRowView drvCa ? drvCa["MaCa"].ToString() : cboCaLam.SelectedValue.ToString();

            if (!int.TryParse(strMaNV, out int maNV) || !int.TryParse(strMaCa, out int maCa))
            {
                MessageBox.Show("Dữ liệu nhân viên hoặc ca làm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = "Chờ duyệt";

            
            string query = @"INSERT INTO dbo.DangKiCaLamViec (MaNhanVien, MaCa, TrangThaiDangKi) 
                             VALUES (@MaNhanVien, @MaCa, @TrangThaiDangKi)";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = maNV;
                        cmd.Parameters.Add("@MaCa", SqlDbType.Int).Value = maCa;
                        cmd.Parameters.Add("@TrangThaiDangKi", SqlDbType.NVarChar, 50).Value = trangThai;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            cboMaNV.SelectedIndex = -1;
                            cboCaLam.SelectedIndex = -1;
                            txtHoTen.Clear();
                            tbbd.Clear();
                            tbkt.Clear();

                            
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