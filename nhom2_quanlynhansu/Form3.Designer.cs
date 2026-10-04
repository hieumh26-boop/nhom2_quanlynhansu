namespace nhom2_quanlynhansu
{
	partial class Form3
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
			groupBox1 = new GroupBox();
			dgvThongBao = new DataGridView();
			colNguoiGui = new DataGridViewTextBoxColumn();
			colTieude = new DataGridViewTextBoxColumn();
			groupBox2 = new GroupBox();
			txtTieuDe = new TextBox();
			txtNguoiGui = new TextBox();
			txtNgayGui = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			rtbNoiDung = new RichTextBox();
			btnDaDoc = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvThongBao).BeginInit();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvThongBao);
			groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			groupBox1.Location = new Point(76, 69);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(421, 373);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách thông báo";
			// 
			// dgvThongBao
			// 
			dgvThongBao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvThongBao.Columns.AddRange(new DataGridViewColumn[] { colNguoiGui, colTieude });
			dgvThongBao.Location = new Point(51, 67);
			dgvThongBao.Name = "dgvThongBao";
			dgvThongBao.RowHeadersWidth = 51;
			dgvThongBao.Size = new Size(302, 223);
			dgvThongBao.TabIndex = 0;
			// 
			// colNguoiGui
			// 
			colNguoiGui.HeaderText = "Người gửi";
			colNguoiGui.MinimumWidth = 6;
			colNguoiGui.Name = "colNguoiGui";
			colNguoiGui.Width = 125;
			// 
			// colTieude
			// 
			colTieude.HeaderText = "Tiêu đề";
			colTieude.MinimumWidth = 6;
			colTieude.Name = "colTieude";
			colTieude.Width = 125;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnDaDoc);
			groupBox2.Controls.Add(rtbNoiDung);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(txtNgayGui);
			groupBox2.Controls.Add(txtNguoiGui);
			groupBox2.Controls.Add(txtTieuDe);
			groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
			groupBox2.Location = new Point(619, 54);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(432, 500);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chi tiết thông báo";
			groupBox2.Enter += groupBox2_Enter;
			// 
			// txtTieuDe
			// 
			txtTieuDe.Location = new Point(197, 65);
			txtTieuDe.Name = "txtTieuDe";
			txtTieuDe.Size = new Size(192, 34);
			txtTieuDe.TabIndex = 0;
			// 
			// txtNguoiGui
			// 
			txtNguoiGui.Location = new Point(197, 119);
			txtNguoiGui.Name = "txtNguoiGui";
			txtNguoiGui.Size = new Size(192, 34);
			txtNguoiGui.TabIndex = 1;
			// 
			// txtNgayGui
			// 
			txtNgayGui.Location = new Point(197, 177);
			txtNgayGui.Name = "txtNgayGui";
			txtNgayGui.Size = new Size(192, 34);
			txtNgayGui.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 71);
			label1.Name = "label1";
			label1.Size = new Size(88, 28);
			label1.TabIndex = 3;
			label1.Text = "Tiêu đề:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 125);
			label2.Name = "label2";
			label2.Size = new Size(114, 28);
			label2.TabIndex = 4;
			label2.Text = "Người gửi:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(47, 183);
			label3.Name = "label3";
			label3.Size = new Size(104, 28);
			label3.TabIndex = 5;
			label3.Text = "Ngày gửi:";
			// 
			// rtbNoiDung
			// 
			rtbNoiDung.Location = new Point(52, 232);
			rtbNoiDung.Name = "rtbNoiDung";
			rtbNoiDung.Size = new Size(337, 129);
			rtbNoiDung.TabIndex = 6;
			rtbNoiDung.Text = "Nội dung";
			// 
			// btnDaDoc
			// 
			btnDaDoc.Location = new Point(47, 413);
			btnDaDoc.Name = "btnDaDoc";
			btnDaDoc.Size = new Size(221, 43);
			btnDaDoc.TabIndex = 7;
			btnDaDoc.Text = "Đánh dấu đã đọc";
			btnDaDoc.UseVisualStyleBackColor = true;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1161, 658);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form3";
			Text = "Form3";
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvThongBao).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private DataGridView dgvThongBao;
		private DataGridViewTextBoxColumn colNguoiGui;
		private DataGridViewTextBoxColumn colTieude;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox txtTieuDe;
		private RichTextBox rtbNoiDung;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txtNgayGui;
		private TextBox txtNguoiGui;
		private Button btnDaDoc;
	}
}