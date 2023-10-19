using BUS.IServices;
using DAL.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SinhVienService : ISinhVienService
    {
        private SinhVienRepository _repos;
        public SinhVienService()
        {
            _repos = new SinhVienRepository();
        }
        public string Add(Sinhvien sv)
        {
            if (_repos.AddSV(sv) == true)
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public List<Sinhvien> GetSVs(string search)
        {
            if(search == null) // ko search
            {
                return _repos.GetAllSV();
            } 
            else
            {
                return _repos.GetAllSV().Where(x => x.Sdt.Contains(search)).ToList();
            }
        }

        public string Remove(Sinhvien sv) // xóa chỉ quan tâm id
        {
            //tạo 1 clone
            var clone = _repos.GetAllSV().FirstOrDefault(x => x.Id == sv.Id);
            //Gọi repos để xóa clone
            if(_repos.RemoveSV(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }

        public string Update(Sinhvien sv)
        {
            //tạo 1 clone
            var clone = _repos.GetAllSV().FirstOrDefault(x => x.Id == sv.Id);
            clone.Ten = sv.Ten;
            clone.Sdt = sv.Sdt;
            clone.Email = sv.Email;
            clone.IdPh = sv.IdPh;
            clone.Diachi = sv.Diachi;
            if (_repos.UpdateSV(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }
    }
}
