using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void btlg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Hide();
            Formdangnhap fdn = new Formdangnhap();
            fdn.ShowDialog();
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }
        private void FormChinh_Load(object sender, EventArgs e)
        {
            this.Hide();
            Formdangnhap fdn = new Formdangnhap();
            fdn.ShowDialog();
            if (fdn.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
        private Form HienForm = null;
        private void MoForm(Form FormCon)
        {
            if (HienForm != null)
            {
                HienForm.Close();
            }
            HienForm = FormCon;
            FormCon.TopLevel = false;// bỏ cơ chế của sổ
            FormCon.FormBorderStyle = FormBorderStyle.None;// bỏ viền của form
            FormCon.Dock = DockStyle.Fill;// cho form con full panel
            png.Controls.Clear();
            png.Controls.Add(FormCon);
            png.Tag = FormCon;
            FormCon.BringToFront();// đưa form con lên trên cùng
            FormCon.Show();
        }

        private void btqlhs_Click(object sender, EventArgs e)
        {
            MoForm(new FormQLHS());
        }

        private void bttnv_Click(object sender, EventArgs e)
        {
            MoForm(new Formtaonhanvien());
        }

    }
}


