using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            // Phóng to toàn màn hình khi bấm F5
            this.WindowState = FormWindowState.Maximized;

            // Đưa cụm giao diện ra chính giữa
            CenterMainPanel();
        }

        private void form2_Resize(object sender, EventArgs e)
        {
            // Tự căn lại giữa khi thay đổi kích thước cửa sổ
            CenterMainPanel();
        }

        private void CenterMainPanel()
        {
            // pnlMain là tên Panel mẹ bọc toàn bộ giao diện
          
        }

        private void txtCoSo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}