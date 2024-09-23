using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class ChiTietMuonDAO
    {
        public List<ChiTietMuonDTO> LayDanhSachChiTietMuon()
        {
            string strSelect = "Select * From ChiTietMuon ";
            try
            {
                List<ChiTietMuonDTO>lsChiTietMuon=new List<ChiTietMuonDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr=DataProvider.TruyVan(strSelect,conn);
                while (sdr.Read())
                {
                    ChiTietMuonDTO ctm=new ChiTietMuonDTO();
                    ctm.MaPM = sdr["MaPM"].ToString();
                    ctm.MaSach = sdr["MaSach"].ToString();
                    ctm.NgayMuon = (DateTime)sdr["NgayMuon"];
                    ctm.NgayTra = (DateTime)sdr["NgayTra"];
                    ctm.SLMuon = (int)sdr["SLMuon"];
                    ctm.TinhTrang = sdr["TinhTrang"].ToString();
                    ctm.GhiChu = sdr["GhiChu"].ToString();

                    lsChiTietMuon.Add(ctm);
                }
                sdr.Close();
                conn.Close();
                return lsChiTietMuon;
            }
            catch (Exception ex)
            {
                return new List<ChiTietMuonDTO>();
            }
        }
    }
}
