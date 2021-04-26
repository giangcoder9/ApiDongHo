using AppLication.Generic;
using Data.enti.DatabaseContext;
using Data.Models;
using Data.ViewModel;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Application.Service
{
    public class SanPhamRepository:GenericRepository<SanPham>,ISanPham
    {
        public SanPhamRepository(DbBanHang context) :base(context)
        {
        }
        public List<NhaSanXuatVM> TenSanPhamNhaSanXuat()
        {
            var ListSPTheoNSX = _context.NhaSanXuat.Select(x =>new NhaSanXuatVM { 
                IdNSX = x.IdNSX,
                TenNSX = x.TenNSX,
                SanPham = _context.SanPham.Where(y => y.IdNSX==x.IdNSX).Select(a =>new SanPham { TenSP=a.TenSP,Anh = a.Anh,SoLuong=a.SoLuong,Gia=a.Gia,IdSP=a.IdSP}).ToList()
            }).ToList();
            return ListSPTheoNSX;
        }

        public List<TheLoaiSPVM> TenSanPhamTL()
        {
            var ListSPTheoTL= _context.TheLoaiSP.Select(x => new TheLoaiSPVM
            {
                IdTLSP = x.IdTLSP,
                TenLoaiSP = x.TenLoaiSP,
                SanPham = _context.SanPham.Where(y => y.IdTLSP==x.IdTLSP).Select(a =>new SanPham { TenSP = a.TenSP, Anh = a.Anh, SoLuong = a.SoLuong, Gia = a.Gia, IdSP = a.IdSP ,TrangThai=a.TrangThai}).ToList()
            }).ToList();
            return ListSPTheoTL;
        }
        public List<SanPham> SanPhamNoiBat()
        {
            return _context.SanPham.Where(x =>x.TrangThai =="true").ToList();
        }
        public List<SanPham> SanPhamMoi()
        {
            return _context.SanPham.Where(x => x.TrangThai == "moi").ToList();
        }

        public List<SanPham> SanPhamNam()
        {
            var query = from p in _context.SanPham join tl in _context.TheLoaiSP on p.IdTLSP equals tl.IdTLSP where tl.TenLoaiSP == "Đồng Hồ Philip" || tl.TenLoaiSP == "Đồng Hồ Epus Swis" select new { p };
            var x = query.Select( x => new SanPham { TenSP = x.p.TenSP, Anh = x.p.Anh, SoLuong = x.p.SoLuong, Gia = x.p.Gia, IdSP = x.p.IdSP, TrangThai = x.p.TrangThai }).ToList();
            return x;
                   
        }

        public List<SanPham> SanPhamNu()
        {
            var query = from p in _context.SanPham join tl in _context.TheLoaiSP on p.IdTLSP equals tl.IdTLSP where tl.TenLoaiSP == "Đồng Hồ Casio" || tl.TenLoaiSP == "Đồng Hồ QQ" select new { p };
            var x = query.Select(x => new SanPham { TenSP = x.p.TenSP, Anh = x.p.Anh, SoLuong = x.p.SoLuong, Gia = x.p.Gia, IdSP = x.p.IdSP, TrangThai = x.p.TrangThai }).ToList();
            return x;
        }
        public List<SanPham> SanPhamDanhMuc(string Id)

        {
            var query = from p in _context.SanPham join tl in _context.TheLoaiSP on p.IdTLSP equals tl.IdTLSP where tl.slug == Id select new { p };
            var x = query.Select(x => new SanPham { TenSP = x.p.TenSP, Anh = x.p.Anh, SoLuong = x.p.SoLuong, Gia = x.p.Gia, IdSP = x.p.IdSP, TrangThai = x.p.TrangThai }).ToList();
            return x;
        }


        public List<DanhMucSP> DanhMucSP()

        {
            var query = from p in _context.SanPham join tl in _context.TheLoaiSP on p.IdTLSP equals tl.IdTLSP select new { p,tl };
            var x = query.Select(x => new DanhMucSP { TenSP = x.p.TenSP, Anh = x.p.Anh, SoLuong = x.p.SoLuong, Gia = x.p.Gia, IdSP = x.p.IdSP, TrangThai = x.p.TrangThai, slug=x.tl.slug}).ToList();
            return x;
        }

        public List<SanPham> SanPhamChiTiet(string Id)

        {
            return _context.SanPham.Where(x => x.IdSP == Id).ToList();
        }

        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }

        public List<SanPham> SearchSP(string Id)

        {
            return _context.SanPham.Where(delegate (SanPham sp)
            {
                if (ConvertToUnSign(sp.TenSP).IndexOf(Id, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    return true;
                else
                    return false;
            }).AsQueryable().ToList();
        }


    }


}
