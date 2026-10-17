using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Formtaotaikhoancs : Form
    {
        public Formtaotaikhoancs()
        {
            InitializeComponent();
        }
        private void btxnttk_Click(object sender, EventArgs e)
        {
            string them = "INSERT INTO NguoiDung (TenDangNhap,MatKhau,MaNhanVien) VALUES (@tdn,@mk,@mnv)";
            string kiemtratontai = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @tdn";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(tbmk2.Text) || string.IsNullOrWhiteSpace(tbtdn2.Text)||string.IsNullOrWhiteSpace(tbmnv.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        kn.Open();
                        SqlCommand lenh = new SqlCommand(them, kn);
                        SqlCommand kt1 = new SqlCommand(kiemtratontai, kn);
                        lenh.Parameters.AddWithValue("@tdn", tbtdn2.Text);
                        lenh.Parameters.AddWithValue("@mk", tbmk2.Text);
                        lenh.Parameters.AddWithValue("@mnv", tbmnv.Text);
                        kt1.Parameters.AddWithValue("@tdn", tbtdn2.Text);
                        int kt2 = (int)kt1.ExecuteScalar();
                        if (tbmk2.Text != tbxnmk.Text)
                        {
                            MessageBox.Show("Sai mật khẩu xác nhận", "Warning", MessageBoxButtons.OK);
                        }
                        else if (kt2 > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại", "Warning", MessageBoxButtons.OK);
                        }
                        else
                        {
                            lenh.ExecuteNonQuery();// Thực hiện câu lệnh SQL
                            MessageBox.Show("Tạo tài Khoản tành công", "Thông báo", MessageBoxButtons.OK);
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);

                }
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            Formdangnhap formdn = new Formdangnhap();
            this.Hide();
            formdn.ShowDialog();
           

        }

        private void cbmkttk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmkttk.Checked)
            {
                tbmk2.PasswordChar = '\0';
                cbmkttk.Image = Properties.Resources.matmo;
            }
            else
            {
                tbmk2.PasswordChar = '*';
                cbmkttk.Image = Properties.Resources.mătdong;
            }
            {
            }
        }

        private void Formtaotaikhoancs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Formdangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
