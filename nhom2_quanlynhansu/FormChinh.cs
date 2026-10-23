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

        private void FormChinh_Load(object sender, EventArgs e)
        {
            this.Hide();
            using (Formdangnhap fdn = new Formdangnhap())
            {
                if (fdn.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    kiemtraquyen(); 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }

    
        private void kiemtraquyen()
        {
            bttnv.Visible = true;  
            btchc.Visible = true;  
            btqlns.Visible = true; 
            btpq.Visible = true;   
            btdkc.Visible = true;  
            bttul.Visible = true;  
            btxnp.Visible = true;  

            
            MoForm(new FormQLHS(), "0");
        }

        private Form HienForm = null;

        private void MoForm(Form FormCon, string quyenPhep = "0")
        {
            bool coQuyen = false;

           
            if (quyenPhep == "0")
            {
                coQuyen = true; 
            }
            else if (quyenPhep == "12" && (PhienDangNhap.VaiTro == "1" || PhienDangNhap.VaiTro == "2"))
            {
                coQuyen = true; 
            }
            else if (quyenPhep == "1" && PhienDangNhap.VaiTro == "1")
            {
                coQuyen = true; 
            }

            
            if (!coQuyen)
            {
                MessageBox.Show("Bạn không có quyền hạn truy cập chức năng này!", "Cảnh báo phân quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (HienForm != null)
            {
                HienForm.Close();
            }

            HienForm = FormCon;
            FormCon.TopLevel = false; 
            FormCon.FormBorderStyle = FormBorderStyle.None; 
            FormCon.Dock = DockStyle.Fill; 
            FormCon.AutoScroll = false; 

            png.Controls.Clear();
            png.Controls.Add(FormCon);
            png.Tag = FormCon;

            FormCon.BringToFront(); 
            FormCon.Show();
        }

       

        private void btqlhs_Click(object sender, EventArgs e)
        {
            MoForm(new FormQLHS(), "0");
        }

        private void btdkc_Click(object sender, EventArgs e)
        {
            MoForm(new FormDangKiCaLamViec(), "0");
        }

        private void bttul_Click(object sender, EventArgs e)
        {
            MoForm(new fTamUngLuong(), "2");
          
        }

        private void btxnp_Click(object sender, EventArgs e)
        {
            MoForm(new fXinNghiPhep(), "0");
        }

      

        private void bttnv_Click(object sender, EventArgs e)
        {
            MoForm(new Formtaonhanvien(), "12");
        }

        private void btchc_Click(object sender, EventArgs e)
        {
            MoForm(new formcauhinhcalamviec(), "12");
        }

        private void btqlns_Click(object sender, EventArgs e)
        {
            MoForm(new FormQuanLyNhanSu(), "12");
        }

        

        private void btpq_Click(object sender, EventArgs e)
        {
            MoForm(new FormPhanQuyen(), "1");
        }


        private void btlg_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                using (Formdangnhap fdn = new Formdangnhap())
                {
                    if (fdn.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        kiemtraquyen();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else
            {
                Application.ExitThread(); 
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void png_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}