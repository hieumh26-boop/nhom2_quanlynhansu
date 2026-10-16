using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}

