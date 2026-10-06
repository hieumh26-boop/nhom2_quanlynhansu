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
            tbdn = new TextBox();
            linkLabel1 = new LinkLabel();
            cbmk = new CheckBox();
            tbmk = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btttk);
            panel1.Controls.Add(btdn);
            panel1.Controls.Add(tbdn);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(cbmk);
            panel1.Controls.Add(tbmk);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 450);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(194, 46);
            label3.TabIndex = 11;
            label3.Text = "Đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(150, 62);
            label4.TabIndex = 12;
            label4.Text = "QLNS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(297, 144);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // btttk
            // 
            btttk.FlatStyle = FlatStyle.Popup;
            btttk.Font = new Font("Segoe UI", 10F);
            btttk.ForeColor = Color.Navy;
            btttk.Location = new Point(573, 271);
            btttk.Name = "btttk";
            btttk.Size = new Size(132, 29);
            btttk.TabIndex = 13;
            btttk.Text = "Tạo tài khoản";
            btttk.UseVisualStyleBackColor = true;
            // 
            // btdn
            // 
            btdn.BackColor = Color.FromArgb(0, 0, 192);
            btdn.FlatStyle = FlatStyle.Popup;
            btdn.Font = new Font("Segoe UI", 10F);
            btdn.ForeColor = Color.White;
            btdn.Location = new Point(443, 271);
            btdn.Name = "btdn";
            btdn.Size = new Size(124, 29);
            btdn.TabIndex = 12;
            btdn.Text = "Đăng nhập";
            btdn.UseVisualStyleBackColor = false;
            btdn.Click += btdn_Click_1;
            // 
            // tbdn
            // 
            tbdn.BorderStyle = BorderStyle.FixedSingle;
            tbdn.ForeColor = Color.Black;
            tbdn.Location = new Point(443, 149);
            tbdn.Name = "tbdn";
            tbdn.Size = new Size(262, 27);
            tbdn.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(443, 233);
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
            cbmk.Location = new Point(726, 203);
            cbmk.Name = "cbmk";
            cbmk.Size = new Size(50, 27);
            cbmk.TabIndex = 11;
            cbmk.UseVisualStyleBackColor = true;
            cbmk.CheckedChanged += cbmk_CheckedChanged_1;
            // 
            // tbmk
            // 
            tbmk.BorderStyle = BorderStyle.FixedSingle;
            tbmk.ForeColor = Color.Black;
            tbmk.Location = new Point(443, 203);
            tbmk.Name = "tbmk";
            tbmk.Size = new Size(262, 27);
            tbmk.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(344, 203);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "mật khẩu";
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 450);
            Controls.Add(panel1);
            Name = "Formdangnhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btttk;
        private Label label1;
        private Button btdn;
        private TextBox tbdn;
        private LinkLabel linkLabel1;
        private CheckBox cbmk;
        private TextBox tbmk;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
