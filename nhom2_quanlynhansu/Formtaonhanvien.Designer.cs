namespace nhom2_quanlynhansu
{
    partial class Formtaonhanvien
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
            datens = new DateTimePicker();
            bttmnv = new Button();
            cbmcs = new ComboBox();
            cbcv = new ComboBox();
            rbtnu = new RadioButton();
            rbtnam = new RadioButton();
            rbtfull = new RadioButton();
            rbtpart = new RadioButton();
            tbstk = new TextBox();
            label11 = new Label();
            tbmnv = new TextBox();
            bttnv = new Button();
            tbht = new TextBox();
            tbsdt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            tbcccd = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 88);
            label1.TabIndex = 0;
            label1.Text = "tạo tài khoản cho nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 116);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "SDT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 165);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "CCCD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 213);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Hình thức làm việc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 273);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã cơ sở:";
            // 
            // datens
            // 
            datens.Location = new Point(504, 107);
            datens.Name = "datens";
            datens.Size = new Size(250, 27);
            datens.TabIndex = 30;
            // 
            // bttmnv
            // 
            bttmnv.BackColor = Color.MediumAquamarine;
            bttmnv.FlatStyle = FlatStyle.Popup;
            bttmnv.ForeColor = Color.White;
            bttmnv.Location = new Point(385, 264);
            bttmnv.Name = "bttmnv";
            bttmnv.Size = new Size(145, 29);
            bttmnv.TabIndex = 29;
            bttmnv.Text = "tạo mã nhân viên:";
            bttmnv.UseVisualStyleBackColor = false;
            bttmnv.Click += bttmnv_Click;
            // 
            // cbmcs
            // 
            cbmcs.FormattingEnabled = true;
            cbmcs.Items.AddRange(new object[] { "1", "2", "3" });
            cbmcs.Location = new Point(154, 270);
            cbmcs.Name = "cbmcs";
            cbmcs.Size = new Size(184, 28);
            cbmcs.TabIndex = 28;
            // 
            // cbcv
            // 
            cbcv.FormattingEnabled = true;
            cbcv.Items.AddRange(new object[] { "Chủ chuỗi", "Nhân viên", "Cửa hàng trưởng" });
            cbcv.Location = new Point(504, 60);
            cbcv.Name = "cbcv";
            cbcv.Size = new Size(151, 28);
            cbcv.TabIndex = 27;
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Location = new Point(555, 165);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(50, 24);
            rbtnu.TabIndex = 26;
            rbtnu.TabStop = true;
            rbtnu.Text = "Nữ";
            rbtnu.UseVisualStyleBackColor = true;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Location = new Point(464, 165);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(62, 24);
            rbtnam.TabIndex = 25;
            rbtnam.TabStop = true;
            rbtnam.Text = "Nam";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // rbtfull
            // 
            rbtfull.AutoSize = true;
            rbtfull.Location = new Point(255, 215);
            rbtfull.Name = "rbtfull";
            rbtfull.Size = new Size(83, 24);
            rbtfull.TabIndex = 24;
            rbtfull.TabStop = true;
            rbtfull.Text = "Fulltime";
            rbtfull.UseVisualStyleBackColor = true;
            // 
            // rbtpart
            // 
            rbtpart.AutoSize = true;
            rbtpart.Location = new Point(164, 215);
            rbtpart.Name = "rbtpart";
            rbtpart.Size = new Size(85, 24);
            rbtpart.TabIndex = 23;
            rbtpart.TabStop = true;
            rbtpart.Text = "Parttime";
            rbtpart.UseVisualStyleBackColor = true;
            // 
            // tbstk
            // 
            tbstk.Location = new Point(504, 210);
            tbstk.Name = "tbstk";
            tbstk.Size = new Size(151, 27);
            tbstk.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 217);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 21;
            label11.Text = "STK:";
            // 
            // tbmnv
            // 
            tbmnv.Location = new Point(545, 264);
            tbmnv.Name = "tbmnv";
            tbmnv.Size = new Size(60, 27);
            tbmnv.TabIndex = 20;
            // 
            // bttnv
            // 
            bttnv.BackColor = Color.MediumAquamarine;
            bttnv.FlatStyle = FlatStyle.Popup;
            bttnv.ForeColor = Color.White;
            bttnv.Location = new Point(432, 308);
            bttnv.Name = "bttnv";
            bttnv.Size = new Size(264, 29);
            bttnv.TabIndex = 18;
            bttnv.Text = "Tạo nhân viên";
            bttnv.UseVisualStyleBackColor = false;
            bttnv.Click += bttnv_Click;
            // 
            // tbht
            // 
            tbht.Location = new Point(154, 60);
            tbht.Name = "tbht";
            tbht.Size = new Size(184, 27);
            tbht.TabIndex = 14;
            // 
            // tbsdt
            // 
            tbsdt.Location = new Point(154, 109);
            tbsdt.Name = "tbsdt";
            tbsdt.Size = new Size(184, 27);
            tbsdt.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(385, 165);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 10;
            label10.Text = "Giới tính:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 112);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 9;
            label9.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(385, 67);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 7;
            label7.Text = "Vai trò/Chức vụ:";
            // 
            // tbcccd
            // 
            tbcccd.Location = new Point(154, 158);
            tbcccd.Name = "tbcccd";
            tbcccd.Size = new Size(184, 27);
            tbcccd.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(bttmnv);
            panel1.Controls.Add(cbmcs);
            panel1.Controls.Add(datens);
            panel1.Controls.Add(cbcv);
            panel1.Controls.Add(rbtpart);
            panel1.Controls.Add(rbtfull);
            panel1.Controls.Add(tbstk);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(tbmnv);
            panel1.Controls.Add(rbtnu);
            panel1.Controls.Add(rbtnam);
            panel1.Controls.Add(tbht);
            panel1.Controls.Add(tbsdt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbcccd);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(bttnv);
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 371);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 82);
            panel2.TabIndex = 31;
            // 
            // Formtaonhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Formtaonhanvien";
            Text = "Formtaonhanvien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbcccd;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox tbht;
        private TextBox tbsdt;
        private TextBox tbmnv;
        private Button bttnv;
        private TextBox tbstk;
        private Label label11;
        private RadioButton rbtfull;
        private RadioButton rbtpart;
        private ComboBox cbmcs;
        private ComboBox cbcv;
        private RadioButton rbtnu;
        private RadioButton rbtnam;
        private Button bttmnv;
        private DateTimePicker datens;
        private Panel panel1;
        private Panel panel2;
    }
}