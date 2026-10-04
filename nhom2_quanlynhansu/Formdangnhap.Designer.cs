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
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            cbmk = new CheckBox();
            btdn = new Button();
            btttk = new Button();
            SuspendLayout();
            // 
            // tbdn
            // 
            tbdn.BorderStyle = BorderStyle.FixedSingle;
            tbdn.ForeColor = Color.Black;
            tbdn.Location = new Point(469, 107);
            tbdn.Name = "tbdn";
            tbdn.Size = new Size(267, 27);
            tbdn.TabIndex = 2;
            // 
            // tbmk
            // 
            tbmk.BorderStyle = BorderStyle.FixedSingle;
            tbmk.ForeColor = Color.Black;
            tbmk.Location = new Point(469, 179);
            tbmk.Name = "tbmk";
            tbmk.Size = new Size(267, 27);
            tbmk.TabIndex = 3;
            tbmk.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(323, 106);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(370, 179);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "mật khẩu";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(194, 46);
            label3.TabIndex = 6;
            label3.Text = "Đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(150, 62);
            label4.TabIndex = 9;
            label4.Text = "QLNS";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(469, 226);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(122, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật Khẩu ?";
            // 
            // cbmk
            // 
            cbmk.Appearance = Appearance.Button;
            cbmk.FlatStyle = FlatStyle.Flat;
            cbmk.Image = Properties.Resources.mătdong;
            cbmk.Location = new Point(742, 180);
            cbmk.Name = "cbmk";
            cbmk.Size = new Size(50, 27);
            cbmk.TabIndex = 11;
            cbmk.UseVisualStyleBackColor = true;
            cbmk.CheckedChanged += cbmk_CheckedChanged;
            // 
            // btdn
            // 
            btdn.BackColor = Color.FromArgb(0, 0, 192);
            btdn.FlatStyle = FlatStyle.Popup;
            btdn.Font = new Font("Segoe UI", 10F);
            btdn.ForeColor = Color.White;
            btdn.Location = new Point(469, 263);
            btdn.Name = "btdn";
            btdn.Size = new Size(124, 29);
            btdn.TabIndex = 12;
            btdn.Text = "Đăng nhập";
            btdn.UseVisualStyleBackColor = false;
            btdn.Click += btdn_Click;
            // 
            // btttk
            // 
            btttk.FlatStyle = FlatStyle.Popup;
            btttk.Font = new Font("Segoe UI", 10F);
            btttk.ForeColor = Color.Navy;
            btttk.Location = new Point(604, 263);
            btttk.Name = "btttk";
            btttk.Size = new Size(132, 29);
            btttk.TabIndex = 13;
            btttk.Text = "Tạo tài khoản";
            btttk.UseVisualStyleBackColor = true;
            btttk.Click += btttk_Click;
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 450);
            Controls.Add(btttk);
            Controls.Add(btdn);
            Controls.Add(cbmk);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbmk);
            Controls.Add(tbdn);
            Name = "Formdangnhap";
            FormClosing += Formdangnhap_FormClosing;
            Load += Formdangnhap_Load;
            Click += Formdangnhap_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbdn;
        private TextBox tbmk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private CheckBox cbmk;
        private Button btdn;
        private Button btttk;
    }
}
