namespace nhom2_quanlynhansu
{
    partial class fXinNghiPhep
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
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tbxTenNhanVien = new TextBox();
            label1 = new Label();
            tbxMaNhanVien = new TextBox();
            label4 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            btnDuyet = new Button();
            dataGridView1 = new DataGridView();
            MaDon = new DataGridViewTextBoxColumn();
            LoaiPhep = new DataGridViewTextBoxColumn();
            NgayNghi = new DataGridViewTextBoxColumn();
            CaNghi = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            btnTuChoi = new Button();
            label14 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnXinNghi = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(1036, 52);
            label7.TabIndex = 3;
            label7.Text = "QUẢN LÝ NGHỈ PHÉP";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.03475F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2895756F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3204651F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.3552122F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 2);
            tableLayoutPanel1.Controls.Add(tbxTenNhanVien, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(tbxMaNhanVien, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 2);
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1036, 180);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(243, 71);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(514, 108);
            label3.Name = "label3";
            label3.Size = new Size(391, 72);
            label3.TabIndex = 3;
            label3.Text = "Số buổi nghỉ tối đa trong tháng:";
            // 
            // tbxTenNhanVien
            // 
            tbxTenNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxTenNhanVien.Font = new Font("Segoe UI", 14F);
            tbxTenNhanVien.Location = new Point(252, 111);
            tbxTenNhanVien.Name = "tbxTenNhanVien";
            tbxTenNhanVien.ReadOnly = true;
            tbxTenNhanVien.Size = new Size(256, 39);
            tbxTenNhanVien.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 108);
            label1.Name = "label1";
            label1.Size = new Size(243, 72);
            label1.TabIndex = 1;
            label1.Text = "Mã Nhân Viên:";
            // 
            // tbxMaNhanVien
            // 
            tbxMaNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMaNhanVien.Font = new Font("Segoe UI", 14F);
            tbxMaNhanVien.Location = new Point(252, 40);
            tbxMaNhanVien.Name = "tbxMaNhanVien";
            tbxMaNhanVien.ReadOnly = true;
            tbxMaNhanVien.Size = new Size(256, 39);
            tbxMaNhanVien.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(514, 37);
            label4.Name = "label4";
            label4.Size = new Size(391, 71);
            label4.TabIndex = 4;
            label4.Text = "Số buổi nghỉ còn lại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.SetColumnSpan(label8, 4);
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(1030, 37);
            label8.TabIndex = 9;
            label8.Text = "THÔNG TIN VÀ HẠN MỨC";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(911, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 39);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 14F);
            textBox4.Location = new Point(911, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 39);
            textBox4.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(textBox2, 2, 2);
            tableLayoutPanel2.Controls.Add(btnDuyet, 0, 2);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnTuChoi, 1, 2);
            tableLayoutPanel2.Controls.Add(label14, 2, 1);
            tableLayoutPanel2.Location = new Point(6, 495);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.2449F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8775511F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(1030, 210);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(689, 142);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 65);
            textBox2.TabIndex = 17;
            // 
            // btnDuyet
            // 
            btnDuyet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDuyet.BackColor = Color.FromArgb(0, 0, 192);
            btnDuyet.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDuyet.ForeColor = Color.White;
            btnDuyet.Location = new Point(3, 142);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(337, 65);
            btnDuyet.TabIndex = 0;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaDon, LoaiPhep, NgayNghi, CaNghi, LyDo, TrangThai });
            tableLayoutPanel2.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1024, 104);
            dataGridView1.TabIndex = 0;
            // 
            // MaDon
            // 
            MaDon.HeaderText = "Mã Đơn";
            MaDon.MinimumWidth = 8;
            MaDon.Name = "MaDon";
            MaDon.ReadOnly = true;
            // 
            // LoaiPhep
            // 
            LoaiPhep.HeaderText = "Loại Phép";
            LoaiPhep.MinimumWidth = 8;
            LoaiPhep.Name = "LoaiPhep";
            LoaiPhep.ReadOnly = true;
            // 
            // NgayNghi
            // 
            NgayNghi.HeaderText = "Ngày Nghỉ";
            NgayNghi.MinimumWidth = 8;
            NgayNghi.Name = "NgayNghi";
            NgayNghi.ReadOnly = true;
            // 
            // CaNghi
            // 
            CaNghi.HeaderText = "Ca Nghỉ";
            CaNghi.MinimumWidth = 8;
            CaNghi.Name = "CaNghi";
            CaNghi.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.HeaderText = "Lý Do";
            LyDo.MinimumWidth = 8;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng Thái Duyệt";
            TrangThai.MinimumWidth = 8;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // btnTuChoi
            // 
            btnTuChoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTuChoi.BackColor = Color.White;
            btnTuChoi.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnTuChoi.ForeColor = Color.FromArgb(0, 0, 192);
            btnTuChoi.Location = new Point(346, 142);
            btnTuChoi.Name = "btnTuChoi";
            btnTuChoi.Size = new Size(337, 65);
            btnTuChoi.TabIndex = 1;
            btnTuChoi.Text = "Từ Chối";
            btnTuChoi.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(689, 110);
            label14.Name = "label14";
            label14.Size = new Size(338, 29);
            label14.TabIndex = 16;
            label14.Text = "Lý do từ chối:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnXinNghi, 3, 4);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(comboBox1, 2, 4);
            tableLayoutPanel3.Controls.Add(textBox1, 0, 4);
            tableLayoutPanel3.Controls.Add(label5, 2, 3);
            tableLayoutPanel3.Controls.Add(comboBox3, 3, 2);
            tableLayoutPanel3.Controls.Add(dateTimePicker1, 0, 2);
            tableLayoutPanel3.Controls.Add(label12, 0, 3);
            tableLayoutPanel3.Controls.Add(label13, 3, 1);
            tableLayoutPanel3.Controls.Add(label11, 1, 1);
            tableLayoutPanel3.Controls.Add(dateTimePicker2, 2, 2);
            tableLayoutPanel3.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel3.Controls.Add(label10, 2, 1);
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Location = new Point(6, 241);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(1030, 251);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // btnXinNghi
            // 
            btnXinNghi.BackColor = Color.FromArgb(0, 0, 192);
            btnXinNghi.Dock = DockStyle.Fill;
            btnXinNghi.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXinNghi.ForeColor = Color.White;
            btnXinNghi.Location = new Point(774, 167);
            btnXinNghi.Name = "btnXinNghi";
            btnXinNghi.Size = new Size(253, 81);
            btnXinNghi.TabIndex = 13;
            btnXinNghi.Text = "Xin Nghỉ";
            btnXinNghi.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(3, 41);
            label6.Name = "label6";
            label6.Size = new Size(251, 41);
            label6.TabIndex = 3;
            label6.Text = "Từ ngày/Ca";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nghỉ phép năm", "Nghỉ đột xuất (việc riêng)", "Nghỉ ốm", "Nghỉ không lương" });
            comboBox1.Location = new Point(517, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(3, 167);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 81);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(517, 123);
            label5.Name = "label5";
            label5.Size = new Size(251, 41);
            label5.TabIndex = 2;
            label5.Text = "Loại nghỉ phép";
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.Font = new Font("Segoe UI", 14F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            comboBox3.Location = new Point(774, 85);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(253, 39);
            comboBox3.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 39);
            dateTimePicker1.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label12.Location = new Point(3, 123);
            label12.Name = "label12";
            label12.Size = new Size(251, 41);
            label12.TabIndex = 7;
            label12.Text = "Lý do:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label13.Location = new Point(774, 41);
            label13.Name = "label13";
            label13.Size = new Size(253, 41);
            label13.TabIndex = 14;
            label13.Text = "Ca nghỉ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label11.Location = new Point(260, 41);
            label11.Name = "label11";
            label11.Size = new Size(251, 41);
            label11.TabIndex = 6;
            label11.Text = "Ca nghỉ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Dock = DockStyle.Fill;
            dateTimePicker2.Font = new Font("Segoe UI", 14F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(517, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 39);
            dateTimePicker2.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.Font = new Font("Segoe UI", 14F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            comboBox2.Location = new Point(260, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(251, 39);
            comboBox2.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label10.Location = new Point(517, 41);
            label10.Name = "label10";
            label10.Size = new Size(251, 41);
            label10.TabIndex = 5;
            label10.Text = "Đến ngày/Ca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel3.SetColumnSpan(label9, 4);
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(1024, 41);
            label9.TabIndex = 4;
            label9.Text = "TẠO ĐƠN MỚI";
            // 
            // fXinNghiPhep
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1036, 707);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label7);
            Name = "fXinNghiPhep";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XinNghiPhep";
            WindowState = FormWindowState.Maximized;
            FormClosed += fXinNghiPhep_FormClosed;
            Load += fXinNghiPhep_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxTenNhanVien;
        private Label label1;
        private TextBox tbxMaNhanVien;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private Button btnDuyet;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaDon;
        private DataGridViewTextBoxColumn LoaiPhep;
        private DataGridViewTextBoxColumn NgayNghi;
        private DataGridViewTextBoxColumn CaNghi;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThai;
        private Button btnTuChoi;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnXinNghi;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label13;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Label label10;
        private Label label9;
    }
}