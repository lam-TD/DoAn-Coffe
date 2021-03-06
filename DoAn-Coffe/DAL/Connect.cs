﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        private SqlConnection conn;
        public Connect()
        {
            conn = new SqlConnection(@"Data Source=DL;Initial Catalog=TDL_Coffee;Integrated Security=True");
            conn.Open();
        }

        public DataTable loadData(string sql) //load du lieu tra ve la mot table
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Excute(string sql) // kiem tra truy van
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
