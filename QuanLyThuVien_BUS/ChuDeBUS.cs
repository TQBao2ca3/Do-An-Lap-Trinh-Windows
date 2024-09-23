using QuanLyThuVien_DAO;
using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_BUS
{
    public class ChuDeBUS
    {
        ChuDeDAO cdDAO=new ChuDeDAO();
        public List<ChuDeDTO> DanhSachChuDe()
        {
            return cdDAO.LayDanhSachChuDe();
        }
    }
}
