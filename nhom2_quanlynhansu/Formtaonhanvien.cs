using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Formtaonhanvien : Form
    {

        private static readonly Random rd = new Random();

        public Formtaonhanvien()
        {
            InitializeComponent();
        }

        private void bttnv_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbmnv.Text) || !int.TryParse(tbmnv.Text, out int mnv))
            {
                MessageBox.Show("Vui lòng nhấn nút tạo Mã nhân viên hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbht.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbht.Focus();
                return;
            }


            if (!rbtnam.Checked && !rbtnu.Checked)
            {
                MessageBox.Show("Vui lòng chọn Giới tính!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gt = rbtnam.Checked ? "Nam" : "Nữ";


            if (!rbtfull.Checked && !rbtpart.Checked)
            {
                MessageBox.Show("Vui lòng chọn Hình thức làm việc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string htlv = rbtfull.Checked ? "Full-time" : "Part-time";


            int mvt = 0;
            if (cbcv.SelectedItem != null)
            {
                string cv = cbcv.SelectedItem.ToString();
                if (cv == "Chủ chuỗi") mvt = 1;
                else if (cv == "Cửa hàng trưởng") mvt = 2;
                else if (cv == "Nhân viên") mvt = 3;
            }

            if (mvt == 0)
            {
                MessageBox.Show("Vui lòng chọn Vai trò/Chức vụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string mcs = cbmcs.SelectedValue?.ToString() ?? cbmcs.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrEmpty(mcs))                                                             
            {
                MessageBox.Show("Vui lòng chọn Cơ sở làm việc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sqlFull = @"
                -- 1. Chèn bản ghi mới vào bảng Luong với SoNgayCong = 1
                INSERT INTO dbo.Luong (SoNgayCong, HeSoLuong, LuongCoBan)
                VALUES (1, 0.5, 200000);

                -- Lấy MaLuong tự tăng vừa được sinh ra
                DECLARE @NewMaLuong INT = SCOPE_IDENTITY();

                -- 2. Chèn Nhân viên mới dùng @NewMaLuong vừa lấy
                INSERT INTO dbo.NhanVien (MaNhanVien, HoTen, SDT, CCCD, STK, HinhThucLamViec, MaCoSo, MaVaitro, NgaySinh, GioiTinh, MaLuong) 
                VALUES (@mnv, @ht, @sdt, @cccd, @stk, @htlv, @mcs, @mvt, @ns, @gt, @NewMaLuong);";

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    kn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlFull, kn))
                    {
                        cmd.Parameters.Add("@mnv", SqlDbType.Int).Value = mnv;
                        cmd.Parameters.Add("@ht", SqlDbType.NVarChar, 100).Value = tbht.Text.Trim();
                        cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 15).Value = tbsdt.Text.Trim();
                        cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 20).Value = tbcccd.Text.Trim();
                        cmd.Parameters.Add("@stk", SqlDbType.VarChar, 30).Value = tbstk.Text.Trim();
                        cmd.Parameters.Add("@htlv", SqlDbType.NVarChar, 50).Value = htlv;
                        cmd.Parameters.Add("@mcs", SqlDbType.NVarChar, 50).Value = mcs;
                        cmd.Parameters.Add("@mvt", SqlDbType.Int).Value = mvt;
                        cmd.Parameters.Add("@ns", SqlDbType.Date).Value = datens.Value.Date;
                        cmd.Parameters.Add("@gt", SqlDbType.NVarChar, 10).Value = gt;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên và khởi tạo bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            xoaform();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xoaform()
        {
            tbmnv.Clear();
            tbht.Clear();
            tbsdt.Clear();
            tbcccd.Clear();
            tbstk.Clear();
            datens.Value = DateTime.Now;
            rbtnam.Checked = false;
            rbtnu.Checked = false;
            rbtfull.Checked = false;
            rbtpart.Checked = false;
            cbmcs.SelectedIndex = -1;
            cbcv.SelectedIndex = -1;
        }

        private int taomnv()
        {
            HashSet<int> danhsachdaco = new HashSet<int>();
            string kiemtra = "SELECT MaNhanVien FROM dbo.NhanVien";

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                kn.Open();
                using (SqlCommand lenh = new SqlCommand(kiemtra, kn))
                using (SqlDataReader doc = lenh.ExecuteReader())
                {
                    while (doc.Read())
                    {
                        if (doc[0] != DBNull.Value)
                        {
                            danhsachdaco.Add(Convert.ToInt32(doc[0]));
                        }
                    }
                }
            }

            if (danhsachdaco.Count >= 99)
            {
                throw new Exception("Danh sách nhân viên đã đầy (tối đa 99 mã)!");
            }

            int manv;
            do
            {
                manv = rd.Next(1, 100);
            } while (danhsachdaco.Contains(manv));

            return manv;
        }

        private void bttmnv_Click(object sender, EventArgs e)
        {
            try
            {
                int manvm = taomnv();
                tbmnv.Text = manvm.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbtnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbmcs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}