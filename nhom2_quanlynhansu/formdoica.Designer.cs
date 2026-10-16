namespace nhom2_quanlynhansu
{
    partial class formdoica
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
            TxtHoTen = new TextBox();
            dtpNgaydoi = new DateTimePicker();
            dtpcahientai = new ComboBox();
            dtpcamuondoi = new ComboBox();
            txtLydo = new TextBox();
            btnGuidon = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "họ tên :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 144);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "ngày muốn đổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 209);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "ca hiện tại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 177);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "ca muốn đổi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 267);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "lý do";
            label6.Click += label6_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(175, 63);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(125, 27);
            txtMaNV.TabIndex = 6;
            // 
            // TxtHoTen
            // 
            TxtHoTen.Location = new Point(175, 101);
            TxtHoTen.Name = "TxtHoTen";
            TxtHoTen.Size = new Size(125, 27);
            TxtHoTen.TabIndex = 7;
            // 
            // dtpNgaydoi
            // 
            dtpNgaydoi.Location = new Point(175, 144);
            dtpNgaydoi.Name = "dtpNgaydoi";
            dtpNgaydoi.Size = new Size(250, 27);
            dtpNgaydoi.TabIndex = 8;
            // 
            // dtpcahientai
            // 
            dtpcahientai.FormattingEnabled = true;
            dtpcahientai.Items.AddRange(new object[] { "plain text", "ca sáng", "ca chiều", "ca tối" });
            dtpcahientai.Location = new Point(175, 220);
            dtpcahientai.Name = "dtpcahientai";
            dtpcahientai.Size = new Size(151, 28);
            dtpcahientai.TabIndex = 9;
            dtpcahientai.SelectedIndexChanged += dtpcahientai_SelectedIndexChanged;
            // 
            // dtpcamuondoi
            // 
            dtpcamuondoi.FormattingEnabled = true;
            dtpcamuondoi.Items.AddRange(new object[] { "plain text ", "ca sáng", "ca chiều", "ca tối" });
            dtpcamuondoi.Location = new Point(175, 177);
            dtpcamuondoi.Name = "dtpcamuondoi";
            dtpcamuondoi.Size = new Size(151, 28);
            dtpcamuondoi.TabIndex = 10;
            dtpcamuondoi.SelectedIndexChanged += dtpcamuondoi_SelectedIndexChanged;
            // 
            // txtLydo
            // 
            txtLydo.Location = new Point(175, 254);
            txtLydo.Multiline = true;
            txtLydo.Name = "txtLydo";
            txtLydo.Size = new Size(209, 56);
            txtLydo.TabIndex = 11;
            // 
            // btnGuidon
            // 
            btnGuidon.Location = new Point(104, 366);
            btnGuidon.Name = "btnGuidon";
            btnGuidon.Size = new Size(94, 29);
            btnGuidon.TabIndex = 12;
            btnGuidon.Text = "Gửi Đơn";
            btnGuidon.UseVisualStyleBackColor = true;
            btnGuidon.Click += btnGuiDon_Click; 
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(290, 366);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // formdoica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnGuidon);
            Controls.Add(txtLydo);
            Controls.Add(dtpcamuondoi);
            Controls.Add(dtpcahientai);
            Controls.Add(dtpNgaydoi);
            Controls.Add(TxtHoTen);
            Controls.Add(txtMaNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formdoica";
            Text = "formdoica";
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
        private TextBox TxtHoTen;
        private DateTimePicker dtpNgaydoi;
        private ComboBox dtpcahientai;
        private ComboBox dtpcamuondoi;
        private TextBox txtLydo;
        private Button btnGuidon;
        private Button btnHuy;
    }
}