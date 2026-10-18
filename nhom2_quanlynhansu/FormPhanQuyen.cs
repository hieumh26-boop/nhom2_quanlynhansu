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

                    
                    cbmnv.SelectedIndexChanged -= cbmnv_SelectedIndexChanged;

                    cbmnv.DisplayMember = "MaNhanVien";
                    cbmnv.ValueMember = "MaNhanVien";
                    cbmnv.DataSource = dt;
                    cbmnv.SelectedIndex = -1; 

                    
                    cbmnv.SelectedIndexChanged += cbmnv_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách mã nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void cbmnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmnv.SelectedValue == null || !int.TryParse(cbmnv.SelectedValue.ToString(), out int maNV))
            {
                return;
            }

            string sqlNhanVien = @"
                SELECT NV.HoTen, NV.GioiTinh, NV.NgaySinh, NV.SDT, NV.CCCD, 
                       PQ.TenVaiTro, CS.MaCoSo, CS.TenCoSo, NV.HinhThucLamViec 
                FROM dbo.NhanVien NV 
                LEFT JOIN dbo.CoSo CS ON NV.MaCoSo = CS.MaCoSo 
                LEFT JOIN dbo.PhanQuyen PQ ON NV.MaNhanVien = PQ.MaNhanVien 
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
                            // ĐÃ SỬA: Đỏ dữ liệu đúng tên cột (không kèm tên bảng NV., PQ., CS.)
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
            if (cbmnv.SelectedValue == null || !int.TryParse(cbmnv.SelectedValue.ToString(), out int maNV))
            {
                MessageBox.Show("Vui lòng chọn Mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string suacv = "UPDATE dbo.PhanQuyen SET TenVaiTro = @cv WHERE MaNhanVien = @mnv";
            string suacs = "UPDATE dbo.NhanVien SET MaCoSo = @mcs WHERE MaNhanVien = @mnv"; // Cập nhật Mã cơ sở cho Nhân viên

            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                kn.Open();
                SqlTransaction giaodich = kn.BeginTransaction();

                try
                {
                    
                    using (SqlCommand sua1 = new SqlCommand(suacv, kn, giaodich))
                    {
                        sua1.Parameters.Add("@cv", SqlDbType.NVarChar, 100).Value = cbcv.Text.Trim(); 
                        sua1.Parameters.Add("@mnv", SqlDbType.Int).Value = maNV;
                        sua1.ExecuteNonQuery();
                    }

                   
                    using (SqlCommand sua2 = new SqlCommand(suacs, kn, giaodich))
                    {
                        sua2.Parameters.Add("@mcs", SqlDbType.Int).Value = Convert.ToInt32(cbmcs.Text); 
                        sua2.Parameters.Add("@mnv", SqlDbType.Int).Value = maNV;
                        sua2.ExecuteNonQuery();
                    }

                    giaodich.Commit();
                    MessageBox.Show("Cập nhật phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    giaodich.Rollback();
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}