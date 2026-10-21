using System.Data;

namespace nhom2_quanlynhansu
{
    public partial class fXinNghiPhep : Form
    {
        classchung db = new classchung();
        public fXinNghiPhep()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }
        // thoat chuong trinh 
        private void fXinNghiPhep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void fXinNghiPhep_Load(object sender, EventArgs e)
        {
            LoadDataThongTinNhanVien();
            cboxLnp.Focus();
            LoadDataXinNghiPhep();
        }

        private void LoadDataXinNghiPhep()
        {
            classchung db = new classchung();
            string sql = "select * from NghiPhep";
            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                // dgvXinNghiPhep.AutoGenerateColumns = false;
                dgvXinNghiPhep.DataSource = dt;
            }
        }

        // viết hàm tự nạp dữ liệu vào groupbox thông tin và hạn mức theo tài khoản hiện đang đăng nhập vào form
        private void LoadDataThongTinNhanVien()
        {
            classchung db = new classchung();
            string sql = "SELECT nd.MaNhanVien, nv.HoTen, np.SoNgayNghiToiDa, np.SoNgayNghiConLai,cs.TenCoSo,pq.TenVaiTro " +
                 "FROM [NhanVien] nv " +
                 "INNER JOIN [NguoiDung] nd ON nd.MaNhanVien = nv.MaNhanVien " +
                 "INNER JOIN [NghiPhep] np ON np.MaDonNP = nv.MaDonNP " +
                    "INNER JOIN [PhanQuyen] pq ON pq.MaVaiTro = nv.MaVaiTro " +
                "INNER JOIN [CoSo] cs ON cs.MaCoSo = nv.MaCoSo " +
                 "WHERE nd.TenDangNhap = '" + Formdangnhap.TenTaiKhoanDangNhap + "'";
         

            DataTable dt = db.ReadData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                tbxMnv.Text = dt.Rows[0]["MaNhanVien"].ToString();
                tbxTnv.Text = dt.Rows[0]["HoTen"].ToString();
                tbxToida.Text = dt.Rows[0]["SoNgayNghiToiDa"].ToString();
                tbxCon.Text = dt.Rows[0]["SoNgayNghiConLai"].ToString();
                tbxCoSo.Text = dt.Rows[0]["TenCoSo"].ToString();
                tbxChucVu.Text = dt.Rows[0]["TenVaiTro"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");

            }

        }
        // click tạo đơn
        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxLydo.Text) || cboxLnp.SelectedIndex == -1 || cboxCanghi1.SelectedIndex == -1 || cboxCanghi2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiNghiPhep = cboxLnp.Text;
            string lyDo = tbxLydo.Text;
            int maNhanVien = int.Parse(tbxMnv.Text);
            int soBuoiToiDa = int.Parse(tbxToida.Text);
            int soBuoiConLaiHienTai = int.Parse(tbxCon.Text);
            int soBuoiConLaiMoi = soBuoiConLaiHienTai - 1;

            if (soBuoiConLaiMoi < 0)
            {
                MessageBox.Show("Nhân viên này đã hết số buổi nghỉ phép còn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sqlInsert = "INSERT INTO [NghiPhep] (MaNhanVien, SoNgayNghiToiDa, SoNgayNghiConLai, LoaiNghiPhep, LyDo, TrangThaiDuyet) " +
                               "VALUES (" + maNhanVien + ", " + soBuoiToiDa + ", " + soBuoiConLaiMoi + ", N'" + loaiNghiPhep + "', N'" + lyDo + "', N'Chờ duyệt')";


            classchung db = new classchung();
            bool result = db.WriteData(sqlInsert);

            if (result)
            {
                MessageBox.Show("Tạo đơn xin nghỉ phép thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                tbxCon.Text = soBuoiConLaiMoi.ToString();

                tbxLydo.Clear();
                LoadDataXinNghiPhep();
            }
            else
            {
                MessageBox.Show("Tạo đơn thất bại, vui lòng kiểm tra lại kết nối SQL!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (dgvXinNghiPhep.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn một dòng đơn dưới bảng Lịch sử trước khi bấm Hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectRow = dgvXinNghiPhep.SelectedRows[0];

            int maDonDuocChon = int.Parse(selectRow.Cells["MaDon"].Value.ToString());
            string trangThai = selectRow.Cells["TrangThaiDuyet"].Value.ToString();

            if (trangThai == "Yes" || trangThai == "Đã duyệt" || trangThai == "Từ chối")
            {
                MessageBox.Show("Đơn này đã được quản lý phê duyệt, bạn không thể hủy nữa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn xin nghỉ số " + maDonDuocChon + " này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) return;

            int maNhanVien = int.Parse(tbxMnv.Text);
            int soBuoiConLaiHienTai = int.Parse(tbxCon.Text);
            int soBuoiConLaiMoi = soBuoiConLaiHienTai + 1;

            string sqlDeleteDon = "DELETE FROM [NghiPhep] WHERE MaDon = " + maDonDuocChon;
            string sqlUpdateHanMuc = "UPDATE [NghiPhep] SET SoNgayNghiConLai = " + soBuoiConLaiMoi + " WHERE MaNhanVien = " + maNhanVien;

            classchung db = new classchung();
            if (db.WriteData(sqlDeleteDon))
            {
                db.WriteData(sqlUpdateHanMuc); 

                MessageBox.Show("Hủy đơn xin nghỉ phép số " + maDonDuocChon + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCon.Text = soBuoiConLaiMoi.ToString();
                tbxLydo.Clear();
                LoadDataXinNghiPhep();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình hủy đơn, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


