namespace nhom2_quanlynhansu
{
    partial class Formdangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbdn = new TextBox();
            tbmk = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbdn = new CheckBox();
            cbttk = new CheckBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            cbmk = new CheckBox();
            btnHoan = new Button();
            SuspendLayout();
            // 
            // tbdn
            // 
            tbdn.BorderStyle = BorderStyle.FixedSingle;
            tbdn.ForeColor = Color.Black;
            tbdn.Location = new Point(821, 187);
            tbdn.Margin = new Padding(5);
            tbdn.Name = "tbdn";
            tbdn.Size = new Size(466, 41);
            tbdn.TabIndex = 2;
            // 
            // tbmk
            // 
            tbmk.BorderStyle = BorderStyle.FixedSingle;
            tbmk.ForeColor = Color.YellowGreen;
            tbmk.Location = new Point(821, 313);
            tbmk.Margin = new Padding(5);
            tbmk.Name = "tbmk";
            tbmk.Size = new Size(466, 41);
            tbmk.TabIndex = 3;
            tbmk.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(565, 186);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(648, 313);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 5;
            label2.Text = "mật khẩu";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 124);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 54);
            label3.TabIndex = 6;
            label3.Text = "Đăng nhập";
            // 
            // cbdn
            // 
            cbdn.AccessibleRole = AccessibleRole.None;
            cbdn.Appearance = Appearance.Button;
            cbdn.AutoSize = true;
            cbdn.BackColor = Color.FromArgb(0, 0, 192);
            cbdn.BackgroundImageLayout = ImageLayout.Center;
            cbdn.CheckAlign = ContentAlignment.TopLeft;
            cbdn.FlatStyle = FlatStyle.Popup;
            cbdn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbdn.ForeColor = Color.White;
            cbdn.Location = new Point(821, 460);
            cbdn.Margin = new Padding(5);
            cbdn.Name = "cbdn";
            cbdn.Size = new Size(126, 40);
            cbdn.TabIndex = 7;
            cbdn.Text = "Đăng nhập";
            cbdn.UseVisualStyleBackColor = false;
            cbdn.CheckedChanged += cbdn_CheckedChanged;
            // 
            // cbttk
            // 
            cbttk.Appearance = Appearance.Button;
            cbttk.AutoSize = true;
            cbttk.BackColor = Color.White;
            cbttk.FlatStyle = FlatStyle.Popup;
            cbttk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbttk.ForeColor = Color.FromArgb(0, 0, 192);
            cbttk.Location = new Point(1071, 460);
            cbttk.Margin = new Padding(5);
            cbttk.Name = "cbttk";
            cbttk.Size = new Size(149, 40);
            cbttk.TabIndex = 8;
            cbttk.Text = "Tạo tài khoản";
            cbttk.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 16);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 76);
            label4.TabIndex = 9;
            label4.Text = "QLNS";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(821, 396);
            linkLabel1.Margin = new Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 35);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật Khẩu ?";
            // 
            // cbmk
            // 
            cbmk.Appearance = Appearance.Button;
            cbmk.FlatStyle = FlatStyle.Flat;
            cbmk.Image = Properties.Resources.mătdong;
            cbmk.Location = new Point(1298, 315);
            cbmk.Margin = new Padding(5);
            cbmk.Name = "cbmk";
            cbmk.Size = new Size(88, 47);
            cbmk.TabIndex = 11;
            cbmk.UseVisualStyleBackColor = true;
            // 
            // btnHoan
            // 
            btnHoan.Location = new Point(443, 564);
            btnHoan.Name = "btnHoan";
            btnHoan.Size = new Size(214, 45);
            btnHoan.TabIndex = 12;
            btnHoan.Text = "Mượn dùng tạm";
            btnHoan.UseVisualStyleBackColor = true;
            btnHoan.Click += btnHoan_Click;
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 788);
            Controls.Add(btnHoan);
            Controls.Add(cbmk);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(cbttk);
            Controls.Add(cbdn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbmk);
            Controls.Add(tbdn);
            Margin = new Padding(5);
            Name = "Formdangnhap";
            FormClosed += Formdangnhap_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbdn;
        private TextBox tbmk;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbdn;
        private CheckBox cbttk;
        private Label label4;
        private LinkLabel linkLabel1;
        private CheckBox cbmk;
        private Button btnHoan;
    }
}
