using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            this.Hide();
            using (Formdangnhap fdn = new Formdangnhap())
            {
                if (fdn.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    kiemtraquyen(); // Gọi kiểm tra quyền khi bắt đầu
                }
                else
                {
                    Application.Exit(); // Đóng hoàn toàn tiến trình ứng dụng nếu tắt Form đăng nhập
                }
            }
        }

        // Hàm phân quyền: Hiển thị đầy đủ tất cả các nút bấm
        private void kiemtraquyen()
        {
            bttnv.Visible = true;  // Tạo nhân viên
            btchc.Visible = true;  // Cấu hình ca làm việc
            btqlns.Visible = true; // Quản lý nhân sự
            btpq.Visible = true;   // Phân quyền
            btdkc.Visible = true;  // Đăng ký ca
            bttul.Visible = true;  // Tạm ứng lương
            btxnp.Visible = true;  // Xin nghỉ phép

            // Mặc định mở Form Hồ sơ cá nhân khi đăng nhập thành công
            MoForm(new FormQLHS(), "0");
        }

        private Form HienForm = null;

        /// <summary>
        /// Hàm nhúng Form con vào Panel chứa logic kiểm tra quyền
        /// </summary>
        /// <param name="FormCon">Form cần hiển thị</param>
        /// <param name="quyenPhep">
        /// "0": Dành cho tất cả mọi người
        /// "12": Dành cho Chủ chuỗi (1) hoặc Cửa hàng trưởng (2)
        /// "1": Chỉ dành cho Chủ chuỗi (1)
        /// </param>
        private void MoForm(Form FormCon, string quyenPhep = "0")
        {
            bool coQuyen = false;

            // Kiểm tra điều kiện quyền truy cập
            if (quyenPhep == "0")
            {
                coQuyen = true; // Chức năng chung
            }
            else if (quyenPhep == "12" && (PhienDangNhap.VaiTro == "1" || PhienDangNhap.VaiTro == "2"))
            {
                coQuyen = true; // Quản lý
            }
            else if (quyenPhep == "1" && PhienDangNhap.VaiTro == "1")
            {
                coQuyen = true; // Chỉ Chủ chuỗi
            }

            // Nếu không đủ quyền -> Bật thông báo cảnh báo và dừng thực thi
            if (!coQuyen)
            {
                MessageBox.Show("Bạn không có quyền hạn truy cập chức năng này!", "Cảnh báo phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu đủ quyền -> Đóng Form cũ và nạp Form mới vào Panel
            if (HienForm != null)
            {
                HienForm.Close();
            }

            HienForm = FormCon;
            FormCon.TopLevel = false; // Bỏ cơ chế cửa sổ độc lập
            FormCon.FormBorderStyle = FormBorderStyle.None; // Bỏ viền Form
            FormCon.Dock = DockStyle.Fill; // Lấp đầy Panel
            FormCon.AutoScroll = false; // Tắt thanh cuộn

            png.Controls.Clear();
            png.