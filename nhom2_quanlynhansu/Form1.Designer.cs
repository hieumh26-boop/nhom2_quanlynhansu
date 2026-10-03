namespace nhom2_quanlynhansu
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbdn = new CheckBox();
            cbttk = new CheckBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(469, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.YellowGreen;
            textBox2.Location = new Point(469, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
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
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(194, 46);
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
            cbdn.Location = new Point(469, 263);
            cbdn.Name = "cbdn";
            cbdn.Size = new Size(105, 33);
            cbdn.TabIndex = 7;
            cbdn.Text = "Đăng nhập";
            cbdn.UseVisualStyleBackColor = false;
            // 
            // cbttk
            // 
            cbttk.Appearance = Appearance.Button;
            cbttk.AutoSize = true;
            cbttk.BackColor = Color.White;
            cbttk.FlatStyle = FlatStyle.Popup;
            cbttk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbttk.ForeColor = Color.FromArgb(0, 0, 192);
            cbttk.Location = new Point(612, 263);
            cbttk.Name = "cbttk";
            cbttk.Size = new Size(124, 33);
            cbttk.TabIndex = 8;
            cbttk.Text = "Tạo tài khoản";
            cbttk.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(cbttk);
            Controls.Add(cbdn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbdn;
        private CheckBox cbttk;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
