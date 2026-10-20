using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class fTamUngLuong : Form
    {
        public fTamUngLuong()
        {
            InitializeComponent();
        }

        private void fTamUngLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadDataThongTinNhanVien()
        {
            classchung db = new classchung();
            string sql = "SELECT nd.MaNhanVien, nv.HoTen, cs.TenCoSo, pq.TenVaiTro " +
                 "FROM [NhanVien] nv " +
                 "INNER JOIN [NguoiDung] nd ON nd.MaNhanVien = nv.MaNhanVien " +
                 "INNER JOIN [PhanQuyen] pq ON pq.MaVaiTro = nv.MaVaiTro " +
                 "INNER JOIN [CoSo] cs ON cs.MaCoSo = nv.MaCoSo " +
                 "WHERE nd.TenDangNhap = '" + Formdangnhap.TenTaiKhoanDangNhap + "'";
            DataTable dt = db.ReadData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbxMnv.Text = dt.Rows[0]["MaNhanVien"].ToString();
                tbxTnv.Text = dt.Rows[0]["HoTen"].ToString();
               // tbxSoNgayCong.Text = dt.Rows[0]["TenCoSo"].ToString();
                //tbxChucVu.Text = dt.Rows[0]["TenVaiTro"].ToString();
            }
        }




    }
}
