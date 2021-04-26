using AppLication.Generic;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public interface ITheLoaiSP:IGenericRepository<TheLoaiSP>
    {
        List<Menu> DanhMuc();
    }
}
