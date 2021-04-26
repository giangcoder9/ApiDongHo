using AppLication.Generic;
using Data.enti.DatabaseContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service
{
    public class TheLoaiSPRepository:GenericRepository<TheLoaiSP>,ITheLoaiSP
    {
        public TheLoaiSPRepository(DbBanHang context) : base(context)
        {

        }
        public List<Menu> DanhMuc()
        {
            var listDanhMuc = _context.TheLoaiSP.Select(s => new Menu
            {
                IdTLSP = s.IdTLSP,
                TenTL = s.TenLoaiSP,
                ParenId = s.ParenId,
                slug = s.slug,
                MenuSub = _context.TheLoaiSP.Where(x => x.ParenId == s.IdTLSP).Select(n => new TheLoaiSP { slug = n.slug,TenLoaiSP=n.TenLoaiSP}).ToList()
            }).Where(y =>y.ParenId == "00").ToList();
            return listDanhMuc;
        }
    }
}
