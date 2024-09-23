using QuanLyThuVien_DAO;
using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_BUS
{
    public class TacGiaBUS
    {
        TacGiaDAO tgDAO=new TacGiaDAO();
        public List<TacGiaDTO> DanhSachTacGia()
        {
            return tgDAO.LayDanhSachTacGia();
        }
    }
}
