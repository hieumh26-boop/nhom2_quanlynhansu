using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace nhom2_quanlynhansu
{
    internal class classchung
    {
        public static string ketnoi = @"Data Source =100.125.54.43,1433;Database=qlns;User Id=sa;password=123456;trustServerCertificate=True;";
        public DataTable ReadData(string sql)
        {
            using (SqlConnection kn = new SqlConnection(ketnoi))
            {
                try
                {
                    kn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sql, kn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;

                }
            }
        }
        //them sua xoa
        public bool WriteData(string sql)
        {
            using (SqlConnection kn = new SqlConnection(ketnoi))
            {
                try
                {
                    kn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, kn))
                    {
                        // Thực thi câu lệnh xuống SQL Server
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Trả về true nếu có ít nhất 1 dòng bị tác động (Ghi thành công)
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu SQL: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }

    }

