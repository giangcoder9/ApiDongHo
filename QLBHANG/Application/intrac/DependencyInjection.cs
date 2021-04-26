using Application.Service;
using AppLication.UOW;
using Data.enti.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLication.intrac
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISanPham, SanPhamRepository>();
            services.AddTransient<ITheLoaiSP, TheLoaiSPRepository>();
            services.AddTransient<INhaSanXuat, NhaSanXuatRepository>();
            services.AddDbContext<DbBanHang>(opt => opt
                .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=QLBanHang;Integrated Security=True"));
            return services;
        }
    }
}
