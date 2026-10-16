namespace nhom2_quanlynhansu
{
	partial class FormQLHS
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
			groupBox2 = new GroupBox();
			btnXemPhieuLuong = new Button();
			btnXemBangLuong = new Button();
			dgvLichLamViec = new DataGridView();
			colThu = new DataGridViewTextBoxColumn();
			colCalam = new DataGridViewTextBoxColumn();
			colThoigian = new DataGridViewTextBoxColumn();
			label9 = new Label();
			panel1 = new Panel();
			groupBox1 = new GroupBox();
			dtpNgaySinh = new DateTimePicker();
			rdoNu = new RadioButton();
			btnLuu = new Button();
			btnChinhSua = new Button();
			txtMaCoSo = new TextBox();
			txtMaNV = new TextBox();
			label12 = new Label();
			txtCCCD = new TextBox();
			rdoPartTime = new RadioButton();
			txtSDT = new TextBox();
			label11 = new Label();
			rdoFullTime = new RadioButton();
			rdoNam = new RadioButton();
			label10 = new Label();
			txtHinhThuc = new Label();
			label6 = new Label();
			label7 = new Label();
			label5 = new Label();
			txtCoSo = new TextBox();
			txtVaiTro = new TextBox();
			txtHoTen = new TextBox();
			label4 = new Label();
			txtSoTK = new Label();
			label2 = new Label();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			txtSoTaiKhoan = new TextBox();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvLichLamViec).BeginInit();
			panel1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.BackColor = SystemColors.Control;
			groupBox2.Controls.Add(btnXemPhieuLuong);
			groupBox2.Controls.Add(btnXemBangLuong);
			groupBox2.Controls.Add(dgvLichLamViec);
			groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			groupBox2.ForeColor = Color.Black;
			groupBox2.Location = new Point(588, 68);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(575, 594);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Lịch làm việc và lương ";
			// 
			// btnXemPhieuLuong
			// 
			btnXemPhieuLuong.BackColor = Color.FromArgb(0, 0, 192);
			btnXemPhieuLuong.FlatStyle = FlatStyle.Popup;
			btnXemPhieuLuong.Font = new Font("Segoe UI", 12F);
			btnXemPhieuLuong.ForeColor = Color.White;
			btnXemPhieuLuong.Location = new Point(27, 432);
			btnXemPhieuLuong.Name = "btnXemPhieuLuong";
			btnXemPhieuLuong.Size = new Size(248, 40);
			btnXemPhieuLuong.TabIndex = 2;
			btnXemPhieuLuong.Text = "Xem phiếu lương chi tiết";
			btnXemPhieuLuong.UseVisualStyleBackColor = false;
			// 
			// btnXemBangLuong
			// 
			btnXemBangLuong.BackColor = Color.FromArgb(0, 0, 192);
			btnXemBangLuong.FlatStyle = FlatStyle.Popup;
			btnXemBangLuong.Font = new Font("Segoe UI", 12F);
			btnXemBangLuong.ForeColor = Color.White;
			btnXemBangLuong.Location = new Point(27, 357);
			btnXemBangLuong.Name = "btnXemBangLuong";
			btnXemBangLuong.Size = new Size(186, 42);
			btnXemBangLuong.TabIndex = 1;
			btnXemBangLuong.Text = "Xem bảng lương";
			btnXemBangLuong.UseVisualStyleBackColor = false;
			// 
			// dgvLichLamViec
			// 
			dgvLichLamViec.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dgvLichLamViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvLichLamViec.Columns.AddRange(new DataGridViewColumn[] { colThu, colCalam, colThoigian });
			dgvLichLamViec.Location = new Point(27, 76);
			dgvLichLamViec.Name = "dgvLichLamViec";
			dgvLichLamViec.RowHeadersWidth = 51;
			dgvLichLamViec.Size = new Size(428, 230);
			dgvLichLamViec.TabIndex = 0;
			// 
			// colThu
			// 
			colThu.HeaderText = "Thứ";
			colThu.MinimumWidth = 6;
			colThu.Name = "colThu";
			colThu.Width = 125;
			// 
			// colCalam
			// 
			colCalam.HeaderText = "Ca làm";
			colCalam.MinimumWidth = 6;
			colCalam.Name = "colCalam";
			colCalam.Width = 125;
			// 
			// colThoigian
			// 
			colThoigian.HeaderText = "Thời gian";
			colThoigian.MinimumWidth = 6;
			colThoigian.Name = "colThoigian";
			colThoigian.Width = 125;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = SystemColors.Control;
			label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
			label9.Location = new Point(103, 19);
			label9.Name = "label9";
			label9.Size = new Size(348, 31);
			label9.TabIndex = 2;
			label9.Text = "QUẢN LÝ HỒ SƠ NGƯỜI DÙNG";
			// 
			// panel1
			// 
			panel1.Controls.Add(groupBox2);
			panel1.Controls.Add(groupBox1);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1175, 909);
			panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			groupBox1.BackColor = SystemColors.Control;
			groupBox1.Controls.Add(txtSoTaiKhoan);
			groupBox1.Controls.Add(dtpNgaySinh);
			groupBox1.Controls.Add(rdoNu);
			groupBox1.Controls.Add(btnLuu);
			groupBox1.Controls.Add(btnChinhSua);
			groupBox1.Controls.Add(txtMaCoSo);
			groupBox1.Controls.Add(txtMaNV);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(txtCCCD);
			groupBox1.Controls.Add(rdoPartTime);
			groupBox1.Controls.Add(txtSDT);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(rdoFullTime);
			groupBox1.Controls.Add(rdoNam);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(txtHinhThuc);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(txtCoSo);
			groupBox1.Controls.Add(txtVaiTro);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(txtSoTK);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.FlatStyle = FlatStyle.Popup;
			groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			groupBox1.Location = new Point(0, 68);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(582, 594);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin cá nhân";
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
			dtpNgaySinh.Location = new Point(201, 401);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(250, 34);
			dtpNgaySinh.TabIndex = 23;
			// 
			// rdoNu
			// 
			rdoNu.AutoSize = true;
			rdoNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
			rdoNu.Location = new Point(327, 442);
			rdoNu.Name = "rdoNu";
			rdoNu.Size = new Size(60, 32);
			rdoNu.TabIndex = 22;
			rdoNu.TabStop = true;
			rdoNu.Text = "Nữ";
			rdoNu.UseVisualStyleBackColor = true;
			// 
			// btnLuu
			// 
			btnLuu.BackColor = Color.FromArgb(0, 0, 192);
			btnLuu.Enabled = false;
			btnLuu.FlatStyle = FlatStyle.Popup;
			btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
			btnLuu.ForeColor = Color.White;
			btnLuu.Location = new Point(280, 539);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(156, 51);
			btnLuu.TabIndex = 21;
			btnLuu.Text = "Lưu thay đổi";
			btnLuu.UseVisualStyleBackColor = false;
			// 
			// btnChinhSua
			// 
			btnChinhSua.BackColor = Color.White;
			btnChinhSua.FlatStyle = FlatStyle.Popup;
			btnChinhSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
			btnChinhSua.ForeColor = Color.FromArgb(0, 0, 192);
			btnChinhSua.Location = new Point(60, 539);
			btnChinhSua.Name = "btnChinhSua";
			btnChinhSua.Size = new Size(121, 51);
			btnChinhSua.TabIndex = 20;
			btnChinhSua.Text = "Chỉnh sửa";
			btnChinhSua.UseVisualStyleBackColor = false;
			// 
			// txtMaCoSo
			// 
			txtMaCoSo.Location = new Point(201, 308);
			txtMaCoSo.Name = "txtMaCoSo";
			txtMaCoSo.Size = new Size(194, 34);
			txtMaCoSo.TabIndex = 9;
			// 
			// txtMaNV
			// 
			txtMaNV.Location = new Point(201, 36);
			txtMaNV.Name = "txtMaNV";
			txtMaNV.Size = new Size(194, 34);
			txtMaNV.TabIndex = 19;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Times New Roman", 12F);
			label12.ForeColor = Color.Black;
			label12.Location = new Point(21, 310);
			label12.Name = "label12";
			label12.Size = new Size(91, 22);
			label12.TabIndex = 6;
			label12.Text = "Mã cơ sở:";
			// 
			// txtCCCD
			// 
			txtCCCD.Location = new Point(201, 218);
			txtCCCD.Name = "txtCCCD";
			txtCCCD.Size = new Size(194, 34);
			txtCCCD.TabIndex = 8;
			// 
			// rdoPartTime
			// 
			rdoPartTime.AutoSize = true;
			rdoPartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
			rdoPartTime.Location = new Point(327, 486);
			rdoPartTime.Name = "rdoPartTime";
			rdoPartTime.Size = new Size(109, 32);
			rdoPartTime.TabIndex = 18;
			rdoPartTime.TabStop = true;
			rdoPartTime.Text = "PartTime";
			rdoPartTime.UseVisualStyleBackColor = true;
			// 
			// txtSDT
			// 
			txtSDT.Location = new Point(201, 169);
			txtSDT.Name = "txtSDT";
			txtSDT.Size = new Size(194, 34);
			txtSDT.TabIndex = 7;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Times New Roman", 12F);
			label11.ForeColor = Color.Black;
			label11.Location = new Point(18, 227);
			label11.Name = "label11";
			label11.Size = new Size(69, 22);
			label11.TabIndex = 5;
			label11.Text = "CCCD:";
			// 
			// rdoFullTime
			// 
			rdoFullTime.AutoSize = true;
			rdoFullTime.Font = new Font("Segoe UI", 12F);
			rdoFullTime.Location = new Point(201, 486);
			rdoFullTime.Name = "rdoFullTime";
			rdoFullTime.Size = new Size(106, 32);
			rdoFullTime.TabIndex = 16;
			rdoFullTime.TabStop = true;
			rdoFullTime.Text = "FullTime";
			rdoFullTime.UseVisualStyleBackColor = true;
			// 
			// rdoNam
			// 
			rdoNam.AutoSize = true;
			rdoNam.Font = new Font("Times New Roman", 12F);
			rdoNam.ForeColor = Color.Black;
			rdoNam.Location = new Point(201, 448);
			rdoNam.Name = "rdoNam";
			rdoNam.Size = new Size(73, 26);
			rdoNam.TabIndex = 14;
			rdoNam.TabStop = true;
			rdoNam.Text = "Nam ";
			rdoNam.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Times New Roman", 12F);
			label10.ForeColor = Color.Black;
			label10.Location = new Point(18, 178);
			label10.Name = "label10";
			label10.Size = new Size(120, 22);
			label10.TabIndex = 4;
			label10.Text = "Số điện thoại:";
			// 
			// txtHinhThuc
			// 
			txtHinhThuc.AutoSize = true;
			txtHinhThuc.Font = new Font("Times New Roman", 12F);
			txtHinhThuc.ForeColor = Color.Black;
			txtHinhThuc.Location = new Point(29, 494);
			txtHinhThuc.Name = "txtHinhThuc";
			txtHinhThuc.Size = new Size(166, 22);
			txtHinhThuc.TabIndex = 13;
			txtHinhThuc.Text = "Hình thức làm việc:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Times New Roman", 12F);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(18, 39);
			label6.Name = "label6";
			label6.Size = new Size(122, 22);
			label6.TabIndex = 3;
			label6.Text = "Mã nhân viên:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Times New Roman", 12F);
			label7.ForeColor = Color.Black;
			label7.Location = new Point(29, 444);
			label7.Name = "label7";
			label7.Size = new Size(87, 22);
			label7.TabIndex = 12;
			label7.Text = "Giới tính:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Times New Roman", 12F);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(22, 401);
			label5.Name = "label5";
			label5.Size = new Size(94, 22);
			label5.TabIndex = 10;
			label5.Text = "Ngày sinh:";
			// 
			// txtCoSo
			// 
			txtCoSo.Location = new Point(201, 352);
			txtCoSo.Name = "txtCoSo";
			txtCoSo.Size = new Size(194, 34);
			txtCoSo.TabIndex = 7;
			// 
			// txtVaiTro
			// 
			txtVaiTro.Location = new Point(201, 125);
			txtVaiTro.Name = "txtVaiTro";
			txtVaiTro.Size = new Size(194, 34);
			txtVaiTro.TabIndex = 5;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(201, 80);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(194, 34);
			txtHoTen.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Times New Roman", 12F);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(22, 357);
			label4.Name = "label4";
			label4.Size = new Size(140, 22);
			label4.TabIndex = 3;
			label4.Text = "Cơ sở đang làm:";
			// 
			// txtSoTK
			// 
			txtSoTK.AutoSize = true;
			txtSoTK.Font = new Font("Times New Roman", 12F);
			txtSoTK.ForeColor = Color.Black;
			txtSoTK.Location = new Point(18, 270);
			txtSoTK.Name = "txtSoTK";
			txtSoTK.Size = new Size(113, 22);
			txtSoTK.TabIndex = 2;
			txtSoTK.Text = "Số tài khoản:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 12F);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(18, 137);
			label2.Name = "label2";
			label2.Size = new Size(69, 22);
			label2.TabIndex = 1;
			label2.Text = "Vai trò:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 12F);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(18, 89);
			label1.Name = "label1";
			label1.Size = new Size(68, 22);
			label1.TabIndex = 0;
			label1.Text = "Họ tên:";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = Color.White;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.87234F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.12766F));
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 72.937294F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.062706F));
			tableLayoutPanel1.Size = new Size(1175, 909);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// txtSoTaiKhoan
			// 
			txtSoTaiKhoan.Location = new Point(201, 268);
			txtSoTaiKhoan.Name = "txtSoTaiKhoan";
			txtSoTaiKhoan.Size = new Size(194, 34);
			txtSoTaiKhoan.TabIndex = 24;
			// 
			// form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(1175, 909);
			Controls.Add(label9);
			Controls.Add(panel1);
			Name = "form2";
			Text = "form2";
			WindowState = FormWindowState.Maximized;
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvLichLamViec).EndInit();
			panel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DateTimePicker dateTimePicker2;
		private RadioButton radioButton4;
        private GroupBox groupBox2;
        private Button btnXemPhieuLuong;
        private Button btnXemBangLuong;
        private DataGridView dgvLichLamViec;
        private DataGridViewTextBoxColumn colThu;
        private DataGridViewTextBoxColumn colCalam;
        private DataGridViewTextBoxColumn colThoigian;
        private Label label9;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Button btnLuu;
        private Button btnChinhSua;
        private TextBox txtMaCoSo;
        private TextBox txtMaNV;
        private Label label12;
        private TextBox txtCCCD;
        private RadioButton rdoPartTime;
        private TextBox txtSDT;
        private Label label11;
        private RadioButton rdoFullTime;
        private RadioButton radioButton2;
        private RadioButton rdoNam;
        private Label label10;
        private Label txtHinhThuc;
        private Label label6;
        private Label label7;
        private Label label5;
        private DateTimePicker dtpNamSinh;
        private TextBox txtCoSo;
        private TextBox btnSoTaiKhoan;
        private TextBox txtVaiTro;
        private TextBox txtHoTen;
        private Label label4;
        private Label txtSoTK;
        private Label label2;
        private Label label1;
		private RadioButton rdoNu;
		private DateTimePicker dtpNgaySinh;
		private TextBox txtSoTaiKhoan;
	}
}