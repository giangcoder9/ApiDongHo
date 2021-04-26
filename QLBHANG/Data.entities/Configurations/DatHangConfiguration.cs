using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.Configurations
{
    public class DatHangConfiguration:IEntityTypeConfiguration<DatHang>
    {
        public void Configure(EntityTypeBuilder<DatHang> builder)
        {
            builder.ToTable("DatHang");
            builder.HasKey(x =>x.IdDatHang);
            builder.Property(x => x.NgayDat).IsRequired();
            builder.Property(x => x.HoTen).IsRequired();
            builder.Property(x => x.SoDienThoai).IsRequired();
            builder.Property(x => x.DiaDiem).IsRequired();
            builder.Property(x => x.TongTien).IsRequired();
        }
    }
}
