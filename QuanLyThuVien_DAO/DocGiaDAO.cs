using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class DocGiaDAO
    {
        public List<DocGiaDTO> LayDanhSachDocGia()
        {
           string strSelect = "Select * From DocGia Where TrangThai = 1";
            try
            {
                List<DocGiaDTO>lsDocGia=new List<DocGiaDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr=DataProvider.TruyVan(strSelect, conn);
                while(sdr.Read())
                {
                    DocGiaDTO dg=new DocGiaDTO();
                    dg.MaDG = sdr["MaDG"].ToString();
                    dg.TenDG = sdr["TenDG"].ToString();
                    dg.GioiTinhDG = sdr["GioiTinhDG"].ToString();
                    dg.NgaySinhDG = (DateTime)sdr["NgaySinhDG"];
                    dg.SDTDG = (int)sdr["SDTDG"];
                    dg.LoaiDG = sdr["LoaiDG"].ToString();
                    dg.TenTaiKhoanDG = sdr["TenTaiKhoanDG"].ToString();
                    dg.MatKhauDG = sdr["MatKhauDG"].ToString();
                    dg.DiaChiDG = sdr["DiaChiDG"].ToString();
                    dg.GhiChu = sdr["GhiChu"].ToString();
                    dg.TrangThai = (int)sdr["TrangThai"];

                    lsDocGia.Add(dg);
                }
                sdr.Close();
                conn.Close();
                return lsDocGia;
            }
            catch (Exception ex)
            {
                return new List<DocGiaDTO>();
            }
        }
    }
}
