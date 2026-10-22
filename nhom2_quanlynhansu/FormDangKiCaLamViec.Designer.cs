namespace nhom2_quanlynhansu
{
    partial class FormDangKiCaLamViec
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblMaNV = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgayLam = new Label();
            dtpNgayLam = new DateTimePicker();
            label1 = new Label();
            lblCaLam = new Label();
            cboCaLam = new ComboBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            dgvCaLam = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            ColHoTen = new DataGridViewTextBoxColumn();
            ColNgayLam = new DataGridViewTextBoxColumn();
            ColCaLam = new DataGridViewTextBoxColumn();
            cboMaNV = new ComboBox();
            panel1 = new Panel();
            tbkt = new TextBox();
            label3 = new Label();
            tbbd = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblMaNV.Location = new Point(207, 92);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(149, 31);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblHoTen.Location = new Point(207, 127);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(79, 31);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(389, 127);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblNgayLam
            // 
            lblNgayLam.AutoSize = true;
            lblNgayLam.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblNgayLam.Location = new Point(207, 172);
            lblNgayLam.Name = "lblNgayLam";
            lblNgayLam.Size = new Size(154, 31);
            lblNgayLam.TabIndex = 4;
            lblNgayLam.Text = "Ngày làm việc";
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.Location = new Point(389, 172);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.Size = new Size(250, 27);
            dtpNgayLam.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(433, 50);
            label1.TabIndex = 6;
            label1.Text = "Nơi đăng kí ca làm việc";
            // 
            // lblCaLam
            // 
            lblCaLam.AutoSize = true;
            lblCaLam.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            lblCaLam.Location = new Point(207, 217);
            lblCaLam.Name = "lblCaLam";
            lblCaLam.Size = new Size(139, 31);
            lblCaLam.TabIndex = 7;
            lblCaLam.Text = "Chọn ca làm";
            // 
            // cboCaLam
            // 
            cboCaLam.FormattingEnabled = true;
            cboCaLam.Items.AddRange(new object[] { "1", "2", "3" });
            cboCaLam.Location = new Point(389, 217);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(151, 28);
            cboCaLam.TabIndex = 8;
            cboCaLam.SelectedIndexChanged += cboCaLam_SelectedIndexChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.HotTrack;
            btnDangKy.FlatStyle = FlatStyle.Popup;
            btnDangKy.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(218, 353);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(125, 39);
            btnDangKy.TabIndex = 9;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.AppWorkspace;
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(525, 353);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 39);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvCaLam
            // 
            dgvCaLam.AllowUserToAddRows = false;
            dgvCaLam.AllowUserToResizeColumns = false;
            dgvCaLam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCaLam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaLam.Columns.AddRange(new DataGridViewColumn[] { colMaNV, ColHoTen, ColNgayLam, ColCaLam });
            dgvCaLam.Location = new Point(117, 430);
            dgvCaLam.Name = "dgvCaLam";
            dgvCaLam.RowHeadersWidth = 51;
            dgvCaLam.Size = new Size(552, 188);
            dgvCaLam.TabIndex = 11;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNhanVien";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.Width = 125;
            // 
            // ColHoTen
            // 
            ColHoTen.DataPropertyName = "HoTen";
            ColHoTen.HeaderText = "Họ tên";
            ColHoTen.MinimumWidth = 6;
            ColHoTen.Name = "ColHoTen";
            ColHoTen.Width = 125;
            // 
            // ColNgayLam
            // 
            ColNgayLam.DataPropertyName = "ThoiGianDangKi";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm";
            ColNgayLam.DefaultCellStyle = dataGridViewCellStyle5;
            ColNgayLam.HeaderText = "Ngày làm";
            ColNgayLam.MinimumWidth = 6;
            ColNgayLam.Name = "ColNgayLam";
            ColNgayLam.Width = 125;
            // 
            // ColCaLam
            // 
            ColCaLam.DataPropertyName = "KhungGio";
            ColCaLam.HeaderText = "Ca Làm";
            ColCaLam.MinimumWidth = 6;
            ColCaLam.Name = "ColCaLam";
            ColCaLam.Width = 125;
            // 
            // cboMaNV
            // 
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(389, 92);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(250, 28);
            cboMaNV.TabIndex = 12;
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(tbkt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbbd);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboMaNV);
            panel1.Controls.Add(dgvCaLam);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(cboCaLam);
            panel1.Controls.Add(lblCaLam);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpNgayLam);
            panel1.Controls.Add(lblNgayLam);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(lblHoTen);
            panel1.Controls.Add(lblMaNV);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 651);
            panel1.TabIndex = 13;
            // 
            // tbkt
            // 
            tbkt.Location = new Point(389, 302);
            tbkt.Name = "tbkt";
            tbkt.Size = new Size(125, 27);
            tbkt.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.Location = new Point(207, 302);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 15;
            label3.Text = "Giờ kết thúc";
            // 
            // tbbd
            // 
            tbbd.Location = new Point(389, 259);
            tbbd.Name = "tbbd";
            tbbd.Size = new Size(125, 27);
            tbbd.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 259);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 13;
            label2.Text = "Giờ bắt đầu";
            // 
            // FormDangKiCaLamViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 644);
            Controls.Add(panel1);
            Name = "FormDangKiCaLamViec";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMaNV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgayLam;
        private DateTimePicker dtpNgayLam;
        private Label label1;
        private Label lblCaLam;
        private ComboBox cboCaLam;
        private Button btnDangKy;
        private Button btnHuy;
        private DataGridView dgvCaLam;
        private ComboBox cboMaNV;
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColNgayLam;
        private DataGridViewTextBoxColumn ColCaLam;
        private Panel panel1;
        private TextBox tbkt;
        private Label label3;
        private TextBox tbbd;
        private Label label2;
    }
}