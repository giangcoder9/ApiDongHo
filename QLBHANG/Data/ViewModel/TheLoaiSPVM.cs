using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
    public class TheLoaiSPVM
    {
        public string IdTLSP { get; set; }
        public string TenLoaiSP { get; set; }
        public List<SanPham> SanPham { get; set; }
        
    }
}

