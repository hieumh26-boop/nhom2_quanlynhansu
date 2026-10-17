
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
	public partial class Form3 : Form
	{
		private readonly string connectionString =
			@"Data Source=100.125.54.43,1433;
              Initial Catalog=qlns;
              User ID=TEN_DANG_NHAP;
              Password=MAT_KHAU;
              TrustServerCertificate=True;";

		public Form3()
		{
			InitializeComponent();
		}

		// Khi mở Form
		private void Form3_Load(object sender, EventArgs e)
		{
			txtTieuDe.ReadOnly = true;
			txtNguoiGui.ReadOnly = true;
			txtNgayGui.ReadOnly = true;
			rtbNoiDung.ReadOnly = true;

			dgvThongBao.SelectionMode =
				DataGridViewSelectionMode.FullRowSelect;

			dgvThongBao.MultiSelect = false;
			dgvThongBao.ReadOnly = true;
			dgvThongBao.AllowUserToAddRows = false;

			LoadThongBao();
		}

		// Tải danh sách thông báo từ SQL
		private void LoadThongBao()
		{
			string sql = @"
                SELECT mathongbao, noidung, thoigian
                FROM dbo.NhanThongBao
                ORDER BY thoigian DESC";

			try
			{
				using (SqlConnection conn =
					new SqlConnection(connectionString))
				using (SqlDataAdapter adapter =
					new SqlDataAdapter(sql, conn))
				{
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					dgvThongBao.DataSource = dt;

					if (dgvThongBao.Columns.Contains("mathongbao"))
						dgvThongBao.Columns["mathongbao"].HeaderText = "Mã thông báo";

					if (dgvThongBao.Columns.Contains("noidung"))
						dgvThongBao.Columns["noidung"].HeaderText = "Nội dung";

					if (dgvThongBao.Columns.Contains("thoigian"))
						dgvThongBao.Columns["thoigian"].HeaderText = "Thời gian";

					dgvThongBao.AutoSizeColumnsMode =
						DataGridViewAutoSizeColumnsMode.Fill;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					"Lỗi tải thông báo: " + ex.Message,
					"Lỗi SQL",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		// Khi chọn một dòng trong danh sách
		private void dgvThongBao_CellClick(
		object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow row = dgvThongBao.Rows[e.RowIndex];

			string maThongBao =
				Convert.ToString(row.Cells["mathongbao"].Value) ?? "";

			txtTieuDe.Text = "Thông báo " + maThongBao;
			txtNguoiGui.Text = "Chưa có dữ liệu người gửi";

			txtNgayGui.Text =
				Convert.ToString(row.Cells["thoigian"].Value) ?? "";

			rtbNoiDung.Text =
				Convert.ToString(row.Cells["noidung"].Value) ?? "";
		}

		// Nút đánh dấu đã đọc
		private void btnDanhDauDaDoc_Click(
			object sender, EventArgs e)
		{
			MessageBox.Show(
				"Đã hiển thị thông tin thông báo.\n" +
				"Cần xác định cột trạng thái đọc trong SQL " +
				"để lưu trạng thái đã đọc.",
				"Thông báo");
		}

		private void dgvThongBao_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
