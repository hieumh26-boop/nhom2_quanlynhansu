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

        private void cbdn_CheckedChanged(object sender, EventArgs e)
        {
            string csdl_nguoidung = "SELECT COUNT(*) FROM nguoidung WHERE tendangnhap = @tendangnhap AND matkhau = @matkhau";// truy van SQL để kiểm tra thông tin đăng nhập
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                try
                {
                    if (String.IsNullOrWhiteSpace(tbdn.Text) || String.IsNullOrWhiteSpace(tbmk.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        kn.Open();
                        SqlCommand lenh = new SqlCommand(csdl_nguoidung, kn);
                        lenh.Parameters.AddWithValue("@tendangnhap", tbdn.Text.Trim());//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
                        lenh.Parameters.AddWithValue("@matkhau", tbmk.Text.Trim());
                        lenh.ExecuteScalar();// thuc thi bien "lenh";
                        int kt = (int)lenh.ExecuteScalar();

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
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }

        }

        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbmk.Checked)
            {
                tbmk.PasswordChar = '\0';
                cbmk.Image = Properties.Resources.matmo;
            }
            else
            {
                tbmk.PasswordChar = '*';
                cbmk.Image = Properties.Resources.mătdong;
            }
            {
            }
        }

        private void Formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void Formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Mày chắc chưa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}


