using Data.enti.Configurations;
using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.DatabaseContext
{
    public class DbBanHang:IdentityDbContext
    {
        public DbBanHang(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new NhaSanXuatConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietDHConfiguration());
            modelBuilder.ApplyConfiguration(new DatHangConfiguration());
            modelBuilder.ApplyConfiguration(new TheLoaiSPConfiguration());
            
        }
        public DbSet<SanPham> SanPham  { get; set; }
        public DbSet<TheLoaiSP> TheLoaiSP { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public DbSet<DatHang> DatHang { get; set; }
        public DbSet<ChiTietDatHang> ChiTietDatHang { get; set; } 
    }
}
