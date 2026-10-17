using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class fMain_orion : Form
    {
        public fMain_orion()
        {
            InitializeComponent();
        }

        private void hỆTHỐNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qLNghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //khi click vao menu QL Nghi phep thi hien ra form XinNghiPhep
            fXinNghiPhep fXnp = new fXinNghiPhep();
            fXnp.TopLevel = false;
            fXnp.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(fXnp);
            fXnp.Show();
        }

        private void qLỨngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTamUngLuong f = new fTamUngLuong();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
            f.Show();

        }
    }
}
