using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace nhom2_quanlynhansu
{
    internal class ClassDB
    {
        private string connection;

        public ClassDB()
        {
            connection = "Data Source=LAPTOP-1NL7VI93;Initial Catalog=QLNhanSu;User ID=sa;Password=03012006;Encrypt=True;TrustServerCertificate=True";
        }
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd, LoadOption.OverwriteChanges);
                if (dt.Rows.Count == 0)
                {
                    con.Close();
                    return null;
                }
                con.Close();
            }
            catch
            {
                con.Close();
            }
            return dt;

        }
        //phuong thuc thao tac voi csdl
        public int WriteData(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, con);
            int roweffect = -1;
            try
            {
                con.Open();
                roweffect = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
                return -1;
            }
            return roweffect;
        }
    }

}
