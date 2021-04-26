using Application.Service;
using Data.enti.DatabaseContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLication.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbBanHang _context;
        public ISanPham SanPhams { get; }
        public ITheLoaiSP TheLoais { get; }
        public INhaSanXuat NSX { get; }
        public UnitOfWork(DbBanHang _context, ISanPham SanPhams, ITheLoaiSP TheLoais, INhaSanXuat NSX)
        {
            this._context = _context;
            this.SanPhams = SanPhams;
            this.TheLoais = TheLoais;
            this.NSX = NSX;
        }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
