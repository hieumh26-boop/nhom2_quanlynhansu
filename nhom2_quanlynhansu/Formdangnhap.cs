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
            string csdl_nguoidung = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @tendangnhap AND MatKhau = @matkhau";// truy van SQL để kiểm tra thông tin đăng nhập

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
                        lenh.Parameters.AddWithValue("@tendangnhap", tdn);
                        lenh.Parameters.AddWithValue("@matkhau", mk);
                        int kt = (int)lenh.ExecuteScalar();// thuc thi bien "lenh"
                        if (kt > 0)//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();

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
            Formtaotaikhoancs formttk = new Formtaotaikhoancs();
            formttk.Show();
            this.Hide();
        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
        }
    }
}



