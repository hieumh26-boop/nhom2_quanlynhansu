using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
	public partial class FormCauHinhThuongPhat : Form
	{
		// Lưu mã quy tắc đang chọn để Sửa/Xóa (-1 là chế độ thêm mới)
		private int selectedMaQuyTac = -1;

		public FormCauHinhThuongPhat()
		{
			InitializeComponent();
		}

		private void FormCauHinhThuongPhat_Load(object sender, EventArgs e)
		{
			InitComboBoxes();
			LoadDataQuyTac();
		}

		// 1. Khởi tạo dữ liệu cho ComboBox
		private void InitComboBoxes()
		{
			cboLoaiThuong.Items.Clear();
			cboLoaiThuong.Items.AddRange(new object[] { "Chuyên cần", "Doanh số", "Thành tích xuất sắc", "Thưởng lễ/Tết" });
			cboLoaiThuong.SelectedIndex = 0;

			cboLoaiPhat.Items.Clear();
			cboLoaiPhat.Items.AddRange(new object[] { "Đi trễ/Về sớm", "Vi phạm nội quy", "Nghỉ không phép", "Sai sót công việc" });
			cboLoaiPhat.SelectedIndex = 0;

			cboDieuKienThuong.Items.Clear();
			cboDieuKienThuong.Items.AddRange(new object[] { "Đủ số công/tháng", "Đạt mốc doanh số", "Đánh giá A+", "Tất cả nhân viên" });
			cboDieuKienThuong.SelectedIndex = 0;

			cboDieuKienPhat.Items.Clear();
			cboDieuKienPhat.Items.AddRange(new object[] { "> 15 phút", "> 3 lần/tháng", "Vi phạm lần 1", "Tất cả nhân viên" });
			cboDieuKienPhat.SelectedIndex = 0;
		}

		// 2. Lấy dữ liệu từ bảng QuyTac lên DataGridView theo phong cách kết nối của bạn
		private void LoadDataQuyTac()
		{
			string sql = @"SELECT 
                            MaQuyTac AS [Mã], 
                            TenQuyTac AS [Tên quy tắc], 
                            Loai AS [Loại], 
                            SoTien AS [Số tiền], 
                            DieuKienApDung AS [Điều kiện áp dụng], 
                            MoTa AS [Mô tả], 
                            TuDongApDung AS [Tự động áp dụng] 
                          FROM dbo.QuyTac";

			try
			{
				using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
				using (SqlCommand cmd = new SqlCommand(sql, kn))
				{
					kn.Open();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);

					dgvThuongPhat.DataSource = dt;
					dgvThuongPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tải dữ liệu quy tắc: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// 3. Nút "Lưu cấu hình" (Thêm mới quy tắc)
		private void btnLuuCauHinh_Click(object sender, EventArgs e)
		{
			bool isThuong = !string.IsNullOrWhiteSpace(txtTenThuong.Text);
			bool isPhat = !string.IsNullOrWhiteSpace(txtTenPhat.Text);

			if (!isThuong && !isPhat)
			{
				MessageBox.Show("Vui lòng nhập tên quy tắc thưởng hoặc quy tắc phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string tenQuyTac = isThuong ? txtTenThuong.Text.Trim() : txtTenPhat.Text.Trim();
			string loai = isThuong ? ("Thưởng - " + cboLoaiThuong.SelectedItem?.ToString()) : ("Phạt - " + cboLoaiPhat.SelectedItem?.ToString());
			string strSoTien = isThuong ? txtTienThuong.Text.Trim() : txtTienPhat.Text.Trim();
			string dieuKien = isThuong ? cboDieuKienThuong.SelectedItem?.ToString() ?? "" : cboDieuKienPhat.SelectedItem?.ToString() ?? "";
			string moTa = isThuong ? txtMoTaThuong.Text.Trim() : txtMoTaPhat.Text.Trim();
			bool tuDong = chkTuDong.Checked;

			if (!decimal.TryParse(strSoTien, out decimal soTien))
			{
				MessageBox.Show("Số tiền phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string sql = @"INSERT INTO dbo.QuyTac (TenQuyTac, Loai, SoTien, DieuKienApDung, MoTa, TuDongApDung) 
                           VALUES (@TenQuyTac, @Loai, @SoTien, @DieuKien, @MoTa, @TuDong)";

			try
			{
				using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
				using (SqlCommand cmd = new SqlCommand(sql, kn))
				{
					cmd.Parameters.Add("@TenQuyTac", SqlDbType.NVarChar, 100).Value = tenQuyTac;
					cmd.Parameters.Add("@Loai", SqlDbType.NVarChar, 100).Value = loai;
					cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
					cmd.Parameters.Add("@DieuKien", SqlDbType.NVarChar, 255).Value = dieuKien ?? "";
					cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 255).Value = moTa;
					cmd.Parameters.Add("@TuDong", SqlDbType.Bit).Value = tuDong;

					kn.Open();
					cmd.ExecuteNonQuery();

					MessageBox.Show("Thêm quy tắc thưởng/phạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ResetForm();
					LoadDataQuyTac();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi lưu quy tắc: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// 4. Click dòng trên DataGridView để hiển thị dữ liệu lên ô nhập
		private void dgvQuyTac_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvThuongPhat.Rows[e.RowIndex];
				if (row.Cells["Mã"].Value != DBNull.Value)
				{
					selectedMaQuyTac = Convert.ToInt32(row.Cells["Mã"].Value);
					string loai = row.Cells["Loại"].Value?.ToString() ?? "";
					string ten = row.Cells["Tên quy tắc"].Value?.ToString() ?? "";
					string soTien = row.Cells["Số tiền"].Value?.ToString() ?? "0";
					string dieuKien = row.Cells["Điều kiện áp dụng"].Value?.ToString() ?? "";
					string moTa = row.Cells["Mô tả"].Value?.ToString() ?? "";
					bool tuDong = row.Cells["Tự động áp dụng"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Tự động áp dụng"].Value);

					chkTuDong.Checked = tuDong;

					if (loai.StartsWith("Thưởng"))
					{
						txtTenThuong.Text = ten;
						txtTienThuong.Text = soTien;
						txtMoTaThuong.Text = moTa;
						cboDieuKienThuong.Text = dieuKien;

						txtTenPhat.Clear();
						txtTienPhat.Clear();
						txtMoTaPhat.Clear();
					}
					else
					{
						txtTenPhat.Text = ten;
						txtTienPhat.Text = soTien;
						txtMoTaPhat.Text = moTa;
						cboDieuKienPhat.Text = dieuKien;

						txtTenThuong.Clear();
						txtTienThuong.Clear();
						txtMoTaThuong.Clear();
					}
				}
			}
		}

		// 5. Nút "Sửa" quy tắc đã chọn
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (selectedMaQuyTac == -1)
			{
				MessageBox.Show("Vui lòng chọn quy tắc trong bảng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool isThuong = !string.IsNullOrWhiteSpace(txtTenThuong.Text);
			string tenQuyTac = isThuong ? txtTenThuong.Text.Trim() : txtTenPhat.Text.Trim();
			string loai = isThuong ? ("Thưởng - " + cboLoaiThuong.SelectedItem?.ToString()) : ("Phạt - " + cboLoaiPhat.SelectedItem?.ToString());
			string strSoTien = isThuong ? txtTienThuong.Text.Trim() : txtTienPhat.Text.Trim();
			string dieuKien = isThuong ? cboDieuKienThuong.SelectedItem?.ToString() ?? "" : cboDieuKienPhat.SelectedItem?.ToString() ?? "";
			string moTa = isThuong ? txtMoTaThuong.Text.Trim() : txtMoTaPhat.Text.Trim();

			if (!decimal.TryParse(strSoTien, out decimal soTien))
			{
				MessageBox.Show("Số tiền không hợp lệ!", "Cảnh báo");
				return;
			}

			string sql = @"UPDATE dbo.QuyTac 
                           SET TenQuyTac = @Ten, Loai = @Loai, SoTien = @SoTien, DieuKienApDung = @DieuKien, MoTa = @MoTa, TuDongApDung = @TuDong 
                           WHERE MaQuyTac = @Ma";

			try
			{
				using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
				using (SqlCommand cmd = new SqlCommand(sql, kn))
				{
					cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = tenQuyTac;
					cmd.Parameters.Add("@Loai", SqlDbType.NVarChar, 100).Value = loai;
					cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
					cmd.Parameters.Add("@DieuKien", SqlDbType.NVarChar, 255).Value = dieuKien ?? "";
					cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 255).Value = moTa;
					cmd.Parameters.Add("@TuDong", SqlDbType.Bit).Value = chkTuDong.Checked;
					cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = selectedMaQuyTac;

					kn.Open();
					cmd.ExecuteNonQuery();

					MessageBox.Show("Cập nhật quy tắc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ResetForm();
					LoadDataQuyTac();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// 6. Nút "Xóa" quy tắc
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (selectedMaQuyTac == -1)
			{
				MessageBox.Show("Vui lòng chọn quy tắc cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (MessageBox.Show("Bạn có chắc chắn muốn xóa quy tắc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string sql = "DELETE FROM dbo.QuyTac WHERE MaQuyTac = @Ma";

				try
				{
					using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
					using (SqlCommand cmd = new SqlCommand(sql, kn))
					{
						cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = selectedMaQuyTac;

						kn.Open();
						cmd.ExecuteNonQuery();

						MessageBox.Show("Xóa quy tắc thành công!", "Thông báo");
						ResetForm();
						LoadDataQuyTac();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// 7. Nút "Làm mới"
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void ResetForm()
		{
			selectedMaQuyTac = -1;
			txtTenThuong.Clear();
			txtTienThuong.Clear();
			txtMoTaThuong.Clear();

			txtTenPhat.Clear();
			txtTienPhat.Clear();
			txtMoTaPhat.Clear();

			chkTuDong.Checked = false;
		}

		// 8. Nút "Đóng"
		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
