using AppLication.Generic;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public interface INhaSanXuat:IGenericRepository<NhaSanXuat>
    {
        List<SanPham> SPTheoNSX(string Id);
    }
}
