using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormQuanLyNhanSu : Form
    {
        // string connectionString = @"Data Source=100.125.54.43,1433;Initial Catalog=qlhs;User ID=sa;Password=123456;TrustServerCertificate=True;Connect Timeout=30";

        public FormQuanLyNhanSu()
        {
            InitializeComponent();
        }
        private void FormQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            LoadData(); 

            cboCoSo.Items.Clear();
            cboCoSo.Items.Add("Tất cả");
            cboCoSo.Items.Add("Cơ sở 1");
            cboCoSo.Items.Add("Cơ sở 2");
            cboCoSo.SelectedIndex = 0; 
        }
        private void LoadData()
        {
            string query = "SELECT * FROM NhanVien";

            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDanhSach.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message, "Lỗi hệ thống");
                }
            }
        }  
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cboCoSo.SelectedItem == null) return;
            string coSoDuocChon = cboCoSo.SelectedItem.ToString();
            if (coSoDuocChon == "Tất cả")
            {
                LoadData();
                return;
            }

            int maCoSo = 0;
            if (coSoDuocChon == "Cơ sở 1") maCoSo = 1;
            else if (coSoDuocChon == "Cơ sở 2") maCoSo = 2;

            string query = "SELECT * FROM NhanVien WHERE MaCoSo = @MaCoSo";
            using (SqlConnection conn = new SqlConnection(classchung.ketnoi))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaCoSo", maCoSo);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDanhSach.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}
