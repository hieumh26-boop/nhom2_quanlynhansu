using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormPhanQuyen : Form
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }
        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            string sqlDsMaNV = "SELECT MaNhanVien FROM dbo.NhanVien";
            try
            {
                using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
                using (SqlCommand cmd = new SqlCommand(sqlDsMaNV, kn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbmnv.SelectedIndexChanged -= cbmnv_SelectedIndexChanged;//thao su kien
                    cbmnv.DisplayMember = "MaNhanVien";
                    cbmnv.ValueMember = "MaNhanVien";
                    cbmnv.DataSource = dt;
                    cbmnv.SelectedIndex = -1;
                    cbmnv.SelectedIndexChanged += cbmnv_SelectedIndexChanged;//gan lai
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách mã nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //hien thong tin
        private void cbmnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmnv.SelectedValue == null) return;
            string strMaNV = cbmnv.SelectedValue is DataRowView drv ? drv["MaNhanVien"].ToString() : cbmnv.SelectedValue.ToString();
            if (!int.TryParse(strMaNV, out int maNV)) return;

            string sqlNhanVien = @"
                SELECT NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.SDT, NV.CCCD, 
                       pq.TenVaiTro, CS.MaCoSo, CS.TenCoSo, NV.HinhThucLamViec 
                FROM dbo.NhanVien NV 

                INNER JOIN dbo.CoSo CS ON NV.MaCoSo = CS.MaCoSo 
                INNER JOIN PhanQuyen pq ON NV.MaVaiTro = pq.MaVaiTro
                WHERE NV.MaNhanVien = @mnv";

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            using (SqlCommand lenh = new SqlCommand(sqlNhanVien, kn))
            {
                lenh.Parameters.Add("@mnv", SqlDbType.Int).Value = maNV;

                try
                {
                    kn.Open();
                    using (SqlDataReader doc = lenh.ExecuteReader())
                    {
                        if (doc.Read())
                        {
                            tbht.Text = doc["HoTen"] != DBNull.Value ? doc["HoTen"].ToString() : "";
                            tbgt.Text = doc["GioiTinh"] != DBNull.Value ? doc["GioiTinh"].ToString() : "";
                            tbns.Text = doc["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(doc["NgaySinh"]).ToString("dd/MM/yyyy") : "";
                            tbsdt.Text = doc["SDT"] != DBNull.Value ? doc["SDT"].ToString() : "";
                            tbcccd.Text = doc["CCCD"] != DBNull.Value ? doc["CCCD"].ToString() : "";

                            cbcv.Text = doc["TenVaiTro"] != DBNull.Value ? doc["TenVaiTro"].ToString() : "";
                            cbmcs.Text = doc["MaCoSo"] != DBNull.Value ? doc["MaCoSo"].ToString() : "";
                            tbtcs.Text = doc["TenCoSo"] != DBNull.Value ? doc["TenCoSo"].ToString() : "";
                            tbhtlv.Text = doc["HinhThucLamViec"] != DBNull.Value ? doc["HinhThucLamViec"].ToString() : "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiển thị thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btxn_Click(object sender, EventArgs e)
        {
            if (cbmnv.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strMaNV = cbmnv.SelectedValue is DataRowView drv ? drv["MaNhanVien"].ToString() : cbmnv.SelectedValue.ToString();
            if (!int.TryParse(strMaNV, out int maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vaiTroMoi = cbcv.Text.Trim();
            string sqlUpdateNhanVien = @"
                UPDATE dbo.NhanVien 
                SET MaCoSo = @mcs, 
                    MaVaiTro = @cv 
                WHERE MaNhanVien = @mnv";

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    kn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlUpdateNhanVien, kn))
                    {
                        if (int.TryParse(cbmcs.Text.Trim(), out int maCoSo))
                            cmd.Parameters.Add("@mcs", SqlDbType.Int).Value = maCoSo;
                        else
                            cmd.Parameters.Add("@mcs", SqlDbType.Int).Value = DBNull.Value;

                        // cmd.Parameters.Add("@cv", SqlDbType.NVarChar, 100).Value = vaiTroMoi;
                        if (cbcv.SelectedItem == "Chủ chuỗi")
                        {
                            cmd.Parameters.AddWithValue("@cv", 1);
                        }
                        else if (cbcv.SelectedItem == "Cửa hàng trưởng")
                        {
                            cmd.Parameters.AddWithValue("@cv", 2);
                        }
                        else if (cbcv.SelectedItem == "Nhân viên")
                        {
                            cmd.Parameters.AddWithValue("@cv", 3);
                        }
                        cmd.Parameters.Add("@mnv", SqlDbType.Int).Value = maNV;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbmnv_SelectedIndexChanged(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}