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
            label9 = new Label();
            groupBox1 = new GroupBox();
            cbmcs = new ComboBox();
            tbcsdl = new TextBox();
            cbcs2 = new CheckBox();
            tbvt = new TextBox();
            grpHinhThuc = new GroupBox();
            rdoFullTime = new RadioButton();
            rdoPartTime = new RadioButton();
            grpGioiTinh = new GroupBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            txtSoTaiKhoan = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            btnLuu = new Button();
            txtMaNV = new TextBox();
            label12 = new Label();
            txtCCCD = new TextBox();
            txtSDT = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtSoTK = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            grpHinhThuc.SuspendLayout();
            grpGioiTinh.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientActiveCaption;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(343, 9);
            label9.Name = "label9";
            label9.Size = new Size(348, 31);
            label9.TabIndex = 2;
            label9.Text = "QUẢN LÝ HỒ SƠ NGƯỜI DÙNG";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(cbmcs);
            groupBox1.Controls.Add(tbcsdl);
            groupBox1.Controls.Add(cbcs2);
            groupBox1.Controls.Add(tbvt);
            groupBox1.Controls.Add(grpHinhThuc);
            groupBox1.Controls.Add(grpGioiTinh);
            groupBox1.Controls.Add(txtSoTaiKhoan);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoTK);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1175, 851);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // cbmcs
            // 
            cbmcs.Anchor = AnchorStyles.Top;
            cbmcs.FormattingEnabled = true;
            cbmcs.Items.AddRange(new object[] { "1", "2", "3" });
            cbmcs.Location = new Point(508, 314);
            cbmcs.Name = "cbmcs";
            cbmcs.Size = new Size(151, 36);
            cbmcs.TabIndex = 28;
            // 
            // tbcsdl
            // 
            tbcsdl.Anchor = AnchorStyles.Top;
            tbcsdl.Location = new Point(508, 361);
            tbcsdl.Multiline = true;
            tbcsdl.Name = "tbcsdl";
            tbcsdl.Size = new Size(194, 34);
            tbcsdl.TabIndex = 27;
            // 
            // cbcs2
            // 
            cbcs2.Anchor = AnchorStyles.Top;
            cbcs2.Appearance = Appearance.Button;
            cbcs2.BackColor = Color.White;
            cbcs2.FlatStyle = FlatStyle.Popup;
            cbcs2.Font = new Font("Segoe UI", 12F);
            cbcs2.ForeColor = Color.Black;
            cbcs2.Location = new Point(324, 687);
            cbcs2.Name = "cbcs2";
            cbcs2.Size = new Size(121, 51);
            cbcs2.TabIndex = 20;
            cbcs2.Text = "chỉnh sửa";
            cbcs2.TextAlign = ContentAlignment.MiddleCenter;
            cbcs2.UseVisualStyleBackColor = false;
            cbcs2.CheckedChanged += cbcs2_CheckedChanged;
            // 
            // tbvt
            // 
            tbvt.Anchor = AnchorStyles.Top;
            tbvt.Location = new Point(508, 132);
            tbvt.Multiline = true;
            tbvt.Name = "tbvt";
            tbvt.Size = new Size(194, 34);
            tbvt.TabIndex = 26;
            // 
            // grpHinhThuc
            // 
            grpHinhThuc.Anchor = AnchorStyles.Top;
            grpHinhThuc.Controls.Add(rdoFullTime);
            grpHinhThuc.Controls.Add(rdoPartTime);
            grpHinhThuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grpHinhThuc.Location = new Point(329, 548);
            grpHinhThuc.Name = "grpHinhThuc";
            grpHinhThuc.Size = new Size(430, 101);
            grpHinhThuc.TabIndex = 4;
            grpHinhThuc.TabStop = false;
            grpHinhThuc.Text = "Hình thức làm việc";
            // 
            // rdoFullTime
            // 
            rdoFullTime.AutoSize = true;
            rdoFullTime.Font = new Font("Segoe UI", 12F);
            rdoFullTime.Location = new Point(166, 62);
            rdoFullTime.Name = "rdoFullTime";
            rdoFullTime.Size = new Size(106, 32);
            rdoFullTime.TabIndex = 16;
            rdoFullTime.TabStop = true;
            rdoFullTime.Text = "FullTime";
            rdoFullTime.UseVisualStyleBackColor = true;
            // 
            // rdoPartTime
            // 
            rdoPartTime.AutoSize = true;
            rdoPartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoPartTime.Location = new Point(304, 62);
            rdoPartTime.Name = "rdoPartTime";
            rdoPartTime.Size = new Size(109, 32);
            rdoPartTime.TabIndex = 18;
            rdoPartTime.TabStop = true;
            rdoPartTime.Text = "PartTime";
            rdoPartTime.UseVisualStyleBackColor = true;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Anchor = AnchorStyles.Top;
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grpGioiTinh.Location = new Point(329, 445);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(429, 88);
            grpGioiTinh.TabIndex = 3;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Times New Roman", 12F);
            rdoNam.ForeColor = Color.Black;
            rdoNam.Location = new Point(165, 56);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(73, 26);
            rdoNam.TabIndex = 14;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam ";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoNu.Location = new Point(303, 50);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(60, 32);
            rdoNu.TabIndex = 22;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Anchor = AnchorStyles.Top;
            txtSoTaiKhoan.Location = new Point(508, 272);
            txtSoTaiKhoan.Multiline = true;
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(194, 34);
            txtSoTaiKhoan.TabIndex = 24;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.Top;
            dtpNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaySinh.Location = new Point(508, 405);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 34);
            dtpNgaySinh.TabIndex = 23;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.HotTrack;
            btnLuu.Cursor = Cursors.VSplit;
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(601, 687);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 51);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu thay đổi";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Visible = false;
            btnLuu.Click += btnLuuThayDoi_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Top;
            txtMaNV.Location = new Point(508, 43);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(194, 34);
            txtMaNV.TabIndex = 19;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(328, 314);
            label12.Name = "label12";
            label12.Size = new Size(91, 22);
            label12.TabIndex = 6;
            label12.Text = "Mã cơ sở:";
            // 
            // txtCCCD
            // 
            txtCCCD.Anchor = AnchorStyles.Top;
            txtCCCD.Location = new Point(508, 222);
            txtCCCD.Multiline = true;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(194, 34);
            txtCCCD.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top;
            txtSDT.Location = new Point(508, 173);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 34);
            txtSDT.TabIndex = 7;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(325, 231);
            label11.Name = "label11";
            label11.Size = new Size(69, 22);
            label11.TabIndex = 5;
            label11.Text = "CCCD:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(325, 182);
            label10.Name = "label10";
            label10.Size = new Size(120, 22);
            label10.TabIndex = 4;
            label10.Text = "Số điện thoại:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(325, 43);
            label6.Name = "label6";
            label6.Size = new Size(122, 22);
            label6.TabIndex = 3;
            label6.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(329, 405);
            label5.Name = "label5";
            label5.Size = new Size(94, 22);
            label5.TabIndex = 10;
            label5.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top;
            txtHoTen.Location = new Point(508, 84);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(194, 34);
            txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(329, 361);
            label4.Name = "label4";
            label4.Size = new Size(140, 22);
            label4.TabIndex = 3;
            label4.Text = "Cơ sở đang làm:";
            // 
            // txtSoTK
            // 
            txtSoTK.Anchor = AnchorStyles.Top;
            txtSoTK.AutoSize = true;
            txtSoTK.Font = new Font("Times New Roman", 12F);
            txtSoTK.ForeColor = Color.Black;
            txtSoTK.Location = new Point(325, 274);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(113, 22);
            txtSoTK.TabIndex = 2;
            txtSoTK.Text = "Số tài khoản:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(325, 141);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 1;
            label2.Text = "Vai trò:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(325, 93);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Họ tên:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1175, 58);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 851);
            panel1.TabIndex = 29;
            // 
            // FormQLHS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1175, 909);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormQLHS";
            Text = "form2";
            WindowState = FormWindowState.Maximized;
            Load += FormQLHS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpHinhThuc.ResumeLayout(false);
            grpHinhThuc.PerformLayout();
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dateTimePicker2;
		private RadioButton radioButton4;
        private Label label9;
        private RadioButton radioButton2;
        private DateTimePicker dtpNamSinh;
        private TextBox btnSoTaiKhoan;
        private GroupBox groupBox1;
        private ComboBox cbmcs;
        private TextBox tbcsdl;
        private CheckBox cbcs2;
        private TextBox tbvt;
        private GroupBox grpHinhThuc;
        private RadioButton rdoFullTime;
        private RadioButton rdoPartTime;
        private GroupBox grpGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private TextBox txtSoTaiKhoan;
        private DateTimePicker dtpNgaySinh;
        private Button btnLuu;
        private TextBox txtMaNV;
        private Label label12;
        private TextBox txtCCCD;
        private TextBox txtSDT;
        private Label label11;
        private Label label10;
        private Label label6;
        private Label label5;
        private TextBox txtHoTen;
        private Label label4;
        private Label txtSoTK;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}