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
            groupBox3 = new GroupBox();
            dgvXinNghiPhep = new DataGridView();
            MaDon = new DataGridViewTextBoxColumn();
            LoaiNghiPhep = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            TrangThaiDuyet = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnXinNghi = new Button();
            cboxCanghi2 = new ComboBox();
            cboxLnp = new ComboBox();
            datetime2 = new DateTimePicker();
            label21 = new Label();
            cboxCanghi1 = new ComboBox();
            label20 = new Label();
            tbxLydo = new TextBox();
            label19 = new Label();
            label13 = new Label();
            label18 = new Label();
            label17 = new Label();
            datetime1 = new DateTimePicker();
            label9 = new Label();
            groupBox1 = new GroupBox();
            tbxToida = new TextBox();
            tbxChucVu = new TextBox();
            tbxCoSo = new TextBox();
            label16 = new Label();
            label15 = new Label();
            tbxCon = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbxMnv = new TextBox();
            tbxTnv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXinNghiPhep).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.SetColumnSpan(label7, 2);
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(1262, 93);
            label7.TabIndex = 19;
            label7.Text = "XIN NGHỈ PHÉP";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.61832F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.38168F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(1268, 937);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // groupBox3
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dgvXinNghiPhep);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 564);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1262, 370);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lịch sử tạo đơn";
            // 
            // dgvXinNghiPhep
            // 
            dgvXinNghiPhep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvXinNghiPhep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvXinNghiPhep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXinNghiPhep.Columns.AddRange(new DataGridViewColumn[] { MaDon, LoaiNghiPhep, LyDo, TrangThaiDuyet });
            dgvXinNghiPhep.Location = new Point(3, 47);
            dgvXinNghiPhep.Name = "dgvXinNghiPhep";
            dgvXinNghiPhep.ReadOnly = true;
            dgvXinNghiPhep.RowHeadersWidth = 62;
            dgvXinNghiPhep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXinNghiPhep.Size = new Size(1256, 320);
            dgvXinNghiPhep.TabIndex = 3;
            // 
            // MaDon
            // 
            MaDon.DataPropertyName = "MaDonNP";
            MaDon.HeaderText = "Mã Đơn";
            MaDon.MinimumWidth = 8;
            MaDon.Name = "MaDon";
            MaDon.ReadOnly = true;
            // 
            // LoaiNghiPhep
            // 
            LoaiNghiPhep.DataPropertyName = "LoaiNghiPhep";
            LoaiNghiPhep.HeaderText = "Loại Phép";
            LoaiNghiPhep.MinimumWidth = 8;
            LoaiNghiPhep.Name = "LoaiNghiPhep";
            LoaiNghiPhep.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý Do";
            LyDo.MinimumWidth = 8;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // TrangThaiDuyet
            // 
            TrangThaiDuyet.DataPropertyName = "TrangThaiDuyet";
            TrangThaiDuyet.HeaderText = "Trạng Thái Duyệt";
            TrangThaiDuyet.MinimumWidth = 8;
            TrangThaiDuyet.Name = "TrangThaiDuyet";
            TrangThaiDuyet.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnXinNghi);
            groupBox2.Controls.Add(cboxCanghi2);
            groupBox2.Controls.Add(cboxLnp);
            groupBox2.Controls.Add(datetime2);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(cboxCanghi1);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(tbxLydo);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(datetime1);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(632, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 462);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đơn nghỉ phép";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 388);
            button1.Name = "button1";
            button1.Size = new Size(188, 64);
            button1.TabIndex = 29;
            button1.Text = "Hủy Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnXinNghi
            // 
            btnXinNghi.Anchor = AnchorStyles.Right;
            btnXinNghi.BackColor = SystemColors.HotTrack;
            btnXinNghi.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXinNghi.ForeColor = Color.White;
            btnXinNghi.Location = new Point(426, 388);
            btnXinNghi.Name = "btnXinNghi";
            btnXinNghi.Size = new Size(169, 64);
            btnXinNghi.TabIndex = 28;
            btnXinNghi.Text = "Tạo Đơn";
            btnXinNghi.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnXinNghi.UseVisualStyleBackColor = false;
            btnXinNghi.Click += btnXinNghi_Click;
            // 
            // cboxCanghi2
            // 
            cboxCanghi2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboxCanghi2.Font = new Font("Calibri", 14F);
            cboxCanghi2.FormattingEnabled = true;
            cboxCanghi2.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            cboxCanghi2.Location = new Point(227, 325);
            cboxCanghi2.Name = "cboxCanghi2";
            cboxCanghi2.Size = new Size(395, 36);
            cboxCanghi2.TabIndex = 27;
            // 
            // cboxLnp
            // 
            cboxLnp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboxLnp.Font = new Font("Calibri", 14F);
            cboxLnp.FormattingEnabled = true;
            cboxLnp.Items.AddRange(new object[] { "Nghỉ phép năm", "Nghỉ đột xuất (việc riêng)", "Nghỉ ốm", "Nghỉ không lương" });
            cboxLnp.Location = new Point(227, 60);
            cboxLnp.Name = "cboxLnp";
            cboxLnp.Size = new Size(395, 36);
            cboxLnp.TabIndex = 26;
            // 
            // datetime2
            // 
            datetime2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datetime2.CustomFormat = "dd/MM/yyyy";
            datetime2.Font = new Font("Calibri", 14F);
            datetime2.Format = DateTimePickerFormat.Custom;
            datetime2.Location = new Point(227, 272);
            datetime2.Name = "datetime2";
            datetime2.Size = new Size(395, 36);
            datetime2.TabIndex = 25;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(20, 60);
            label21.Name = "label21";
            label21.Size = new Size(159, 31);
            label21.TabIndex = 0;
            label21.Text = "Loại nghỉ phép";
            // 
            // cboxCanghi1
            // 
            cboxCanghi1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboxCanghi1.Font = new Font("Calibri", 14F);
            cboxCanghi1.FormattingEnabled = true;
            cboxCanghi1.Items.AddRange(new object[] { "Ca sáng", "Ca chiều", "Ca tối" });
            cboxCanghi1.Location = new Point(227, 219);
            cboxCanghi1.Name = "cboxCanghi1";
            cboxCanghi1.Size = new Size(395, 36);
            cboxCanghi1.TabIndex = 23;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label20.Location = new Point(20, 113);
            label20.Name = "label20";
            label20.Size = new Size(66, 31);
            label20.TabIndex = 0;
            label20.Text = "Lý do";
            // 
            // tbxLydo
            // 
            tbxLydo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxLydo.Font = new Font("Calibri", 14F);
            tbxLydo.Location = new Point(227, 113);
            tbxLydo.Multiline = true;
            tbxLydo.Name = "tbxLydo";
            tbxLydo.Size = new Size(395, 42);
            tbxLydo.TabIndex = 22;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label19.Location = new Point(20, 272);
            label19.Name = "label19";
            label19.Size = new Size(144, 31);
            label19.TabIndex = 0;
            label19.Text = "Đến ngày/Ca";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label13.Location = new Point(20, 325);
            label13.Name = "label13";
            label13.Size = new Size(91, 31);
            label13.TabIndex = 0;
            label13.Text = "Ca nghỉ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label18.Location = new Point(20, 219);
            label18.Name = "label18";
            label18.Size = new Size(91, 31);
            label18.TabIndex = 0;
            label18.Text = "Ca nghỉ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label17.Location = new Point(20, 166);
            label17.Name = "label17";
            label17.Size = new Size(129, 31);
            label17.TabIndex = 0;
            label17.Text = "Từ ngày/Ca";
            // 
            // datetime1
            // 
            datetime1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datetime1.CustomFormat = "dd/MM/yyyy";
            datetime1.Font = new Font("Calibri", 14F);
            datetime1.Format = DateTimePickerFormat.Custom;
            datetime1.Location = new Point(227, 166);
            datetime1.Name = "datetime1";
            datetime1.Size = new Size(395, 36);
            datetime1.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(161, 15);
            label9.Name = "label9";
            label9.Size = new Size(0, 37);
            label9.TabIndex = 5;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tbxToida);
            groupBox1.Controls.Add(tbxChucVu);
            groupBox1.Controls.Add(tbxCoSo);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tbxCon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxMnv);
            groupBox1.Controls.Add(tbxTnv);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 462);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin và hạn mức";
            // 
            // tbxToida
            // 
            tbxToida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxToida.Font = new Font("Calibri", 14F);
            tbxToida.Location = new Point(251, 272);
            tbxToida.Name = "tbxToida";
            tbxToida.ReadOnly = true;
            tbxToida.Size = new Size(366, 36);
            tbxToida.TabIndex = 23;
            // 
            // tbxChucVu
            // 
            tbxChucVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxChucVu.Font = new Font("Calibri", 14F);
            tbxChucVu.Location = new Point(251, 219);
            tbxChucVu.Name = "tbxChucVu";
            tbxChucVu.ReadOnly = true;
            tbxChucVu.Size = new Size(366, 36);
            tbxChucVu.TabIndex = 22;
            // 
            // tbxCoSo
            // 
            tbxCoSo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxCoSo.Font = new Font("Calibri", 14F);
            tbxCoSo.Location = new Point(251, 166);
            tbxCoSo.Name = "tbxCoSo";
            tbxCoSo.ReadOnly = true;
            tbxCoSo.Size = new Size(366, 36);
            tbxCoSo.TabIndex = 21;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label16.Location = new Point(9, 219);
            label16.Name = "label16";
            label16.Size = new Size(98, 31);
            label16.TabIndex = 0;
            label16.Text = "Chức Vụ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label15.Location = new Point(9, 166);
            label15.Name = "label15";
            label15.Size = new Size(113, 31);
            label15.TabIndex = 0;
            label15.Text = "Tên cơ sở ";
            // 
            // tbxCon
            // 
            tbxCon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxCon.Font = new Font("Calibri", 14F);
            tbxCon.Location = new Point(251, 325);
            tbxCon.Name = "tbxCon";
            tbxCon.ReadOnly = true;
            tbxCon.Size = new Size(366, 36);
            tbxCon.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.Location = new Point(9, 325);
            label4.Name = "label4";
            label4.Size = new Size(207, 31);
            label4.TabIndex = 0;
            label4.Text = "Số buổi nghỉ còn lại";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(9, 272);
            label3.Name = "label3";
            label3.Size = new Size(197, 31);
            label3.TabIndex = 0;
            label3.Text = "Số buổi nghỉ tối đa";
            // 
            // tbxMnv
            // 
            tbxMnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxMnv.Font = new Font("Calibri", 14F);
            tbxMnv.Location = new Point(251, 60);
            tbxMnv.Name = "tbxMnv";
            tbxMnv.ReadOnly = true;
            tbxMnv.Size = new Size(366, 36);
            tbxMnv.TabIndex = 14;
            // 
            // tbxTnv
            // 
            tbxTnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxTnv.Font = new Font("Calibri", 14F);
            tbxTnv.Location = new Point(251, 113);
            tbxTnv.Name = "tbxTnv";
            tbxTnv.ReadOnly = true;
            tbxTnv.Size = new Size(366, 36);
            tbxTnv.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(9, 113);
            label2.Name = "label2";
            label2.Size = new Size(161, 31);
            label2.TabIndex = 0;
            label2.Text = "Tên Nhân Viên";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(50, 12);
            label8.Name = "label8";
            label8.Size = new Size(0, 37);
            label8.TabIndex = 10;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fXinNghiPhep
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1268, 937);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fXinNghiPhep";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XinNghiPhep";
            WindowState = FormWindowState.Maximized;
            FormClosed += fXinNghiPhep_FormClosed;
            Load += fXinNghiPhep_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXinNghiPhep).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private Button btnXinNghi;
        private ComboBox cboxCanghi2;
        private ComboBox cboxLnp;
        private DateTimePicker datetime2;
        private Label label21;
        private ComboBox cboxCanghi1;
        private Label label20;
        private TextBox tbxLydo;
        private Label label19;
        private Label label13;
        private Label label18;
        private Label label17;
        private DateTimePicker datetime1;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox tbxChucVu;
        private TextBox tbxCoSo;
        private Label label16;
        private Label label15;
        private TextBox tbxCon;
        private Label label4;
        private Label label3;
        private TextBox tbxMnv;
        private TextBox tbxTnv;
        private Label label1;
        private Label label2;
        private Label label8;
        private TextBox tbxToida;
        private GroupBox groupBox3;
        private DataGridView dgvXinNghiPhep;
        private Button button1;
        private DataGridViewTextBoxColumn MaDon;
        private DataGridViewTextBoxColumn LoaiNghiPhep;
        private DataGridViewTextBoxColumn LyDo;
        private DataGridViewTextBoxColumn TrangThaiDuyet;
    }
}