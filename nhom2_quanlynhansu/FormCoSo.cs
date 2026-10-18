using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace nhom2_quanlynhansu
{
    public partial class FormCoSo : Form
    {
        public FormCoSo()
        {
            InitializeComponent();
        }
        private void cbccs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cs = "SELECT MaCoSo,TenCoSo  FROM CoSo WHERE MaCoSo=@mcs ";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            using (SqlCommand lenh = new SqlCommand(cs, kn))
            {
                try
                {

                    string giatriChon = cbccs.SelectedValue != null
                        ? cbccs.SelectedValue.ToString() : cbccs.Text.Trim();

                    lenh.Parameters.AddWithValue("@mcs", giatriChon);
                    kn.Open();
                    using (SqlDataReader doc = lenh.ExecuteReader())
                    {


                        if (doc.Read())
                        {
                            tbdcc.Text = doc["TenCoSo"].ToString();
                        }


                    }

                }
                catch
                {

                }
            }
        }
        private void btxn_Click(object sender, EventArgs e)
        {
            string cs = "UPDATE CoSo SET TenCoSo=@dcm WHERE MaCoSo=@mcs ";
            using (SqlConnection kn = new SqlConnection(classchung.ketnoi))
            using (SqlCommand lenh = new SqlCommand(cs, kn))
            {
                try
                {
                    string maCoSo = cbccs.SelectedValue != null
        ? cbccs.SelectedValue.ToString()
        : cbccs.Text.Trim();
                    lenh.Parameters.AddWithValue("@dcm", tbdcm.Text.Trim());
                    lenh.Parameters.AddWithValue("@mcs", maCoSo.Trim());
                    kn.Open();
                    int kt = lenh.ExecuteNonQuery();
                    if(kt>0)
                    {
                        MessageBox.Show("Cập nhật địa chỉ cơ sở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cập nhật lại ô địa chỉ hiện tại và xóa ô địa chỉ mới
                        tbdcc.Text = tbdcm.Text.Trim();
                        tbdcm.Clear();
                    }
                }
                catch
                {

                }
            }
        }

       
    }
}
