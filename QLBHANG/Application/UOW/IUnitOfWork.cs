using Application.Service;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppLication.UOW
{
    public interface IUnitOfWork: IDisposable
    {
        ISanPham SanPhams { get; }
        ITheLoaiSP TheLoais { get; }
        INhaSanXuat NSX { get; }
        int Complete();
    }
}
