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
            tbxMnv = new TextBox();
            label1 = new Label();
            tbxTnv = new TextBox();
            label4 = new Label();
            label8 = new Label();
            tbxCon = new TextBox();
            tbxToida = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            btnDuyet = new Button();
            dgvXinNghiPhep = new DataGridView();
            MaDon = new DataGridViewTextBoxColumn();
            LoaiPhep = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            btnTuChoi = new Button();
            label14 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnXinNghi = new Button();
            label6 = new Label();
            cboxLnp = new ComboBox();
            tbxLydo = new TextBox();
            label5 = new Label();
            cboxCaNghi2 = new ComboBox();
            datetime1 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            datetime2 = new DateTimePicker();
            cboxCanghi1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXinNghiPhep).BeginInit();
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
            tableLayoutPanel1.Controls.Add(tbxMnv, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(tbxTnv, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(tbxCon, 3, 1);
            tableLayoutPanel1.Controls.Add(tbxToida, 3, 2);
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
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(243, 67);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(514, 112);
            label3.Name = "label3";
            label3.Size = new Size(391, 68);
            label3.TabIndex = 3;
            label3.Text = "Số buổi nghỉ tối đa trong tháng:";
            // 
            // tbxMnv
            // 
            tbxMnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMnv.Font = new Font("Segoe UI", 14F);
            tbxMnv.Location = new Point(252, 115);
            tbxMnv.Name = "tbxMnv";
            tbxMnv.Size = new Size(256, 45);
            tbxMnv.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 112);
            label1.Name = "label1";
            label1.Size = new Size(243, 68);
            label1.TabIndex = 1;
            label1.Text = "Mã Nhân Viên:";
            // 
            // tbxTnv
            // 
            tbxTnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxTnv.Font = new Font("Segoe UI", 14F);
            tbxTnv.Location = new Point(252, 48);
            tbxTnv.Name = "tbxTnv";
            tbxTnv.Size = new Size(256, 45);
            tbxTnv.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(514, 45);
            label4.Name = "label4";
            label4.Size = new Size(391, 67);
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
            label8.Size = new Size(1030, 45);
            label8.TabIndex = 9;
            label8.Text = "THÔNG TIN VÀ HẠN MỨC";
            // 
            // tbxCon
            // 
            tbxCon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxCon.Font = new Font("Segoe UI", 14F);
            tbxCon.Location = new Point(911, 48);
            tbxCon.Name = "tbxCon";
            tbxCon.Size = new Size(122, 45);
            tbxCon.TabIndex = 10;
            // 
            // tbxToida
            // 
            tbxToida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxToida.Font = new Font("Segoe UI", 14F);
            tbxToida.Location = new Point(911, 115);
            tbxToida.Name = "tbxToida";
            tbxToida.Size = new Size(122, 45);
            tbxToida.TabIndex = 11;
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
            tableLayoutPanel2.Controls.Add(dgvXinNghiPhep, 0, 0);
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
            // dgvXinNghiPhep
            // 
            dgvXinNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXinNghiPhep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXinNghiPhep.Columns.AddRange(new DataGridViewColumn[] { MaDon, LoaiPhep, LyDo, TrangThai });
            tableLayoutPanel2.SetColumnSpan(dgvXinNghiPhep, 3);
            dgvXinNghiPhep.Dock = DockStyle.Fill;
            dgvXinNghiPhep.Location = new Point(3, 3);
            dgvXinNghiPhep.Name = "dgvXinNghiPhep";
            dgvXinNghiPhep.ReadOnly = true;
            dgvXinNghiPhep.RowHeadersWidth = 62;
            dgvXinNghiPhep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXinNghiPhep.Size = new Size(1024, 104);
            dgvXinNghiPhep.TabIndex = 0;
            // 
            // MaDon
            // 
            MaDon.DataPropertyName = "MaDon";
            MaDon.HeaderText = "Mã Đơn";
            MaDon.MinimumWidth = 8;
            MaDon.Name = "MaDon";
            MaDon.ReadOnly = true;
            // 
            // LoaiPhep
            // 
            LoaiPhep.DataPropertyName = "LoaiNghiPhep";
            LoaiPhep.HeaderText = "Loại Phép";
            LoaiPhep.MinimumWidth = 8;
            LoaiPhep.Name = "LoaiPhep";
            LoaiPhep.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý Do";
            LyDo.MinimumWidth = 8;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThaiDuyet";
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
            tableLayoutPanel3.Controls.Add(cboxLnp, 2, 4);
            tableLayoutPanel3.Controls.Add(tbxLydo, 0, 4);
            tableLayoutPanel3.Controls.Add(label5, 2, 3);
            tableLayoutPanel3.Controls.Add(cboxCaNghi2, 3, 2);
            tableLayoutPanel3.Controls.Add(datetime1, 0, 2);
            tableLayoutPanel3.Controls.Add(label12, 0, 3);
            tableLayoutPanel3.Controls.Add(label13, 3, 1);
            tableLayoutPanel3.Controls.Add(label11, 1, 1);
            tableLayoutPanel3.Controls.Add(datetime2, 2, 2);
            tableLayoutPanel3.Controls.Add(cboxCanghi1, 1, 2);
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
            btnXinNghi.Click += btnXinNghi_Click;
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
            // cboxLnp
            // 
            cboxLnp.Dock = DockStyle.Fill;
            cboxLnp.FormattingEnabled = true;
            cboxLnp.Items.AddRange(new object[] { "Nghỉ phép năm", "Nghỉ đột xuất (việc riêng)", "Nghỉ ốm", "Nghỉ không lương" });
            cboxLnp.Location = new Point(517, 167);
            cboxLnp.Name = "cboxLnp";
            cboxLnp.Size = new Size(251, 43);
            cboxLnp.TabIndex = 8;
            // 
            // tbxLydo
            // 
            tbxLydo.Dock = DockStyle.Fill;
            tbxLydo.Font = new Font("Segoe UI", 14F);
            tbxLydo.Location = new Point(3, 167);
            tbxLydo.Multiline = true;
            tbxLydo.Name = "tbxLydo";
            tbxLydo.Size = new Size(251, 81);
            tbxLydo.TabIndex = 12;
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
            // cboxCaNghi2
            // 
            cboxCaNghi2.Dock = DockStyle.Fill;
            cboxCaNghi2.Font = new Font("Segoe UI", 14F);
            cboxCaNghi2.FormattingEnabled = true;
            cboxCaNghi2.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            cboxCaNghi2.Location = new Point(774, 85);
            cboxCaNghi2.Name = "cboxCaNghi2";
            cboxCaNghi2.Size = new Size(253, 46);
            cboxCaNghi2.TabIndex = 15;
            // 
            // datetime1
            // 
            datetime1.CustomFormat = "dd/MM/yyyy";
            datetime1.Dock = DockStyle.Fill;
            datetime1.Font = new Font("Segoe UI", 14F);
            datetime1.Format = DateTimePickerFormat.Custom;
            datetime1.Location = new Point(3, 85);
            datetime1.Name = "datetime1";
            datetime1.Size = new Size(251, 45);
            datetime1.TabIndex = 10;
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
            // datetime2
            // 
            datetime2.CustomFormat = "dd/MM/yyyy";
            datetime2.Dock = DockStyle.Fill;
            datetime2.Font = new Font("Segoe UI", 14F);
            datetime2.Format = DateTimePickerFormat.Custom;
            datetime2.Location = new Point(517, 85);
            datetime2.Name = "datetime2";
            datetime2.Size = new Size(251, 45);
            datetime2.TabIndex = 11;
            // 
            // cboxCanghi1
            // 
            cboxCanghi1.Dock = DockStyle.Fill;
            cboxCanghi1.Font = new Font("Segoe UI", 14F);
            cboxCanghi1.FormattingEnabled = true;
            cboxCanghi1.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            cboxCanghi1.Location = new Point(260, 85);
            cboxCanghi1.Name = "cboxCanghi1";
            cboxCanghi1.Size = new Size(251, 46);
            cboxCanghi1.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)dgvXinNghiPhep).EndInit();
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
        private TextBox tbxMnv;
        private Label label1;
        private TextBox tbxTnv;
        private TextBox tbxCon;
        private TextBox tbxToida;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private Button btnDuyet;
        private DataGridView dgvXinNghiPhep;
        private Button btnTuChoi;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnXinNghi;
        private Label label6;
        private ComboBox cboxLnp;
        private TextBox tbxLydo;
        private Label label5;
        private ComboBox cboxCaNghi2;
        private DateTimePicker datetime1;
        private Label label12;
        private Label label13;
        private Label label11;
        private DateTimePicker datetime2;
        private ComboBox cboxCanghi1;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn MaDon;
        private DataGridViewTextBoxColumn LoaiPhep;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThai;
    }
}