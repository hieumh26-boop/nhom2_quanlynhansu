using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class formchamcongbu : Form
    {
        public formchamcongbu()
        {
            InitializeComponent();
        }
        private string connectionString =
    @"Data Source=TEN_SERVER;
      Initial Catalog=TEN_DATABASE;
      Integrated Security=True;
      TrustServerCertificate=True;";

        private void KiemTraKetNoi()
        {
            try
            {
                using (SqlConnection conn =
                       new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Kết nối SQL thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);
            }
        }

        private void btnGuiDon_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoTen.Text == "" ||
                txtLyDo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            MessageBox.Show("Gửi đơn chấm công bù thành công!");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void formchamcongbu_Load(object sender, EventArgs e)
        {

        }
    }
}

