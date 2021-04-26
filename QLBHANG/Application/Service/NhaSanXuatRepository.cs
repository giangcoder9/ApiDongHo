using AppLication.Generic;
using Data.enti.DatabaseContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service
{
    public class NhaSanXuatRepository:GenericRepository<NhaSanXuat>,INhaSanXuat
    {
        public NhaSanXuatRepository(DbBanHang context) : base(context)
        {

        }
        public List<SanPham> SPTheoNSX(string Id)
        {
            return _context.SanPham.Where(x => x.IdNSX == Id).Take(8).ToList(); 
        }
    }
}
