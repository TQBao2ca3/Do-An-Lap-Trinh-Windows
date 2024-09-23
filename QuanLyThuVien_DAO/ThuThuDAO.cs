using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_DAO
{
    public class ThuThuDAO
    {
        public List<ThuThuDTO> LayDanhSachThuThu()
        {
            string strSelect = "Select * From ThuThu Where TrangThai=1";
            try
            {
                List<ThuThuDTO>lsThuThu=new List<ThuThuDTO>();
                SqlConnection conn = DataProvider.TaoKetNoi();
                conn.Open();
                SqlDataReader sdr = DataProvider.TruyVan(strSelect,conn);
                while (sdr.Read())
                {
                    ThuThuDTO tt=new ThuThuDTO();
                    tt.MaSach = sdr["MaSach"].ToString();
                    tt.TenSach = sdr["TenSach"].ToString();
                    tt.MaChuDe = sdr["MaChuDe"].ToString();
                    tt.MaTG = sdr["MaTG"].ToString();
                    tt.MaNXB = sdr["MaNXB"].ToString();
                    tt.NamXB = (int)sdr["NamXB"];
                    tt.SLNhap = (int)sdr["SLNhap"];
                    tt.DonGia = (int)sdr["DonGia"];
                    tt.HinhAnh = sdr["HinhAnh"].ToString();
                    tt.TinhTrang = sdr["TinhTrang"].ToString();
                    tt.GhiChu = sdr["GhiChu"].ToString();
                    tt.TrangThai = 1;

                    lsThuThu.Add(tt);
                }
                sdr.Close();
                conn.Close();
                return lsThuThu;

            }
            catch (Exception ex)
            {
                return new List<ThuThuDTO>();
            }
        }
    }
}
