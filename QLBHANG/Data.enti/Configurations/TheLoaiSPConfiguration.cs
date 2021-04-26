using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.Configurations
{
    public class TheLoaiSPConfiguration:IEntityTypeConfiguration<TheLoaiSP>
    {
        public void Configure(EntityTypeBuilder<TheLoaiSP> builder)
        {
            builder.ToTable("TheLoaiSP");
            builder.HasKey(x =>x.IdTLSP);
            builder.Property(x => x.TenLoaiSP).IsRequired();
        }
    }
}
