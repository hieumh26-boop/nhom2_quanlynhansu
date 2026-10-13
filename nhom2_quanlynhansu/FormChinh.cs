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
            this.Show();
            FormChinh fc = new FormChinh();
            fc.Close();



        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
