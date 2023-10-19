using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface ISinhVienService
    {
        //thêm, sửa, xóa, hiển thị áp dụng tìm kiếm
        public string Add(Sinhvien sv);
        public string Remove(Sinhvien sv);
        public string Update(Sinhvien sv);
        public List<Sinhvien> GetSVs(string search);
    }
}
