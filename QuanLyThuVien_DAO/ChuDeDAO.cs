using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class ChuDeDAO
    {
        public List<ChuDeDTO> LayDanhSachChuDe()
        {
            string strSelect = "Select * From ChuDe ";
            try
            {
                List<ChuDeDTO> lsChuDe=new List<ChuDeDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr=DataProvider.TruyVan(strSelect,conn);
                while (sdr.Read())
                {
                    ChuDeDTO cd=new ChuDeDTO();
                    cd.MaChuDe = sdr["MaChuDe"].ToString();
                    cd.TenChuDe = sdr["TenChuDe"].ToString();

                    lsChuDe.Add(cd);
                }
                sdr.Close();
                conn.Close();
                return lsChuDe;
            }
            catch (Exception ex)
            {
                return new List<ChuDeDTO>();
            }
        }
    }
}
