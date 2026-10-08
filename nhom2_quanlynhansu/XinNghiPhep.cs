using System.Data;

namespace nhom2_quanlynhansu
{
    public partial class fXinNghiPhep : Form
    {
        ClassDB db = new ClassDB();
        public fXinNghiPhep()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void fXinNghiPhep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void fXinNghiPhep_Load(object sender, EventArgs e)
        {

            LoadDataXinNghiPhep();
         
        }

        private void LoadDataXinNghiPhep()
        {
            ClassDB db = new ClassDB();
            string sql = "select * from XinNghiPhep";
            DataTable dt = db.ReadData(sql);
            if (dt != null)
            {
                dgvXinNghiPhep.AutoGenerateColumns = false;
                dgvXinNghiPhep.DataSource = dt;
            }
        }

        private void btnXinNghi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMnv.Text) || string.IsNullOrEmpty(tbxLydo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã nhân viên và Lý do xin nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = tbxMnv.Text.Trim();
            string loaiPhep = cboxLnp.Text;
            string tuNgay = datetime1.Value.ToString("yyyy-MM-dd");
            string caTu = cboxCanghi1.Text;
            string denNgay = datetime2.Value.ToString("yyyy-MM-dd");
            string caDen = cboxCaNghi2.Text;
            string lyDo = tbxLydo.Text.Trim();

            string sql = "INSERT INTO XinNghiPhep (MaNhanVien, LoaiNghiPhep, TuNgay, CaNghiTu, DenNgay, CaNghiDen, LyDo) " +
                         $"VALUES ('{maNV}', N'{loaiPhep}', '{tuNgay}', N'{caTu}', '{denNgay}', N'{caDen}', N'{lyDo}')";

            try
            {
                int roweffect = db.WriteData(sql);

                if (roweffect > 0)
                {
                    MessageBox.Show("Gửi đơn xin nghỉ phép thành công! Đang chờ Quản lý phê duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxLydo.Clear();
                    LoadDataXinNghiPhep();
                }
                else
                {
                    MessageBox.Show("Gửi đơn thất bại! Hãy chắc chắn Mã nhân viên này đang tồn tại ở bảng Nhân viên gốc.", "Báo lỗi dữ liệu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống khi gửi đơn: " + ex.Message, "Lỗi");
            }
        }

    }


}

