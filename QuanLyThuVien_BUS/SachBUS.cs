using QuanLyThuVien_DAO;
using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_BUS
{
    public class SachBUS
    {
        SachDAO sDAO= new SachDAO();
        public List<SachDTO> DanhSachCuaSach()
        {
            return sDAO.LayDanhSachCuaSach();
        }
    }
}
