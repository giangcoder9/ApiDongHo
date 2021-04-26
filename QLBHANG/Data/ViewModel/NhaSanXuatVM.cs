using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
    public class NhaSanXuatVM
    {
        public string IdNSX { get; set; }
        public string TenNSX { get; set; }
        public List<SanPham> SanPham { get; set; }
    }
}
