using System.Data.SqlClient;
using System;
using Microsoft.Data.SqlClient;
namespace nhom2_quanlynhansu
{
    public partial class Formdangnhap : Form
    {
        public Formdangnhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void cbttk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbmk.Checked)
            {
                txtmk.PasswordChar = '\0';
                cbmk.Image = Properties.Resources.matmo;
            }
            else
            {
                txtmk.PasswordChar = '*';
                cbmk.Image = Properties.Resources.mătdong;
            }
            {
            }
        }
        private void btdn_Click(object sender, EventArgs e)
        {
            string csdl_nguoidung = "SELECT COUNT(*) FROM nguoidung WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau";// truy van SQL để kiểm tra thông tin đăng nhập
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                try
                {
                    kn.Open();
                    SqlCommand lenh = new SqlCommand(csdl_nguoidung, kn);
                    string tdn = txtdn.Text.Trim();
                    string mk = txtmk.Text.Trim();

                    if (String.IsNullOrWhiteSpace(txtdn.Text) || String.IsNullOrWhiteSpace(txtmk.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhậpp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        lenh.Parameters.AddWithValue("@tendangnhap", tdn);//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
                        lenh.Parameters.AddWithValue("@matkhau", mk);
                        int kt = (int)lenh.ExecuteScalar();// thuc thi bien "lenh"

                        if (kt > 0)//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {

                }
        }
        private void btttk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formtaotaikhoancs formttk = new Formtaotaikhoancs();
            formttk.ShowDialog();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbmk_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btdn_Click_1(object sender, EventArgs e)
        {

        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {   string taiKhoan = txtdn.Text.Trim();
            string matKhau = txtmk.Text.Trim();

                if (taiKhoan == "" || matKhau == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ Tài khoản và Mật khẩu!");
                    return;
                }
            }
        }
    }



