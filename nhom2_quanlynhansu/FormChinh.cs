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
                    kiemtraquyen(); // Gọi hàm phân quyền ngay sau khi đăng nhập thành công
                }
                else
                {
                    Application.Exit(); // Đóng hoàn toàn tiến trình ứng dụng nếu tắt Form đăng nhập
                }
            }
        }

        // Hàm kiểm tra quyền và ẩn/hiện các nút bấm chức năng
        private void kiemtraquyen()
        {
           
            // Kiểm tra nếu vai trò là Chủ chuỗi hoặc Cửa hàng trưởng
            if (PhienDangNhap.VaiTro == "1" || PhienDangNhap.VaiTro == "2")
            {
                bttnv.Visible = true;  // Tạo nhân viên
                btchc.Visible = true;  // Cấu hình ca làm việc
                btqlns.Visible = true; // Quản lý nhân sự
                

                // Chỉ riêng Chủ chuỗi mới mở được nút Phân quyền
                if (PhienDangNhap.VaiTro == "Chủ chuỗi")
                {
                    btpq.Visible = true; // Phân quyền
                }
                else
                {
                    btpq.Visible = false;
                }
            }
            else
            {
                // Nếu là Nhân viên thường -> Ẩn tất cả các nút quản lý
                bttnv.Visible = false;
                btchc.Visible = false;
                btqlns.Visible = false;
                btpq.Visible = false;
            }

            // Mặc định mở Form Hồ sơ cá nhân khi đăng nhập thành công
            MoForm(new FormQLHS());
        }

        private Form HienForm = null;
        private void MoForm(Form FormCon)
        {
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
            png.Controls.Add(FormCon);
            png.Tag = FormCon;

            FormCon.BringToFront(); // Đưa Form con lên trên cùng
            FormCon.Show();
        }

        // --- CÁC SỰ KIỆN CLICK NÚT MỞ FORM ---

        private void btqlhs_Click(object sender, EventArgs e)
        {
            MoForm(new FormQLHS());
        }

        private void btdkc_Click(object sender, EventArgs e)
        {
            MoForm(new FormDangKiCaLamViec());
        }

        private void bttul_Click(object sender, EventArgs e)
        {
            MoForm(new fTamUngLuong());
        }

        private void btxnp_Click(object sender, EventArgs e)
        {
            MoForm(new fXinNghiPhep());
        }

        private void bttnv_Click(object sender, EventArgs e)
        {
            MoForm(new Formtaonhanvien());
        }

        private void btpq_Click(object sender, EventArgs e)
        {
            MoForm(new FormPhanQuyen());
        }

        private void btchc_Click(object sender, EventArgs e)
        {
            MoForm(new formcauhinhcalamviec());
        }

        private void btqlns_Click(object sender, EventArgs e)
        {
            MoForm(new FormQuanLyNhanSu());
        }

        // --- SỰ KIỆN ĐĂNG XUẤT VÀ THOÁT ---

        private void btlg_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                using (Formdangnhap fdn = new Formdangnhap())
                {
                    if (fdn.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        kiemtraquyen();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
            else
            {
                Application.ExitThread(); // Giải phóng hoàn toàn tiến trình ứng dụng
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Trống
        }
    }
}