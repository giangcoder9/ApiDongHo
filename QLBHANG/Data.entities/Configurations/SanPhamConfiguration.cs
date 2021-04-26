using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.Configurations
{
    public class SanPhamConfiguration:IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.IdSP);
            builder.HasOne<NhaSanXuat>(x => x.NhaSanXuat).WithMany(s => s.SanPham).HasForeignKey(i=>i.IdNSX);
            builder.HasOne<TheLoaiSP>(x => x.TheLoaiSP).WithMany(s => s.SanPham).HasForeignKey(i => i.IdTLSP);
            builder.Property(x => x.TenSP).IsRequired();
            builder.Property(x => x.Gia).IsRequired();
            builder.Property(x => x.Anh).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            builder.Property(x => x.ChiTietSP).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            

        }
    }
}
