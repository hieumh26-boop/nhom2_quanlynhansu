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
            tbmnv = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(196, 25);
            label2.Name = "label2";
            label2.Size = new Size(410, 50);
            label2.TabIndex = 1;
            label2.Text = "Tạo tài khoản nhân sự";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(142, 110);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(192, 166);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(103, 226);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // tbtdn2
            // 
            tbtdn2.BorderStyle = BorderStyle.FixedSingle;
            tbtdn2.Location = new Point(321, 115);
            tbtdn2.Name = "tbtdn2";
            tbtdn2.Size = new Size(260, 27);
            tbtdn2.TabIndex = 5;
            // 
            // tbmk2
            // 
            tbmk2.BorderStyle = BorderStyle.FixedSingle;
            tbmk2.Location = new Point(321, 167);
            tbmk2.Name = "tbmk2";
            tbmk2.PasswordChar = '*';
            tbmk2.Size = new Size(260, 27);
            tbmk2.TabIndex = 6;
            // 
            // tbxnmk
            // 
            tbxnmk.BorderStyle = BorderStyle.FixedSingle;
            tbxnmk.Location = new Point(321, 227);
            tbxnmk.Name = "tbxnmk";
            tbxnmk.PasswordChar = '*';
            tbxnmk.Size = new Size(260, 27);
            tbxnmk.TabIndex = 7;
            // 
            // btxnttk
            // 
            btxnttk.BackColor = SystemColors.HotTrack;
            btxnttk.FlatStyle = FlatStyle.Popup;
            btxnttk.Font = new Font("Segoe UI", 10.2F);
            btxnttk.ForeColor = Color.White;
            btxnttk.Location = new Point(321, 343);
            btxnttk.Name = "btxnttk";
            btxnttk.Size = new Size(94, 29);
            btxnttk.TabIndex = 8;
            btxnttk.Text = "Xác nhận";
            btxnttk.UseVisualStyleBackColor = false;
            btxnttk.Click += btxnttk_Click;
            // 
            // btt
            // 
            btt.BackColor = SystemColors.AppWorkspace;
            btt.FlatStyle = FlatStyle.Popup;
            btt.ForeColor = Color.Black;
            btt.Location = new Point(497, 343);
            btt.Name = "btt";
            btt.Size = new Size(94, 29);
            btt.TabIndex = 9;
            btt.Text = "Thoát";
            btt.UseVisualStyleBackColor = false;
            btt.Click += btt_Click;
            // 
            // cbmkttk
            // 
            cbmkttk.Appearance = Appearance.Button;
            cbmkttk.FlatStyle = FlatStyle.Popup;
            cbmkttk.Image = Properties.Resources.mătdong;
            cbmkttk.Location = new Point(609, 170);
            cbmkttk.Name = "cbmkttk";
            cbmkttk.Size = new Size(42, 27);
            cbmkttk.TabIndex = 10;
            cbmkttk.UseVisualStyleBackColor = true;
            cbmkttk.CheckedChanged += cbmkttk_CheckedChanged;
            // 
            // tbmnv
            // 
            tbmnv.BorderStyle = BorderStyle.FixedSingle;
            tbmnv.Location = new Point(321, 289);
            tbmnv.Name = "tbmnv";
            tbmnv.Size = new Size(260, 27);
            tbmnv.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(70, 284);
            label6.Name = "label6";
            label6.Size = new Size(216, 28);
            label6.TabIndex = 12;
            label6.Text = "Mã nhân viên được cấp";
            // 
            // Formtaotaikhoancs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tbmnv);
            Controls.Add(label6);
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
            ForeColor = Color.Navy;
            Name = "Formtaotaikhoancs";
            Text = "Formtaotaikhoancs";
            FormClosing += Formtaotaikhoancs_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox tbmnv;
        private Label label6;
    }
}