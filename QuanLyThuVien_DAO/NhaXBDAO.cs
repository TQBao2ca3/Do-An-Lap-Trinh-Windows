using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class NhaXBDAO
    {
        public List<NhaXBDTO> LayDanhSachNhaXB()
        {
            string strSelect = "Select * From NhaXB Where TrangThai = 1";
            try
            {
                List<NhaXBDTO>lsNhaXB=new List<NhaXBDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr = DataProvider.TruyVan(strSelect, conn);
                while (sdr.Read())
                {
                    NhaXBDTO nxb= new NhaXBDTO();
                    nxb.MaNXB = sdr["MaNXB"].ToString();
                    nxb.TenNXB = sdr["TenNXB"].ToString();
                    nxb.DiaChi = sdr["DiaChi"].ToString();
                    nxb.Email = sdr["Email"].ToString();
                    nxb.SDT = (int)sdr["SDT"];
                    nxb.TrangThai = (int)sdr["TrangThai"];

                    lsNhaXB.Add(nxb);
                }
                sdr.Close();
                conn.Close();
                return lsNhaXB;
            }
            catch (Exception ex)
            {
                return new List<NhaXBDTO>();
            }
        }
    }
}
