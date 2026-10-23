using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace nhom2_quanlynhansu
{
    public partial class fTamUngLuong : Form
    {
        private string currentMaLuong = "";
        public fTamUngLuong()
        {
            InitializeComponent();
        }

        private void fTamUngLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Environment.Exit(0); thua r
        }
        private void LoadDuLieu()
        {
            classchung db = new classchung();
            string sql = "select * from UngLuong";
            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvLichSu.AutoGenerateColumns = false;
                dgvLichSu.DataSource = dt;
            }
        }
        private void LoadDataThongTinNhanVien()
        {
            classchung db = new classchung();
            string sql = "SELECT nv.MaNhanVien, nv.HoTen,l.MaLuong ,l.HeSoLuong, l.SoNgayCong, l.LuongCoBan, " +
                         "ISNULL((SELECT SUM(SoTienUng) FROM [UngLuong] WHERE MaLuong = l.MaLuong), 0) AS TongUngLuong " +
                         "FROM [NhanVien] nv " +
                         "INNER JOIN [NguoiDung] nd ON nd.MaNhanVien = nv.MaNhanVien " +
                         "INNER JOIN [Luong] l ON nv.MaLuong = l.MaLuong " +
                         "WHERE nd.TenDangNhap = '" + Formdangnhap.TenTaiKhoanDangNhap + "'";

            DataTable dt = db.ReadData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                currentMaLuong = dt.Rows[0]["MaLuong"].ToString();
                tbxMnv.Text = dt.Rows[0]["MaNhanVien"].ToString();
                tbxTnv.Text = dt.Rows[0]["HoTen"].ToString();
                tbxSnc.Text = dt.Rows[0]["SoNgayCong"].ToString();
                tbxHsl.Text = dt.Rows[0]["HeSoLuong"].ToString();
                tbxLcb.Text = dt.Rows[0]["LuongCoBan"].ToString();
                tbxDu.Text = dt.Rows[0]["TongUngLuong"].ToString();

                double luongCoBan = Convert.ToDouble(tbxLcb.Text);
                double heSoLuong = Convert.ToDouble(tbxHsl.Text);
                double soNgayCong = Convert.ToDouble(tbxSnc.Text);
                double ungLuong = Convert.ToDouble(tbxDu.Text);
                double luongTamTinh = (heSoLuong * luongCoBan * soNgayCong);
                double conlai = (heSoLuong * luongCoBan * soNgayCong) - ungLuong;
                tbxLtt.Text = luongTamTinh.ToString("#,##0");
                tbxLcb.Text = luongCoBan.ToString("#,##0");
                tbxDu.Text = ungLuong.ToString("#,##0");
                tbxConlai.Text = conlai.ToString("#,##0");
            }
        }

        private void fTamUngLuong_Load(object sender, EventArgs e)
        {
            LoadDataThongTinNhanVien();
            LoadDuLieu();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxStso.Text) || string.IsNullOrEmpty(tbxStso.Text) || string.IsNullOrEmpty(tbxLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số tiền ứng và Lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double LuongTamTinh = Convert.ToDouble(tbxLtt.Text);
            double daUngLuongCu = Convert.ToDouble(tbxDu.Text);
            double Sotienungthem = Convert.ToDouble(tbxStso.Text);
            double daUngMoi = daUngLuongCu + Sotienungthem;
            double Sotienconlai = LuongTamTinh - daUngMoi;

            // thôngg báo nếu ứng quá 3 trăm 
            if (Sotienconlai <= 300000)
            {
                MessageBox.Show("giữ 300 làm vốn nhé!!!Ứng gì ứng suốt, cuối tháng lấy gì ăn!!!");
                return;
            }
            tbxDu.Text = daUngMoi.ToString("#,##0");
            tbxConlai.Text = Sotienconlai.ToString("#,##0");

            // load lên dgv

            int soThuTuTuDong = dgvLichSu.Rows.Count + 1;
            string maUng = soThuTuTuDong.ToString();
            string maLuong = currentMaLuong;
            string thangUng = DateTime.Now.ToString("yyyy-MM-dd");
            string soTien = tbxStso.Text;
            string lyDo = tbxLyDo.Text;
            //string trangThai = "Chờ duyệt";
            string sqlInsert = "INSERT INTO [UngLuong] (MaUngLuong, MaLuong, SoTienUng, LyDo, ThoiGian) " +
                          "VALUES (" + maUng + ", " + maLuong + ", '" + soTien + "', '" + lyDo + "', '" + thangUng + "')";
            classchung db = new classchung();
            bool result = db.WriteData(sqlInsert);

            if (result)
            {
                MessageBox.Show("Thêm đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDuLieu();
                tbxStso.Clear();
                tbxStchu.Clear();
                tbxLyDo.Clear();
            }
            else
            {
                MessageBox.Show("Tạo đơn thất bại, vui lòng kiểm tra lại kết nối SQL!");
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn một dòng đơn dưới bảng Lịch sử trước khi bấm Hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectRow = dgvLichSu.SelectedRows[0];
            int maDonDuocChon = int.Parse(selectRow.Cells["MaUngLuong"].Value.ToString());
            double soTienHuyDon = Convert.ToDouble(selectRow.Cells["SoTienUng"].Value.ToString());

            string sqlDeleteDon = "DELETE FROM [UngLuong] WHERE MaUngLuong = " + maDonDuocChon;
            classchung db = new classchung();
            bool resuil = db.WriteData(sqlDeleteDon);
            if (resuil)
            {
                MessageBox.Show("Hủy đơn ứng số" + maDonDuocChon + " thành công");
                double conLaiCu = Convert.ToDouble(tbxConlai.Text);
                double daUngCu = Convert.ToDouble(tbxDu.Text);

                double daUngMoi = daUngCu - soTienHuyDon;
                double tienConLaiMoi = conLaiCu + soTienHuyDon;
                tbxDu.Text = daUngMoi.ToString("#,##0");
                tbxConlai.Text = tienConLaiMoi.ToString("#,##0");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Loi Huy Don");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
