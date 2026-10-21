namespace nhom2_quanlynhansu
{
    partial class formcauhinhcalamviec
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelThongTin = new Panel();
            dgvCaLamViec = new DataGridView();
            cloSTT = new DataGridViewTextBoxColumn();
            colMaCa = new DataGridViewTextBoxColumn();
            colGioBatDau = new DataGridViewTextBoxColumn();
            colGioKetThuc = new DataGridViewTextBoxColumn();
            colThoiLuongNghi = new DataGridViewTextBoxColumn();
            colChoPhepTre = new DataGridViewTextBoxColumn();
            colHanhDong = new DataGridViewTextBoxColumn();
            txtMaCa = new TextBox();
            label12 = new Label();
            label6 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnsua = new Button();
            txtThemmoi = new Button();
            txtMoTa = new TextBox();
            label11 = new Label();
            numThoiLuongNghi = new NumericUpDown();
            label10 = new Label();
            dtpGioKetThuc = new DateTimePicker();
            label9 = new Label();
            dtpGioBatDau = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThoiLuongNghi).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = SystemColors.GradientActiveCaption;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1182, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 33);
            label1.Name = "label1";
            label1.Size = new Size(362, 41);
            label1.TabIndex = 1;
            label1.Text = "CẤU HÌNH CA LÀM VIỆC";
            // 
            // panelThongTin
            // 
            panelThongTin.Anchor = AnchorStyles.Top;
            panelThongTin.BackColor = SystemColors.GradientActiveCaption;
            panelThongTin.Controls.Add(dgvCaLamViec);
            panelThongTin.Controls.Add(txtMaCa);
            panelThongTin.Controls.Add(label12);
            panelThongTin.Controls.Add(label6);
            panelThongTin.Controls.Add(btnLamMoi);
            panelThongTin.Controls.Add(btnXoa);
            panelThongTin.Controls.Add(btnsua);
            panelThongTin.Controls.Add(txtThemmoi);
            panelThongTin.Controls.Add(txtMoTa);
            panelThongTin.Controls.Add(label11);
            panelThongTin.Controls.Add(numThoiLuongNghi);
            panelThongTin.Controls.Add(label10);
            panelThongTin.Controls.Add(dtpGioKetThuc);
            panelThongTin.Controls.Add(label9);
            panelThongTin.Controls.Add(dtpGioBatDau);
            panelThongTin.Controls.Add(label8);
            panelThongTin.Controls.Add(label5);
            panelThongTin.Location = new Point(0, 103);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(1182, 650);
            panelThongTin.TabIndex = 4;
            // 
            // dgvCaLamViec
            // 
            dgvCaLamViec.Anchor = AnchorStyles.Top;
            dgvCaLamViec.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvCaLamViec.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCaLamViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCaLamViec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaLamViec.Columns.AddRange(new DataGridViewColumn[] { cloSTT, colMaCa, colGioBatDau, colGioKetThuc, colThoiLuongNghi, colChoPhepTre, colHanhDong });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCaLamViec.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCaLamViec.GridColor = Color.FromArgb(224, 224, 224);
            dgvCaLamViec.Location = new Point(28, 344);
            dgvCaLamViec.Name = "dgvCaLamViec";
            dgvCaLamViec.RowHeadersWidth = 51;
            dgvCaLamViec.RowTemplate.Height = 35;
            dgvCaLamViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaLamViec.Size = new Size(1155, 205);
            dgvCaLamViec.TabIndex = 1;
            dgvCaLamViec.CellClick += dgvCaLamViec_CellClick;
            dgvCaLamViec.CellContentClick += dgvCaLamViec_CellClick;
            // 
            // cloSTT
            // 
            cloSTT.HeaderText = "STT";
            cloSTT.MinimumWidth = 6;
            cloSTT.Name = "cloSTT";
            cloSTT.Width = 125;
            // 
            // colMaCa
            // 
            colMaCa.HeaderText = "Mã Ca";
            colMaCa.MinimumWidth = 6;
            colMaCa.Name = "colMaCa";
            colMaCa.Width = 125;
            // 
            // colGioBatDau
            // 
            colGioBatDau.HeaderText = "Giờ Bắt Đầu";
            colGioBatDau.MinimumWidth = 6;
            colGioBatDau.Name = "colGioBatDau";
            colGioBatDau.Width = 125;
            // 
            // colGioKetThuc
            // 
            colGioKetThuc.HeaderText = "Giờ Kết Thúc";
            colGioKetThuc.MinimumWidth = 6;
            colGioKetThuc.Name = "colGioKetThuc";
            colGioKetThuc.Width = 125;
            // 
            // colThoiLuongNghi
            // 
            colThoiLuongNghi.HeaderText = "Thời Lượng Nghỉ";
            colThoiLuongNghi.MinimumWidth = 6;
            colThoiLuongNghi.Name = "colThoiLuongNghi";
            colThoiLuongNghi.Width = 125;
            // 
            // colChoPhepTre
            // 
            colChoPhepTre.HeaderText = "Đi trễ / Về sớm";
            colChoPhepTre.MinimumWidth = 6;
            colChoPhepTre.Name = "colChoPhepTre";
            colChoPhepTre.Width = 125;
            // 
            // colHanhDong
            // 
            colHanhDong.HeaderText = "Hành Động";
            colHanhDong.MinimumWidth = 6;
            colHanhDong.Name = "colHanhDong";
            colHanhDong.Width = 125;
            // 
            // txtMaCa
            // 
            txtMaCa.Location = new Point(130, 83);
            txtMaCa.Name = "txtMaCa";
            txtMaCa.Size = new Size(250, 27);
            txtMaCa.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(44, 316);
            label12.Name = "label12";
            label12.Size = new Size(201, 25);
            label12.TabIndex = 0;
            label12.Text = "Danh Sách Ca Làm Việc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 86);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 18;
            label6.Text = "Mã Ca";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(255, 128, 0);
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(840, 262);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(616, 262);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.Lime;
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(376, 262);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 15;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click_1;
            // 
            // txtThemmoi
            // 
            txtThemmoi.BackColor = SystemColors.MenuHighlight;
            txtThemmoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThemmoi.Location = new Point(163, 262);
            txtThemmoi.Name = "txtThemmoi";
            txtThemmoi.Size = new Size(94, 29);
            txtThemmoi.TabIndex = 14;
            txtThemmoi.Text = "Thêm Mới";
            txtThemmoi.UseVisualStyleBackColor = false;
            txtThemmoi.Click += txtThemmoi_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(797, 130);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(208, 82);
            txtMoTa.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(590, 130);
            label11.Name = "label11";
            label11.Size = new Size(198, 20);
            label11.TabIndex = 12;
            label11.Text = "Cho phép trễ/về sớm (phút)";
            // 
            // numThoiLuongNghi
            // 
            numThoiLuongNghi.Location = new Point(797, 56);
            numThoiLuongNghi.Name = "numThoiLuongNghi";
            numThoiLuongNghi.Size = new Size(150, 27);
            numThoiLuongNghi.TabIndex = 11;
            numThoiLuongNghi.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(590, 55);
            label10.Name = "label10";
            label10.Size = new Size(178, 20);
            label10.TabIndex = 10;
            label10.Text = "Thời Lượng Nghỉ ( phút )";
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.CustomFormat = "HH : mm";
            dtpGioKetThuc.Format = DateTimePickerFormat.Custom;
            dtpGioKetThuc.Location = new Point(130, 185);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(250, 27);
            dtpGioKetThuc.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 185);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 8;
            label9.Text = "Giờ Kết Thúc";
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.CustomFormat = "HH : mm";
            dtpGioBatDau.Format = DateTimePickerFormat.Custom;
            dtpGioBatDau.Location = new Point(130, 140);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(250, 27);
            dtpGioBatDau.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 139);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 5;
            label8.Text = "Giờ Bắt Đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 15);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 0;
            label5.Text = "Thông Tin Ca Làm Việc ";
            // 
            // formcauhinhcalamviec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelThongTin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "formcauhinhcalamviec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += formcauhinhcalamviec_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelThongTin.ResumeLayout(false);
            panelThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThoiLuongNghi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelThongTin;
        private Label label5;
        private DateTimePicker dtpGioBatDau;
        private Label label8;
        private DateTimePicker dtpGioKetThuc;
        private Label label9;
        private NumericUpDown numThoiLuongNghi;
        private Label label10;
        private Button txtThemmoi;
        private TextBox txtMoTa;
        private Label label11;
        private Button btnXoa;
        private Button btnsua;
        private Label label12;
        private DataGridView dgvCaLamViec;
        private Button btnLamMoi;
        private Label label6;
        private TextBox txtMaCa;
        private DataGridViewTextBoxColumn cloSTT;
        private DataGridViewTextBoxColumn colMaCa;
        private DataGridViewTextBoxColumn colGioBatDau;
        private DataGridViewTextBoxColumn colGioKetThuc;
        private DataGridViewTextBoxColumn colThoiLuongNghi;
        private DataGridViewTextBoxColumn colChoPhepTre;
        private DataGridViewTextBoxColumn colHanhDong;
    }
}