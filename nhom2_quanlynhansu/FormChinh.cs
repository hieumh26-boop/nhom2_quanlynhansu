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
            Application.Exit();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            this.Hide();
            Formdangnhap fdn = new Formdangnhap();
            fdn.ShowDialog();
            if(fdn.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }   
            

        }
    }
}
