using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class formdoica : Form
    {
        public formdoica()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void btnGuiDon_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || TxtHoTen.Text == "" ||
               dtpcamuondoi.SelectedIndex == -1 ||
                dtpcahientai.SelectedIndex == -1 ||
               Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            MessageBox.Show("Gửi đơn xin đổi ca thành công!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpcamuondoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpcahientai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLydo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

