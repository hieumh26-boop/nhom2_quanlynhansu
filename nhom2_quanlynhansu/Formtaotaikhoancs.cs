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
            string them = "INSERT INTO nguoidung (tendangnhap,matkhau) VALUES (@tdn,@mk)";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(tbmk2.Text) || string.IsNullOrWhiteSpace(tbtdn2.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        kn.Open();
                        SqlCommand lenh = new SqlCommand(them, kn);
                        lenh.Parameters.AddWithValue("@tdn", tbtdn2.Text);
                        lenh.Parameters.AddWithValue("@mk", tbmk2.Text);
                        if (tbmk2.Text != tbxnmk.Text)
                        {
                            MessageBox.Show("Sai mật khẩu xác nhận", "Warning", MessageBoxButtons.OK);
                        }
                        lenh.ExecuteNonQuery();// Thực hiện câu lệnh SQL
                        MessageBox.Show("Tạo tài Khoản tành công", "Thông báo", MessageBoxButtons.OK);
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
            formdn.Show();
            this.Close();
        }

        
    }
}
