using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.enti.Configurations
{
    public class NhaSanXuatConfiguration:IEntityTypeConfiguration<NhaSanXuat>
    {
        public void Configure(EntityTypeBuilder<NhaSanXuat> builder)
        {
            builder.ToTable("NhaSanXuat");
            builder.HasKey(x => x.IdNSX);
            builder.Property(x => x.TenNSX).IsRequired();

        }
    }
}
