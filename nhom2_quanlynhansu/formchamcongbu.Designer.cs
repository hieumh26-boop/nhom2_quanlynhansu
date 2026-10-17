namespace nhom2_quanlynhansu
{
    partial class formchamcongbu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaNV = new TextBox();
            txtHoTen = new TextBox();
            dtpNgayChamBu = new DateTimePicker();
            dtpGioBatDau = new DateTimePicker();
            dtpGioKetThuc = new DateTimePicker();
            txtLyDo = new TextBox();
            btnhuy = new Button();
            btnGuiDon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 114);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày cần chấm bù :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Thời gian bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 201);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 4;
            label5.Text = "Thời Gian Kết Thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 244);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Lý do";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(183, 39);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(250, 27);
            txtMaNV.TabIndex = 6;
            txtMaNV.TextChanged += txtMaNV_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(183, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(250, 27);
            txtHoTen.TabIndex = 7;
            // 
            // dtpNgayChamBu
            // 
            dtpNgayChamBu.Location = new Point(183, 114);
            dtpNgayChamBu.Name = "dtpNgayChamBu";
            dtpNgayChamBu.Size = new Size(250, 27);
            dtpNgayChamBu.TabIndex = 8;
            // 
            // dtpGioBatDau
            // 
            dtpGioBatDau.Format = DateTimePickerFormat.Time;
            dtpGioBatDau.Location = new Point(179, 162);
            dtpGioBatDau.Name = "dtpGioBatDau";
            dtpGioBatDau.ShowUpDown = true;
            dtpGioBatDau.Size = new Size(250, 27);
            dtpGioBatDau.TabIndex = 9;
            // 
            // dtpGioKetThuc
            // 
            dtpGioKetThuc.Format = DateTimePickerFormat.Time;
            dtpGioKetThuc.Location = new Point(180, 206);
            dtpGioKetThuc.Name = "dtpGioKetThuc";
            dtpGioKetThuc.ShowUpDown = true;
            dtpGioKetThuc.Size = new Size(250, 27);
            dtpGioKetThuc.TabIndex = 10;
            // 
            // txtLyDo
            // 
            txtLyDo.Cursor = Cursors.SizeAll;
            txtLyDo.Location = new Point(181, 248);
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(249, 27);
            txtLyDo.TabIndex = 11;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(63, 317);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(94, 29);
            btnhuy.TabIndex = 12;
            btnhuy.Text = "HỦY";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnGuiDon
            // 
            btnGuiDon.Location = new Point(335, 317);
            btnGuiDon.Name = "btnGuiDon";
            btnGuiDon.Size = new Size(94, 29);
            btnGuiDon.TabIndex = 13;
            btnGuiDon.Text = "Gửi Đơn";
            btnGuiDon.UseVisualStyleBackColor = true;
            btnGuiDon.Click += btnGuiDon_Click;
            // 
            // formchamcongbu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuiDon);
            Controls.Add(btnhuy);
            Controls.Add(txtLyDo);
            Controls.Add(dtpGioKetThuc);
            Controls.Add(dtpGioBatDau);
            Controls.Add(dtpNgayChamBu);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formchamcongbu";
            Text = "formchamcongbu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgayChamBu;
        private DateTimePicker dtpGioBatDau;
        private DateTimePicker dtpGioKetThuc;
        private TextBox txtLyDo;
        private Button btnhuy;
        private Button btnGuiDon;
    }
}