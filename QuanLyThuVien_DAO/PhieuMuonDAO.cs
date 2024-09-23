using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class PhieuMuonDAO
    {
        public List<PhieuMuonDTO> LayDanhSachPhieuMuon()
        {
            string strSelect = "Select * From PhieuMuon ";
            try
            {
                List<PhieuMuonDTO> lsPhieuMuon=new List<PhieuMuonDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr = DataProvider.TruyVan(strSelect,conn);
                while (sdr.Read())
                {
                    PhieuMuonDTO pm=new PhieuMuonDTO();
                    pm.MaPM = sdr["MaPM"].ToString();
                    pm.MaSach = sdr["MaSach"].ToString();
                    pm.NgayMuon = (DateTime)sdr["NgayMuon"];
                    pm.NgayTra = (DateTime)sdr["NgayTra"];
                    pm.SLMuon = (int)sdr["SLMuon"];
                    pm.TinhTrang = sdr["TinhTrang"].ToString();
                    pm.MaPM = sdr["GhiChu"].ToString();

                    lsPhieuMuon.Add(pm);
                }
                sdr.Close();
                conn.Close();
                return lsPhieuMuon;
            }
            catch (Exception ex)
            {
                return new List<PhieuMuonDTO>();
            }
        }
    }
}
