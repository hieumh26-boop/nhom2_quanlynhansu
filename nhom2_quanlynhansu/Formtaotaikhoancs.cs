using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Formtaotaikhoancs : Form
    {
        public Formtaotaikhoancs()
        {
            InitializeComponent();
        }
        //nut xac nhan
        private void btxnttk_Click(object sender, EventArgs e)
        {
            //kt cach thua
            if (string.IsNullOrWhiteSpace(tbtdn2.Text) ||
                string.IsNullOrWhiteSpace(tbmk2.Text) ||
                string.IsNullOrWhiteSpace(tbxnmk.Text) ||
                string.IsNullOrWhiteSpace(tbmnv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (tbmk2.Text != tbxnmk.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxnmk.Focus();
                return;
            }

            //kt manv
            if (!int.TryParse(tbmnv.Text.Trim(), out int maNhanVien))
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmnv.Focus();
                return;
            }
            //kt coi co tendn giong ko
            string kiemtratontai = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @tdn";
            string them = "INSERT INTO NguoiDung (TenDangNhap, MatKhau, MaNhanVien) VALUES (@tdn, @mk, @mnv)";

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    kn.Open();


                    using (SqlCommand kt1 = new SqlCommand(kiemtratontai, kn))
                    {
                        kt1.Parameters.Add("@tdn", SqlDbType.VarChar, 50).Value = tbtdn2.Text.Trim();
                        int count = (int)kt1.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbtdn2.Focus();
                            return;
                        }
                    }

                    
                    using (SqlCommand lenh = new SqlCommand(them, kn))
                    {
                        lenh.Parameters.Add("@tdn", SqlDbType.VarChar, 50).Value = tbtdn2.Text.Trim();
                        lenh.Parameters.Add("@mk", SqlDbType.NVarChar, 100).Value = tbmk2.Text; // Lưu ý: thực tế nên hash mật khẩu
                        lenh.Parameters.Add("@mnv", SqlDbType.Int).Value = maNhanVien;

                        int rows = lenh.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            tbtdn2.Clear();
                            tbmk2.Clear();
                            tbxnmk.Clear();
                            tbmnv.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //nut thoat
        private void btt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ma hoa mk
        private void cbmkttk_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = cbmkttk.Checked ? '\0' : '*';
            tbmk2.PasswordChar = passwordChar;
            tbxnmk.PasswordChar = passwordChar;

            if (cbmkttk.Checked)
            {
                cbmkttk.Image = Properties.Resources.matmo;
            }
            else
            {
                cbmkttk.Image = Properties.Resources.mătdong;
            }
        }
        //nut thoat 
        private void Formtaotaikhoancs_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}