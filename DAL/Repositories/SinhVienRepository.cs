using DAL.Context;
using DAL.DomainClass;
using DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SinhVienRepository : ISinhVienRepository
    {
        private DBContext _dbContext;
        public SinhVienRepository()
        {
            _dbContext = new DBContext();
        }

        public bool AddSV(Sinhvien sv)
        {
            _dbContext.Add(sv);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Sinhvien> GetAllSV()
        {
            return _dbContext.Sinhviens.ToList();
        }

        public bool RemoveSV(Sinhvien sv)
        {
            _dbContext.Remove(sv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateSV(Sinhvien sv)
        {
            _dbContext.Update(sv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
