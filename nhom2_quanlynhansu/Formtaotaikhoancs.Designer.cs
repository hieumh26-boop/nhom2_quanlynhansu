namespace nhom2_quanlynhansu
{
    partial class Formtaotaikhoancs
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
            tbtdn2 = new TextBox();
            tbmk2 = new TextBox();
            tbxnmk = new TextBox();
            btxnttk = new Button();
            btt = new Button();
            cbmkttk = new CheckBox();
            ccmkttk2 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 62);
            label1.TabIndex = 0;
            label1.Text = "QLNS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(237, 46);
            label2.TabIndex = 1;
            label2.Text = "Tạo tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(297, 111);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(344, 164);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 3;
            label4.Text = "mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(263, 231);
            label5.Name = "label5";
            label5.Size = new Size(174, 28);
            label5.TabIndex = 4;
            label5.Text = "xác nhận mật khẩu";
            // 
            // tbtdn2
            // 
            tbtdn2.BorderStyle = BorderStyle.FixedSingle;
            tbtdn2.Location = new Point(443, 115);
            tbtdn2.Name = "tbtdn2";
            tbtdn2.Size = new Size(260, 27);
            tbtdn2.TabIndex = 5;
            // 
            // tbmk2
            // 
            tbmk2.BorderStyle = BorderStyle.FixedSingle;
            tbmk2.Location = new Point(443, 171);
            tbmk2.Name = "tbmk2";
            tbmk2.Size = new Size(260, 27);
            tbmk2.TabIndex = 6;
            // 
            // tbxnmk
            // 
            tbxnmk.BorderStyle = BorderStyle.FixedSingle;
            tbxnmk.Location = new Point(443, 231);
            tbxnmk.Name = "tbxnmk";
            tbxnmk.Size = new Size(260, 27);
            tbxnmk.TabIndex = 7;
            // 
            // btxnttk
            // 
            btxnttk.BackColor = Color.Navy;
            btxnttk.FlatStyle = FlatStyle.Popup;
            btxnttk.Font = new Font("Segoe UI", 10.2F);
            btxnttk.ForeColor = Color.White;
            btxnttk.Location = new Point(443, 300);
            btxnttk.Name = "btxnttk";
            btxnttk.Size = new Size(94, 29);
            btxnttk.TabIndex = 8;
            btxnttk.Text = "Xác nhận";
            btxnttk.UseVisualStyleBackColor = false;
            btxnttk.Click += btxnttk_Click;
            // 
            // btt
            // 
            btt.FlatStyle = FlatStyle.Popup;
            btt.Location = new Point(609, 300);
            btt.Name = "btt";
            btt.Size = new Size(94, 29);
            btt.TabIndex = 9;
            btt.Text = "Thoát";
            btt.UseVisualStyleBackColor = true;
            // 
            // cbmkttk
            // 
            cbmkttk.Appearance = Appearance.Button;
            cbmkttk.FlatStyle = FlatStyle.Popup;
            cbmkttk.Image = Properties.Resources.mătdong;
            cbmkttk.Location = new Point(709, 171);
            cbmkttk.Name = "cbmkttk";
            cbmkttk.Size = new Size(42, 27);
            cbmkttk.TabIndex = 10;
            cbmkttk.UseVisualStyleBackColor = true;
            // 
            // ccmkttk2
            // 
            ccmkttk2.Appearance = Appearance.Button;
            ccmkttk2.FlatStyle = FlatStyle.Popup;
            ccmkttk2.Image = Properties.Resources.mătdong;
            ccmkttk2.Location = new Point(709, 233);
            ccmkttk2.Name = "ccmkttk2";
            ccmkttk2.Size = new Size(40, 26);
            ccmkttk2.TabIndex = 11;
            ccmkttk2.UseVisualStyleBackColor = true;
            // 
            // Formtaotaikhoancs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ccmkttk2);
            Controls.Add(cbmkttk);
            Controls.Add(btt);
            Controls.Add(btxnttk);
            Controls.Add(tbxnmk);
            Controls.Add(tbmk2);
            Controls.Add(tbtdn2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Navy;
            Name = "Formtaotaikhoancs";
            Text = "Formtaotaikhoancs";
            Load += Formtaotaikhoancs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbtdn2;
        private TextBox tbmk2;
        private TextBox tbxnmk;
        private Button btxnttk;
        private Button btt;
        private CheckBox cbmkttk;
        private CheckBox ccmkttk2;
    }
}