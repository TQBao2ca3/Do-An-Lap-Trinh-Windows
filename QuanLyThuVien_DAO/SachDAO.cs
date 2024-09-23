using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class SachDAO
    {
        public List<SachDTO> LayDanhSachCuaSach()
        {
            string strSelect = "Select * From Sach Where TrangThai = 1";
            try
            {
                List<SachDTO> lsSach=new List<SachDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr=DataProvider.TruyVan(strSelect, conn);
                while(sdr.Read())
                {
                    SachDTO s=new SachDTO();
                    s.MaSach = sdr["MaSach"].ToString();
                    s.TenSach = sdr["TenSach"].ToString();
                    s.MaChuDe = sdr["MaChuDe"].ToString();
                    s.MaTG = sdr["MaTG"].ToString();
                    s.MaNXB = sdr["MaNXB"].ToString();
                    s.NamXB =(int)sdr["NamXB"];
                    s.SLNhap = (int)sdr["SLNhap"];
                    s.DonGia = (int)sdr["DonGia"];
                    s.HinhAnh = sdr["HinhAnh"].ToString();
                    s.TinhTrang = sdr["TinhTrang"].ToString();
                    s.GhiChu = sdr["GhiChu"].ToString();
                    s.TrangThai = (int)sdr["TrangThai"];

                    lsSach.Add(s);

                }
                sdr.Close();
                conn.Close();
                return lsSach;
            }
            catch (Exception ex)
            {
                return new List<SachDTO>();
            }
        }

    }
}
