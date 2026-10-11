namespace nhom2_quanlynhansu
{
    partial class Form4
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
            lblMaNV = new Label();
            txtMaNV = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).BeginInit();
            SuspendLayout();
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(207, 92);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(97, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(330, 89);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(250, 27);
            txtMaNV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(207, 127);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(330, 127);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblNgayLam
            // 
            lblNgayLam.AutoSize = true;
            lblNgayLam.Location = new Point(207, 172);
            lblNgayLam.Name = "lblNgayLam";
            lblNgayLam.Size = new Size(103, 20);
            lblNgayLam.TabIndex = 4;
            lblNgayLam.Text = "Ngày làm việc";
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.Location = new Point(330, 167);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.Size = new Size(250, 27);
            dtpNgayLam.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(207, 23);
            label1.Name = "label1";
            label1.Size = new Size(352, 41);
            label1.TabIndex = 6;
            label1.Text = "Nơi đăng kí ca làm việc";
            // 
            // lblCaLam
            // 
            lblCaLam.AutoSize = true;
            lblCaLam.Location = new Point(207, 217);
            lblCaLam.Name = "lblCaLam";
            lblCaLam.Size = new Size(91, 20);
            lblCaLam.TabIndex = 7;
            lblCaLam.Text = "Chọn ca làm";
            // 
            // cboCaLam
            // 
            cboCaLam.FormattingEnabled = true;
            cboCaLam.Location = new Point(346, 209);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(151, 28);
            cboCaLam.TabIndex = 8;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(229, 287);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 9;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(403, 287);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvCaLam
            // 
            dgvCaLam.AllowUserToAddRows = false;
            dgvCaLam.AllowUserToResizeColumns = false;
            dgvCaLam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaLam.Columns.AddRange(new DataGridViewColumn[] { colMaNV, ColHoTen, ColNgayLam, ColCaLam });
            dgvCaLam.Location = new Point(116, 359);
            dgvCaLam.Name = "dgvCaLam";
            dgvCaLam.RowHeadersWidth = 51;
            dgvCaLam.Size = new Size(552, 188);
            dgvCaLam.TabIndex = 11;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
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
            ColNgayLam.DataPropertyName = "NgayLam";
            ColNgayLam.HeaderText = "Ngày làm";
            ColNgayLam.MinimumWidth = 6;
            ColNgayLam.Name = "ColNgayLam";
            ColNgayLam.Width = 125;
            // 
            // ColCaLam
            // 
            ColCaLam.DataPropertyName = "Ca";
            ColCaLam.HeaderText = "Ca Làm";
            ColCaLam.MinimumWidth = 6;
            ColCaLam.Name = "ColCaLam";
            ColCaLam.Width = 125;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(dgvCaLam);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(cboCaLam);
            Controls.Add(lblCaLam);
            Controls.Add(label1);
            Controls.Add(dtpNgayLam);
            Controls.Add(lblNgayLam);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaNV);
            Controls.Add(lblMaNV);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaLam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaNV;
        private TextBox txtMaNV;
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
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn ColHoTen;
        private DataGridViewTextBoxColumn ColNgayLam;
        private DataGridViewTextBoxColumn ColCaLam;
    }
}