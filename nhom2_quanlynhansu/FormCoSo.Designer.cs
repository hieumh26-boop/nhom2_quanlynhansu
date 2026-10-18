namespace nhom2_quanlynhansu
{
    partial class FormCoSo
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
            panel2 = new Panel();
            bth = new Button();
            label4 = new Label();
            tbdcm = new TextBox();
            label3 = new Label();
            cbccs = new ComboBox();
            tbdcc = new TextBox();
            btxn = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 68);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa cơ sở";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(bth);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbdcm);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbccs);
            panel2.Controls.Add(tbdcc);
            panel2.Controls.Add(btxn);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 382);
            panel2.TabIndex = 8;
            // 
            // bth
            // 
            bth.Location = new Point(243, 284);
            bth.Name = "bth";
            bth.Size = new Size(188, 29);
            bth.TabIndex = 7;
            bth.Text = "Hủy";
            bth.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 188);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ mới:";
            // 
            // tbdcm
            // 
            tbdcm.Location = new Point(360, 188);
            tbdcm.Name = "tbdcm";
            tbdcm.Size = new Size(190, 27);
            tbdcm.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 128);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ hiện tại:";
            // 
            // cbccs
            // 
            cbccs.FormattingEnabled = true;
            cbccs.Items.AddRange(new object[] { "001", "002", "003" });
            cbccs.Location = new Point(360, 59);
            cbccs.Name = "cbccs";
            cbccs.Size = new Size(147, 28);
            cbccs.TabIndex = 3;
            cbccs.SelectedIndexChanged += cbccs_SelectedIndexChanged;
            // 
            // tbdcc
            // 
            tbdcc.Location = new Point(360, 125);
            tbdcc.Name = "tbdcc";
            tbdcc.ReadOnly = true;
            tbdcc.Size = new Size(190, 27);
            tbdcc.TabIndex = 1;
            // 
            // btxn
            // 
            btxn.Location = new Point(457, 284);
            btxn.Name = "btxn";
            btxn.Size = new Size(188, 29);
            btxn.TabIndex = 2;
            btxn.Text = "xác nhận";
            btxn.UseVisualStyleBackColor = true;
            btxn.Click += btxn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 67);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Chọn Cơ Sở:";
            // 
            // FormCoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "FormCoSo";
            Text = "FormCoSo";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button bth;
        private Label label4;
        private TextBox tbdcm;
        private Label label3;
        private ComboBox cbccs;
        private TextBox tbdcc;
        private Button btxn;
        private Label label2;
    }
}