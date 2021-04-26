using AppLication.Generic;
using Data.enti.DatabaseContext;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class TheLoai : GenericRepository<TheLoaiSP>, ITheLoai
    {
        public TheLoai(DbBanHang context):base(context) { }
    }
}
