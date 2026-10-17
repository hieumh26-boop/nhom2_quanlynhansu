namespace nhom2_quanlynhansu
{
	partial class FormCauHinhThuongPhat
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			cboDieuKienThuong = new ComboBox();
			cboLoaiThuong = new ComboBox();
			txtMoTaThuong = new TextBox();
			txtTienThuong = new TextBox();
			txtTenThuong = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			chkTuDong = new CheckBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			btnDong = new Button();
			dgvThuongPhat = new DataGridView();
			ColMa = new DataGridViewTextBoxColumn();
			ColTenQuyTac = new DataGridViewTextBoxColumn();
			ColLoai = new DataGridViewTextBoxColumn();
			ColSoTien = new DataGridViewTextBoxColumn();
			ColDieuKienApDung = new DataGridViewTextBoxColumn();
			btnLuu = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnLamMoi = new Button();
			txtTenPhat = new TextBox();
			txtTienPhat = new TextBox();
			txtMoTaPhat = new TextBox();
			cboLoaiPhat = new ComboBox();
			cboDieuKienPhat = new ComboBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvThuongPhat).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.MintCream;
			groupBox1.Controls.Add(cboDieuKienThuong);
			groupBox1.Controls.Add(cboLoaiThuong);
			groupBox1.Controls.Add(txtMoTaThuong);
			groupBox1.Controls.Add(txtTienThuong);
			groupBox1.Controls.Add(txtTenThuong);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(13, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1246, 199);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "QUY TẮC THƯỞNG";
			// 
			// cboDieuKienThuong
			// 
			cboDieuKienThuong.FormattingEnabled = true;
			cboDieuKienThuong.Location = new Point(871, 51);
			cboDieuKienThuong.Name = "cboDieuKienThuong";
			cboDieuKienThuong.Size = new Size(328, 31);
			cboDieuKienThuong.TabIndex = 11;
			// 
			// cboLoaiThuong
			// 
			cboLoaiThuong.FormattingEnabled = true;
			cboLoaiThuong.Items.AddRange(new object[] { "Thưởng", "Phạt" });
			cboLoaiThuong.Location = new Point(174, 96);
			cboLoaiThuong.Name = "cboLoaiThuong";
			cboLoaiThuong.Size = new Size(379, 31);
			cboLoaiThuong.TabIndex = 8;
			// 
			// txtMoTaThuong
			// 
			txtMoTaThuong.Location = new Point(872, 99);
			txtMoTaThuong.Multiline = true;
			txtMoTaThuong.Name = "txtMoTaThuong";
			txtMoTaThuong.Size = new Size(327, 74);
			txtMoTaThuong.TabIndex = 7;
			// 
			// txtTienThuong
			// 
			txtTienThuong.Location = new Point(174, 143);
			txtTienThuong.Name = "txtTienThuong";
			txtTienThuong.Size = new Size(379, 30);
			txtTienThuong.TabIndex = 6;
			// 
			// txtTenThuong
			// 
			txtTenThuong.Location = new Point(174, 47);
			txtTenThuong.Name = "txtTenThuong";
			txtTenThuong.Size = new Size(379, 30);
			txtTenThuong.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(665, 96);
			label5.Name = "label5";
			label5.Size = new Size(62, 23);
			label5.TabIndex = 4;
			label5.Text = "Mô tả:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(665, 54);
			label4.Name = "label4";
			label4.Size = new Size(163, 23);
			label4.TabIndex = 3;
			label4.Text = "Điều kiện áp dụng:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 146);
			label3.Name = "label3";
			label3.Size = new Size(125, 23);
			label3.TabIndex = 2;
			label3.Text = "Số tiền (VNĐ):";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 99);
			label2.Name = "label2";
			label2.Size = new Size(48, 23);
			label2.TabIndex = 1;
			label2.Text = "Loại:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 54);
			label1.Name = "label1";
			label1.Size = new Size(111, 23);
			label1.TabIndex = 0;
			label1.Text = "Tên quy tắc :";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = Color.MintCream;
			groupBox2.Controls.Add(cboDieuKienPhat);
			groupBox2.Controls.Add(cboLoaiPhat);
			groupBox2.Controls.Add(txtMoTaPhat);
			groupBox2.Controls.Add(txtTienPhat);
			groupBox2.Controls.Add(txtTenPhat);
			groupBox2.Controls.Add(chkTuDong);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Location = new Point(13, 226);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1246, 232);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "QUY TẮC PHẠT";
			// 
			// chkTuDong
			// 
			chkTuDong.AutoSize = true;
			chkTuDong.Location = new Point(23, 199);
			chkTuDong.Name = "chkTuDong";
			chkTuDong.Size = new Size(351, 27);
			chkTuDong.TabIndex = 10;
			chkTuDong.Text = "Tự động áp dụng theo bảng chấm công";
			chkTuDong.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(678, 88);
			label10.Name = "label10";
			label10.Size = new Size(62, 23);
			label10.TabIndex = 4;
			label10.Text = "Mô tả:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(678, 40);
			label9.Name = "label9";
			label9.Size = new Size(163, 23);
			label9.TabIndex = 3;
			label9.Text = "Điều kiện áp dụng:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(23, 143);
			label8.Name = "label8";
			label8.Size = new Size(125, 23);
			label8.TabIndex = 2;
			label8.Text = "Số tiền (VNĐ):";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(23, 96);
			label7.Name = "label7";
			label7.Size = new Size(48, 23);
			label7.TabIndex = 1;
			label7.Text = "Loại:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(23, 40);
			label6.Name = "label6";
			label6.Size = new Size(106, 23);
			label6.TabIndex = 0;
			label6.Text = "Tên quy tắc:";
			// 
			// btnDong
			// 
			btnDong.BackColor = Color.FromArgb(255, 224, 192);
			btnDong.Location = new Point(1165, 506);
			btnDong.Name = "btnDong";
			btnDong.Size = new Size(94, 37);
			btnDong.TabIndex = 15;
			btnDong.Text = "Đóng";
			btnDong.UseVisualStyleBackColor = false;
			// 
			// dgvThuongPhat
			// 
			dgvThuongPhat.AllowUserToAddRows = false;
			dgvThuongPhat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvThuongPhat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvThuongPhat.Columns.AddRange(new DataGridViewColumn[] { ColMa, ColTenQuyTac, ColLoai, ColSoTien, ColDieuKienApDung });
			dgvThuongPhat.Location = new Point(13, 549);
			dgvThuongPhat.Name = "dgvThuongPhat";
			dgvThuongPhat.ReadOnly = true;
			dgvThuongPhat.RowHeadersWidth = 51;
			dgvThuongPhat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvThuongPhat.Size = new Size(1246, 183);
			dgvThuongPhat.TabIndex = 16;
			// 
			// ColMa
			// 
			ColMa.HeaderText = "Mã";
			ColMa.MinimumWidth = 6;
			ColMa.Name = "ColMa";
			ColMa.ReadOnly = true;
			// 
			// ColTenQuyTac
			// 
			ColTenQuyTac.HeaderText = "Tên quy tắc";
			ColTenQuyTac.MinimumWidth = 6;
			ColTenQuyTac.Name = "ColTenQuyTac";
			ColTenQuyTac.ReadOnly = true;
			// 
			// ColLoai
			// 
			ColLoai.HeaderText = "Loại ";
			ColLoai.MinimumWidth = 6;
			ColLoai.Name = "ColLoai";
			ColLoai.ReadOnly = true;
			// 
			// ColSoTien
			// 
			ColSoTien.HeaderText = "Số tiền";
			ColSoTien.MinimumWidth = 6;
			ColSoTien.Name = "ColSoTien";
			ColSoTien.ReadOnly = true;
			// 
			// ColDieuKienApDung
			// 
			ColDieuKienApDung.HeaderText = "Điều kiện áp dụng ";
			ColDieuKienApDung.MinimumWidth = 6;
			ColDieuKienApDung.Name = "ColDieuKienApDung";
			ColDieuKienApDung.ReadOnly = true;
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(128, 255, 255);
			btnLuu.Location = new Point(671, 506);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(133, 37);
			btnLuu.TabIndex = 18;
			btnLuu.Text = "Lưu cấu hình";
			btnLuu.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			btnSua.BackColor = Color.FromArgb(255, 224, 192);
			btnSua.Location = new Point(827, 506);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 37);
			btnSua.TabIndex = 19;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			btnXoa.BackColor = Color.FromArgb(255, 224, 192);
			btnXoa.Location = new Point(942, 506);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 37);
			btnXoa.TabIndex = 20;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnLamMoi
			// 
			btnLamMoi.BackColor = Color.FromArgb(255, 224, 192);
			btnLamMoi.Location = new Point(1053, 506);
			btnLamMoi.Name = "btnLamMoi";
			btnLamMoi.Size = new Size(94, 37);
			btnLamMoi.TabIndex = 21;
			btnLamMoi.Text = "Làm mới";
			btnLamMoi.UseVisualStyleBackColor = false;
			// 
			// txtTenPhat
			// 
			txtTenPhat.Location = new Point(174, 40);
			txtTenPhat.Name = "txtTenPhat";
			txtTenPhat.Size = new Size(379, 30);
			txtTenPhat.TabIndex = 11;
			// 
			// txtTienPhat
			// 
			txtTienPhat.Location = new Point(174, 136);
			txtTienPhat.Name = "txtTienPhat";
			txtTienPhat.Size = new Size(379, 30);
			txtTienPhat.TabIndex = 12;
			// 
			// txtMoTaPhat
			// 
			txtMoTaPhat.Location = new Point(872, 85);
			txtMoTaPhat.Name = "txtMoTaPhat";
			txtMoTaPhat.Size = new Size(327, 30);
			txtMoTaPhat.TabIndex = 13;
			// 
			// cboLoaiPhat
			// 
			cboLoaiPhat.FormattingEnabled = true;
			cboLoaiPhat.Items.AddRange(new object[] { "Thưởng", "Phạt" });
			cboLoaiPhat.Location = new Point(174, 93);
			cboLoaiPhat.Name = "cboLoaiPhat";
			cboLoaiPhat.Size = new Size(379, 31);
			cboLoaiPhat.TabIndex = 14;
			// 
			// cboDieuKienPhat
			// 
			cboDieuKienPhat.FormattingEnabled = true;
			cboDieuKienPhat.Location = new Point(871, 40);
			cboDieuKienPhat.Name = "cboDieuKienPhat";
			cboDieuKienPhat.Size = new Size(328, 31);
			cboDieuKienPhat.TabIndex = 15;
			// 
			// FormCauHinhThuongPhat
			// 
			AutoScaleDimensions = new SizeF(10F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			ClientSize = new Size(1346, 808);
			Controls.Add(btnLamMoi);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnLuu);
			Controls.Add(dgvThuongPhat);
			Controls.Add(btnDong);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
			Margin = new Padding(4, 3, 4, 3);
			Name = "FormCauHinhThuongPhat";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cấu hình thưởng phạt";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvThuongPhat).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private ComboBox comboBox2;
		private ComboBox cboLoaiThuong;
		private TextBox txtMoTaThuong;
		private TextBox txtTienThuong;
		private TextBox txtTenThuong;
		private GroupBox groupBox2;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private CheckBox chkTuDong;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button btnDong;
		private DataGridView dgvThuongPhat;
		private DataGridViewTextBoxColumn ColMa;
		private DataGridViewTextBoxColumn ColTenQuyTac;
		private DataGridViewTextBoxColumn ColLoai;
		private DataGridViewTextBoxColumn ColSoTien;
		private DataGridViewTextBoxColumn ColDieuKienApDung;
		private ComboBox cboDieuKienThuong;
		private Button btnLuu;
		private Button btnSua;
		private Button btnXoa;
		private Button btnLamMoi;
		private TextBox txtTenPhat;
		private ComboBox cboDieuKienPhat;
		private ComboBox cboLoaiPhat;
		private TextBox txtMoTaPhat;
		private TextBox txtTienPhat;
	}
}