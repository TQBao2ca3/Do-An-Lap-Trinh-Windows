using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class TacGiaDAO
    {
        public List<TacGiaDTO> LayDanhSachTacGia()
        {
            string strSelect = "Select * From TacGia ";
            try
            {
                List<TacGiaDTO>lsTacGia=new List<TacGiaDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr=DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    TacGiaDTO tg=new TacGiaDTO();
                    tg.MaTG = sdr["MaTG"].ToString();
                    tg.TenTG = sdr["TenTG"].ToString();

                    lsTacGia.Add(tg);
                }
                sdr.Close();
                conn.Close();
                return lsTacGia;
            }
            catch (Exception ex)
            {
                return new List<TacGiaDTO>();
            }
        }

    }
}
