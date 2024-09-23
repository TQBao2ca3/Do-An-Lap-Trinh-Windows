using QuanLyThuVien_DAO;
using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_BUS
{
    public class DocGiaBUS
    {
        DocGiaDAO dgDAO =new DocGiaDAO();

        public List<DocGiaDTO> DanhSachDocGia()
        {
            return dgDAO.LayDanhSachDocGia();
        }
    }
}
