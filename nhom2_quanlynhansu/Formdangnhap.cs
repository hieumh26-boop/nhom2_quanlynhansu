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
                       
                        lenh.ExecuteScalar();// thuc thi bien "lenh";
                        
                        if("@tendangnhap"==tbdn.Text.Trim()&&"@matkhau"==tbmk.Text.Trim())//trim loại bỏ khoảng trắng ở đầu và cuối chuỗi
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
                    //THUggg
                }

            }
        }
    }


