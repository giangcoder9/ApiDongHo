using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.Configurations
{
    public class ChiTietDHConfiguration : IEntityTypeConfiguration<ChiTietDatHang>
    {
        public void Configure(EntityTypeBuilder<ChiTietDatHang> builder)
        {
            builder.ToTable("ChiTietDatHang");
            builder.HasKey(x => x.IdCTDH);
            builder.HasOne<DatHang>(x => x.DatHang).WithMany(s => s.ChiTietDatHang).HasForeignKey(i => i.IdDatHang);
            builder.HasOne<SanPham>(x => x.SanPham).WithMany(s => s.ChiTietDatHang).HasForeignKey(i => i.IdSP);
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.Gia).IsRequired();



        }
    }
}
