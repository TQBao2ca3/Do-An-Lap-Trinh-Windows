using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class DataProvider
    {
        static string strKetNoi = "Data Source= DESKTOP-9LOCH28\\SQLEXPRESS; Initial Catalog=QLSinhVien; Integrated Security=True";
        //DESKTOP-9LOCH28\\SQLEXPRESS
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            return conn;
        }
        public static SqlDataReader TruyVan(string strTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            return com.ExecuteReader();
        }
        public static SqlDataReader TruyVan(string strTruyVan, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(pars);
            return com.ExecuteReader();
        }
        public static int ThucThiLenh(string strLenh, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strLenh, conn);
            return com.ExecuteNonQuery();
        }
        public static int ThucThiLenh(string strLenh, SqlConnection conn, SqlParameter[] pars)
        {
            SqlCommand com = new SqlCommand(strLenh, conn);
            com.Parameters.AddRange(pars);
            return com.ExecuteNonQuery();
        }
    }
}
