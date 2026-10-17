namespace nhom2_quanlynhansu
{
    partial class FormQuanLyNhanSu
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
            lblTieuDe = new Label();
            cboCoSo = new ComboBox();
            btnLoc = new Button();
            dgvDanhSachNhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTieuDe.Location = new Point(225, 35);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(277, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // cboCoSo
            // 
            cboCoSo.FormattingEnabled = true;
            cboCoSo.Location = new Point(192, 93);
            cboCoSo.Name = "cboCoSo";
            cboCoSo.Size = new Size(173, 28);
            cboCoSo.TabIndex = 1;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(394, 93);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(146, 154);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dgvDanhSachNhanVien.Size = new Size(483, 236);
            dgvDanhSachNhanVien.TabIndex = 3;
            // 
            // FormQuanLyNhanSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 450);
            Controls.Add(dgvDanhSachNhanVien);
            Controls.Add(btnLoc);
            Controls.Add(cboCoSo);
            Controls.Add(lblTieuDe);
            Name = "FormQuanLyNhanSu";
            Text = "FormQuanLyNhanSu";
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private ComboBox cboCoSo;
        private Button btnLoc;
        private DataGridView dgvDanhSachNhanVien;
    }
}