namespace nhom2_quanlynhansu
{
    partial class fTamUngLuong
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
            groupBox3 = new GroupBox();
            dgvLichSu = new DataGridView();
            MaUngLuong = new DataGridViewTextBoxColumn();
            MaLuong = new DataGridViewTextBoxColumn();
            ThoiGian = new DataGridViewTextBoxColumn();
            SoTienUng = new DataGridViewTextBoxColumn();
            LyDo = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tbxLyDo = new TextBox();
            tbxStchu = new TextBox();
            tbxStso = new TextBox();
            btnHuy = new Button();
            btnGui = new Button();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            datetime = new DateTimePicker();
            label6 = new Label();
            groupBox1 = new GroupBox();
            tbxConlai = new TextBox();
            label9 = new Label();
            tbxLcb = new TextBox();
            label11 = new Label();
            tbxLtt = new TextBox();
            label5 = new Label();
            tbxDu = new TextBox();
            label4 = new Label();
            tbxHsl = new TextBox();
            tbxSnc = new TextBox();
            label16 = new Label();
            label15 = new Label();
            tbxTnv = new TextBox();
            label3 = new Label();
            tbxMnv = new TextBox();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel4.SetColumnSpan(groupBox3, 2);
            groupBox3.Controls.Add(dgvLichSu);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic);
            groupBox3.Location = new Point(2, 563);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1264, 372);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lịch sử tạo đơn";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dgvLichSu
            // 
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Columns.AddRange(new DataGridViewColumn[] { MaUngLuong, MaLuong, ThoiGian, SoTienUng, LyDo });
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.Location = new Point(2, 39);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.RowHeadersWidth = 62;
            dgvLichSu.Size = new Size(1260, 331);
            dgvLichSu.TabIndex = 1;
            // 
            // MaUngLuong
            // 
            MaUngLuong.DataPropertyName = "MaUngLuong";
            MaUngLuong.HeaderText = "Mã ứng";
            MaUngLuong.MinimumWidth = 8;
            MaUngLuong.Name = "MaUngLuong";
            MaUngLuong.ReadOnly = true;
            // 
            // MaLuong
            // 
            MaLuong.DataPropertyName = "MaLuong";
            MaLuong.HeaderText = "Mã Lương";
            MaLuong.MinimumWidth = 8;
            MaLuong.Name = "MaLuong";
            MaLuong.ReadOnly = true;
            // 
            // ThoiGian
            // 
            ThoiGian.DataPropertyName = "ThoiGian";
            ThoiGian.HeaderText = "Thời gian";
            ThoiGian.MinimumWidth = 8;
            ThoiGian.Name = "ThoiGian";
            ThoiGian.ReadOnly = true;
            // 
            // SoTienUng
            // 
            SoTienUng.DataPropertyName = "SoTienUng";
            SoTienUng.HeaderText = "Số Tiền Ứng";
            SoTienUng.MinimumWidth = 8;
            SoTienUng.Name = "SoTienUng";
            SoTienUng.ReadOnly = true;
            // 
            // LyDo
            // 
            LyDo.DataPropertyName = "LyDo";
            LyDo.HeaderText = "Lý do";
            LyDo.MinimumWidth = 8;
            LyDo.Name = "LyDo";
            LyDo.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel4.Controls.Add(groupBox2, 1, 1);
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Size = new Size(1268, 937);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel4.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Top;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1264, 44);
            label1.TabIndex = 10;
            label1.Text = "TẠM ỨNG LƯƠNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(tbxLyDo);
            groupBox2.Controls.Add(tbxStchu);
            groupBox2.Controls.Add(tbxStso);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnGui);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(datetime);
            groupBox2.Controls.Add(label6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(636, 95);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(630, 464);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đơn ứng lương";
            // 
            // tbxLyDo
            // 
            tbxLyDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxLyDo.Font = new Font("Calibri", 14F);
            tbxLyDo.Location = new Point(179, 186);
            tbxLyDo.Margin = new Padding(2);
            tbxLyDo.Name = "tbxLyDo";
            tbxLyDo.Size = new Size(447, 36);
            tbxLyDo.TabIndex = 27;
            // 
            // tbxStchu
            // 
            tbxStchu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxStchu.Font = new Font("Calibri", 14F);
            tbxStchu.Location = new Point(179, 134);
            tbxStchu.Margin = new Padding(2);
            tbxStchu.Name = "tbxStchu";
            tbxStchu.Size = new Size(447, 36);
            tbxStchu.TabIndex = 25;
            // 
            // tbxStso
            // 
            tbxStso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxStso.Font = new Font("Calibri", 14F);
            tbxStso.Location = new Point(179, 82);
            tbxStso.Margin = new Padding(2);
            tbxStso.Name = "tbxStso";
            tbxStso.Size = new Size(447, 36);
            tbxStso.TabIndex = 24;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.HotTrack;
            btnHuy.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnHuy.ForeColor = SystemColors.ControlLightLight;
            btnHuy.Location = new Point(79, 309);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(159, 45);
            btnHuy.TabIndex = 23;
            btnHuy.Text = "Hủy đơn";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnGui
            // 
            btnGui.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGui.BackColor = SystemColors.HotTrack;
            btnGui.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnGui.ForeColor = SystemColors.ControlLightLight;
            btnGui.Location = new Point(425, 309);
            btnGui.Margin = new Padding(2);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(160, 45);
            btnGui.TabIndex = 22;
            btnGui.Text = "Gửi đơn";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label10.Location = new Point(5, 198);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 28);
            label10.TabIndex = 21;
            label10.Text = "Lý do";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label8.Location = new Point(5, 143);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(161, 28);
            label8.TabIndex = 19;
            label8.Text = "Số tiền ứng (chữ)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label7.Location = new Point(5, 88);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 28);
            label7.TabIndex = 18;
            label7.Text = "Số tiền ứng (số)";
            // 
            // datetime
            // 
            datetime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            datetime.CalendarFont = new Font("Calibri", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            datetime.CustomFormat = "MM/yyyy";
            datetime.Font = new Font("Calibri", 14F);
            datetime.Format = DateTimePickerFormat.Custom;
            datetime.Location = new Point(179, 30);
            datetime.Margin = new Padding(2);
            datetime.Name = "datetime";
            datetime.Size = new Size(447, 36);
            datetime.TabIndex = 17;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.Location = new Point(5, 32);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 28);
            label6.TabIndex = 16;
            label6.Text = "Tháng ứng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(tbxConlai);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbxLcb);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbxLtt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxDu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbxHsl);
            groupBox1.Controls.Add(tbxSnc);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(tbxTnv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxMnv);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(2, 95);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(630, 464);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xác nhận thông tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbxConlai
            // 
            tbxConlai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxConlai.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxConlai.Location = new Point(215, 348);
            tbxConlai.Margin = new Padding(2);
            tbxConlai.Name = "tbxConlai";
            tbxConlai.ReadOnly = true;
            tbxConlai.Size = new Size(411, 36);
            tbxConlai.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label9.Location = new Point(9, 356);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(162, 28);
            label9.TabIndex = 33;
            label9.Text = "Tiền còn sau ứng";
            // 
            // tbxLcb
            // 
            tbxLcb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxLcb.Font = new Font("Calibri", 14F);
            tbxLcb.Location = new Point(215, 211);
            tbxLcb.Margin = new Padding(2);
            tbxLcb.Name = "tbxLcb";
            tbxLcb.ReadOnly = true;
            tbxLcb.Size = new Size(415, 36);
            tbxLcb.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label11.Location = new Point(9, 215);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(192, 28);
            label11.TabIndex = 31;
            label11.Text = "Lương cơ bản (ngày)\r\n";
            // 
            // tbxLtt
            // 
            tbxLtt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxLtt.Font = new Font("Calibri", 14F);
            tbxLtt.Location = new Point(215, 301);
            tbxLtt.Margin = new Padding(2);
            tbxLtt.Name = "tbxLtt";
            tbxLtt.ReadOnly = true;
            tbxLtt.Size = new Size(415, 36);
            tbxLtt.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.Location = new Point(9, 309);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 29;
            label5.Text = "Lương tạm tính";
            // 
            // tbxDu
            // 
            tbxDu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxDu.Font = new Font("Calibri", 14F);
            tbxDu.Location = new Point(215, 256);
            tbxDu.Margin = new Padding(2);
            tbxDu.Name = "tbxDu";
            tbxDu.ReadOnly = true;
            tbxDu.Size = new Size(415, 36);
            tbxDu.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.Location = new Point(9, 262);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 27;
            label4.Text = "Đã ứng";
            // 
            // tbxHsl
            // 
            tbxHsl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxHsl.Font = new Font("Calibri", 14F);
            tbxHsl.Location = new Point(215, 166);
            tbxHsl.Margin = new Padding(2);
            tbxHsl.Name = "tbxHsl";
            tbxHsl.ReadOnly = true;
            tbxHsl.Size = new Size(415, 36);
            tbxHsl.TabIndex = 26;
            // 
            // tbxSnc
            // 
            tbxSnc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxSnc.Font = new Font("Calibri", 14F);
            tbxSnc.Location = new Point(215, 121);
            tbxSnc.Margin = new Padding(2);
            tbxSnc.Name = "tbxSnc";
            tbxSnc.ReadOnly = true;
            tbxSnc.Size = new Size(415, 36);
            tbxSnc.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label16.Location = new Point(9, 168);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(117, 28);
            label16.TabIndex = 23;
            label16.Text = "Hệ số lương";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label15.Location = new Point(9, 121);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(130, 28);
            label15.TabIndex = 24;
            label15.Text = "Số ngày công";
            // 
            // tbxTnv
            // 
            tbxTnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxTnv.Font = new Font("Calibri", 14F);
            tbxTnv.Location = new Point(215, 76);
            tbxTnv.Margin = new Padding(2);
            tbxTnv.Name = "tbxTnv";
            tbxTnv.ReadOnly = true;
            tbxTnv.Size = new Size(415, 36);
            tbxTnv.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(9, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 17;
            label3.Text = "Tên Nhân Viên";
            // 
            // tbxMnv
            // 
            tbxMnv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbxMnv.Font = new Font("Calibri", 14F);
            tbxMnv.Location = new Point(215, 31);
            tbxMnv.Margin = new Padding(2);
            tbxMnv.Name = "tbxMnv";
            tbxMnv.ReadOnly = true;
            tbxMnv.Size = new Size(415, 36);
            tbxMnv.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(14, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 15;
            label2.Text = "Mã Nhân Viên";
            // 
            // fTamUngLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1268, 937);
            Controls.Add(tableLayoutPanel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "fTamUngLuong";
            Text = "Tạm Ứng Lương";
            WindowState = FormWindowState.Maximized;
            FormClosed += fTamUngLuong_FormClosed;
            Load += fTamUngLuong_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private DataGridView dgvLichSu;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TextBox tbxLyDo;
        private TextBox tbxStchu;
        private TextBox tbxStso;
        private Button btnHuy;
        private Button btnGui;
        private Label label10;
        private Label label8;
        private Label label7;
        private DateTimePicker datetime;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox tbxLtt;
        private Label label5;
        private TextBox tbxDu;
        private Label label4;
        private TextBox tbxHsl;
        private TextBox tbxSnc;
        private Label label16;
        private Label label15;
        private TextBox tbxTnv;
        private Label label3;
        private TextBox tbxMnv;
        private Label label2;
        private Label label1;
        private TextBox tbxLcb;
        private Label label11;
        private TextBox tbxConlai;
        private Label label9;
        private DataGridViewTextBoxColumn MaUngLuong;
        private DataGridViewTextBoxColumn MaLuong;
        private DataGridViewTextBoxColumn ThoiGian;
        private DataGridViewTextBoxColumn SoTienUng;
        private DataGridViewTextBoxColumn LyDo;
    }
}