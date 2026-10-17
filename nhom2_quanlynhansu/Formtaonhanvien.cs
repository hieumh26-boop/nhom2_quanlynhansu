using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace nhom2_quanlynhansu
{
    public partial class Formtaonhanvien : Form
    {
        public Formtaonhanvien()
        {
            InitializeComponent();
        }

        private void bttnv_Click(object sender, EventArgs e)
        {
            string them = "INSERT INTO NhanVien (MaNhanVien, HoTen, SDT, CCCD, STK, HinhThucLamViec, MaCoSo,TenVaiTro,NgaySinh,GioiTinh) VALUES (@mnv, @ht, @sdt, @cccd, @stk, @htlv, @mcs,@cv,@ns,@gt)";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                kn.Open();
                using (SqlCommand cmd = new SqlCommand(them, kn))
                {
                    cmd.Parameters.AddWithValue("@ht", tbht.Text);
                    cmd.Parameters.AddWithValue("@sdt", tbsdt.Text);
                    cmd.Parameters.AddWithValue("@cccd", tbcccd.Text);
                    cmd.Parameters.AddWithValue("@stk", tbstk.Text);
                    cmd.Parameters.AddWithValue("@ns", datens.Value.Date);
                    string gt = "";
                    if (rbtnam.Checked)
                    {
                        gt = "Nam";
                    }
                    else if (rbtnu.Checked)
                    {
                        gt = "Nữ";
                    }
                    string htlv = "";
                    if (rbtfull.Checked)
                    {
                        htlv = "Full-time";
                    }
                    else if (rbtpart.Checked)
                    {
                        htlv = "Part-time";
                    }
                    string mcs = cbmcs.SelectedItem?.ToString() ?? "";
                    string cv = cbcv.SelectedItem?.ToString() ?? "";
                    cmd.Parameters.AddWithValue("@gt", gt);
                    cmd.Parameters.AddWithValue("@htlv", htlv);
                    cmd.Parameters.AddWithValue("@mcs", mcs);
                    cmd.Parameters.AddWithValue("@cv", cv);
                    cmd.Parameters.AddWithValue("@mnv", tbmnv.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        xoaform();
                        
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại!");
                    }
                }
            }
        }
        private void xoaform()
        {
            tbmnv.Clear();
            tbht.Clear();
            tbsdt.Clear();
            tbcccd.Clear();
            tbstk.Clear();
            datens.Value = DateTime.Now;
            rbtnam.Checked = false;
            rbtnu.Checked = false;
            rbtfull.Checked = false;
            rbtpart.Checked = false;
            cbmcs.SelectedIndex = -1;
            cbcv.SelectedIndex = -1;
        }
        private int taomnv()
        {
            Random rd = new Random();
            int manv;
            HashSet<int> danhsachdaco = new HashSet<int>();

            
            string kiemtra = "SELECT  MaNhanVien FROM NhanVien ";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            {
                kn.Open();
                using (SqlCommand lenh = new SqlCommand(kiemtra, kn))
                {
                    using (SqlDataReader doc =lenh.ExecuteReader() )
                    {
                     while(doc.Read())
                        {
                            if (doc[0]!=DBNull.Value)
                            {
                                danhsachdaco.Add(Convert.ToInt32(doc[0]));
                            }
                        }
                    }
                   
                }
            }
            if(danhsachdaco.Count>=99)
            {
                //MessageBox.Show("đã full nhân viên");
                throw new Exception("Đã hết mã nhân viên có thể tạo (đã đầy 99 mã)!");
            }

            do
            {
                manv = rd.Next(1, 100);
            } while (danhsachdaco.Contains(manv));// neu bij trung thi lap lai
            return manv;
        }
        private void bttmnv_Click(object sender, EventArgs e)
        {
            try
            {
                int manvm = taomnv();
                tbmnv.Text = manvm.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
