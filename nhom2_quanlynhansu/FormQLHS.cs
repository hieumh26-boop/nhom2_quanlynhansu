
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
	public partial class FormQLHS : Form
	{
		// Chuỗi kết nối SQL Server giống Form4
		private string connectionString =
			@"Data Source=100.125.54.43,1433;
              Initial Catalog=qlns;
              User ID=TEN_DANG_NHAP;
              Password=MAT_KHAU;
              TrustServerCertificate=True;";

		public FormQLHS()
		{
			InitializeComponent();
		}

		// Khi mở Form2
		private void form2_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;

			KhoaThongTin(true);
			CauHinhBangLich();

			// Đổi NV001 thành mã nhân viên thực tế
			LoadNhanVien("NV001");
		}

		// Cấu hình bảng lịch làm việc
		private void CauHinhBangLich()
		{
			dgvLichLamViec.Columns.Clear();

			dgvLichLamViec.Columns.Add("Thu", "Thứ");
			dgvLichLamViec.Columns.Add("CaLam", "Ca làm");
			dgvLichLamViec.Columns.Add("ThoiGian", "Thời gian");

			dgvLichLamViec.AutoSizeColumnsMode =
				DataGridViewAutoSizeColumnsMode.Fill;

			dgvLichLamViec.AllowUserToAddRows = false;
			dgvLichLamViec.ReadOnly = true;
		}

		// Lấy thông tin nhân viên từ SQL
		private void LoadNhanVien(string maNV)
		{
			string sql = @"
                SELECT MaNhanVien, HoTen, SDT, CCCD,
                       STK, HinhThucLamViec, MaCoSo, VaiTro
                FROM dbo.NhanVien
                WHERE MaNhanVien = @MaNV";

			try
			{
				using (SqlConnection conn =
					new SqlConnection(connectionString))
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 50)
								  .Value = maNV;

					conn.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							txtMaNV.Text =
								reader["MaNhanVien"].ToString();

							txtHoTen.Text =
								reader["HoTen"].ToString();

							txtSDT.Text =
								reader["SDT"].ToString();

							txtCCCD.Text =
								reader["CCCD"].ToString();

							txtSoTaiKhoan.Text =
								reader["STK"].ToString();

							txtMaCoSo.Text =
								reader["MaCoSo"].ToString();

							txtVaiTro.Text =
								reader["VaiTro"].ToString();

							// Bảng hiện tại có MaCoSo,
							// chưa xác định có cột tên cơ sở hay không.
							txtCoSo.Text =
								reader["MaCoSo"].ToString();

							string hinhThuc =
								reader["HinhThucLamViec"]?.ToString() ?? "";

							rdoFullTime.Checked =
								hinhThuc == "FullTime";

							rdoPartTime.Checked =
								hinhThuc == "PartTime";
						}
						else
						{
							MessageBox.Show(
								"Không tìm thấy nhân viên " + maNV);
						}
					}
				}

				// Tải lịch làm việc của nhân viên
				LoadLichLamViec(maNV);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Lỗi tải dữ liệu SQL: " + ex.Message,
					"Lỗi",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		// Tải lịch làm từ bảng DangKyCa của Form4
		private void LoadLichLamViec(string maNV)
		{
			string sql = @"
                SELECT NgayLam, CaLam
                FROM dbo.DangKyCa
                WHERE MaNV = @MaNV
                ORDER BY NgayLam";

			try
			{
				using (SqlConnection conn =
					new SqlConnection(connectionString))
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 20)
								  .Value = maNV;

					conn.Open();

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						dgvLichLamViec.Rows.Clear();

						while (reader.Read())
						{
							DateTime ngay =
								Convert.ToDateTime(reader["NgayLam"]);

							string ca = reader["CaLam"]?.ToString() ?? "";

							dgvLichLamViec.Rows.Add(
                         ngay.ToString("dddd"),
                         ca ?? "",
                         ngay.ToString("dd/MM/yyyy"));
						}
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(
					"Không tải được lịch làm việc. " +
					"Kiểm tra bảng dbo.DangKyCa.\n" + ex.Message,
					"Thông báo");
			}
		}

		// Khóa hoặc mở khóa các ô nhập
		private void KhoaThongTin(bool khoa)
		{
			txtMaNV.ReadOnly = true;

			txtHoTen.ReadOnly = khoa;
			txtVaiTro.ReadOnly = khoa;
			txtSDT.ReadOnly = khoa;
			txtCCCD.ReadOnly = khoa;
			txtSoTaiKhoan.ReadOnly = khoa;
			txtMaCoSo.ReadOnly = khoa;
			txtCoSo.ReadOnly = true;

			dtpNgaySinh.Enabled = !khoa;
			rdoNam.Enabled = !khoa;
			rdoNu.Enabled = !khoa;
			rdoFullTime.Enabled = !khoa;
			rdoPartTime.Enabled = !khoa;
		}

		// Nút Chỉnh sửa
		private void btnChinhSua_Click(object sender, EventArgs e)
		{
			KhoaThongTin(false);
			MessageBox.Show("Bạn có thể chỉnh sửa thông tin.");
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

			string hinhThuc = rdoFullTime.Checked
				? "FullTime" : "PartTime";

			string sql = @"
                UPDATE dbo.NhanVien
                SET HoTen = @HoTen,
                    SDT = @SDT,
                    CCCD = @CCCD,
                    STK = @STK,
                    HinhThucLamViec = @HinhThuc,
                    MaCoSo = @MaCoSo,
                    VaiTro = @VaiTro
                WHERE MaNhanVien = @MaNV";

			try
			{
				using (SqlConnection conn =
					new SqlConnection(connectionString))
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 50)
								  .Value = txtMaNV.Text.Trim();

					cmd.Parameters.AddWithValue(
						"@HoTen", txtHoTen.Text.Trim());

					cmd.Parameters.AddWithValue(
						"@SDT", txtSDT.Text.Trim());

					cmd.Parameters.AddWithValue(
						"@CCCD", txtCCCD.Text.Trim());

					cmd.Parameters.AddWithValue(
						"@STK", txtSoTaiKhoan.Text.Trim());

					cmd.Parameters.AddWithValue(
						"@HinhThuc", hinhThuc);

					cmd.Parameters.AddWithValue(
						"@MaCoSo", txtMaCoSo.Text.Trim());

					cmd.Parameters.AddWithValue(
						"@VaiTro", txtVaiTro.Text.Trim());

					conn.Open();

					int rows = cmd.ExecuteNonQuery();

					if (rows > 0)
					{
						MessageBox.Show(
							"Cập nhật nhân viên thành công!");

						KhoaThongTin(true);

						LoadNhanVien(txtMaNV.Text.Trim());
					}
					else
					{
						MessageBox.Show(
							"Không tìm thấy nhân viên để cập nhật!");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Lỗi lưu dữ liệu: " + ex.Message);
			}
		}

		// Nút Xem bảng lương
		private void btnXemBangLuong_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Mã nhân viên: " + txtMaNV.Text +
				"\nChức năng bảng lương cần kết nối bảng BangLuong.");
		}

		// Nút Xem phiếu lương chi tiết
		private void btnXemPhieuLuong_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Mã nhân viên: " + txtMaNV.Text +
				"\nChức năng phiếu lương cần xác định cấu trúc bảng lương.");
		}

		// Khi thay đổi kích thước form
		private void form2_Resize(object sender, EventArgs e)
		{
			// Giao diện tự co giãn nếu đã dùng Dock/Anchor.
		}
	}
}
