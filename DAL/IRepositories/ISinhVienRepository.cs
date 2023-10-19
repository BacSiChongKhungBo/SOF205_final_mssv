using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface ISinhVienRepository
    {
        //thêm, sửa, xóa, select sinh viên
        public bool AddSV(Sinhvien sv);
        public bool RemoveSV(Sinhvien sv);
        public bool UpdateSV(Sinhvien sv);
        public List<Sinhvien> GetAllSV();
    }
}
