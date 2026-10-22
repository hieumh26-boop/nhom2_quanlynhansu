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
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            btttk = new Button();
            btdn = new Button();
            txtdn = new TextBox();
            cbmk = new CheckBox();
            txtmk = new TextBox();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btttk);
            panel1.Controls.Add(btdn);
            panel1.Controls.Add(txtdn);
            panel1.Controls.Add(cbmk);
            panel1.Controls.Add(txtmk);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 450);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(256, 90);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(287, 38);
            label3.TabIndex = 11;
            label3.Text = "Đăng nhập tài khoản";
            label3.Click += cbmk_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.Location = new Point(192, 28);
            label4.Name = "label4";
            label4.Size = new Size(407, 62);
            label4.TabIndex = 12;
            label4.Text = "NHÂN SỰ MIXUE";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(112, 149);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // btttk
            // 
            btttk.FlatStyle = FlatStyle.Popup;
            btttk.Font = new Font("Segoe UI", 10F);
            btttk.ForeColor = Color.Black;
            btttk.Location = new Point(534, 271);
            btttk.Margin = new Padding(2);
            btttk.Name = "btttk";
            btttk.Size = new Size(132, 29);
            btttk.TabIndex = 13;
            btttk.Text = "Tạo tài khoản";
            btttk.UseVisualStyleBackColor = true;
            btttk.Click += btttk_Click;
            // 
            // btdn
            // 
            btdn.BackColor = SystemColors.HotTrack;
            btdn.FlatStyle = FlatStyle.Popup;
            btdn.Font = new Font("Segoe UI", 10F);
            btdn.ForeColor = Color.White;
            btdn.Location = new Point(368, 271);
            btdn.Name = "btdn";
            btdn.Size = new Size(124, 29);
            btdn.TabIndex = 12;
            btdn.Text = "Đăng nhập";
            btdn.UseVisualStyleBackColor = false;
            btdn.Click += btdn_Click;
            // 
            // txtdn
            // 
            txtdn.BorderStyle = BorderStyle.FixedSingle;
            txtdn.ForeColor = Color.Black;
            txtdn.Location = new Point(288, 149);
            txtdn.Name = "txtdn";
            txtdn.Size = new Size(262, 27);
            txtdn.TabIndex = 2;
            // 
            // cbmk
            // 
            cbmk.Appearance = Appearance.Button;
            cbmk.FlatStyle = FlatStyle.Flat;
            cbmk.Image = Properties.Resources.mătdong;
            cbmk.Location = new Point(593, 202);
            cbmk.Name = "cbmk";
            cbmk.Size = new Size(50, 27);
            cbmk.TabIndex = 11;
            cbmk.UseVisualStyleBackColor = true;
            cbmk.CheckedChanged += cbmk_CheckedChanged;
            // 
            // txtmk
            // 
            txtmk.BorderStyle = BorderStyle.FixedSingle;
            txtmk.ForeColor = Color.Black;
            txtmk.Location = new Point(288, 203);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(262, 27);
            txtmk.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(112, 198);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(256, 0);
            label5.Name = "label5";
            label5.Size = new Size(258, 28);
            label5.TabIndex = 14;
            label5.Text = "Hệ thống quản lý nhân sự";
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 450);
            Controls.Add(panel1);
            Name = "Formdangnhap";
            FormClosing += Formdangnhap_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btttk;
        private Label label1;
        private Button btdn;
        private TextBox txtdn;
        private CheckBox cbmk;
        private TextBox txtmk;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}
