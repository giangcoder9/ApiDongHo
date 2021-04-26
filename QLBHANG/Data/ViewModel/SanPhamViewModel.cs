using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ViewModel
{
    public class SanPhamViewModel
    {
        public string IdSP { get; set; }
        public string TenSP { get; set; }
        public string slug { get; set; }
        public double Gia { get; set; }
        public IFormFile Anh { get; set; }
        public string anh { get; set; }
        public string TrangThai { get; set; }
        public string ChiTietSP { get; set; }
        public string SoLuong { get; set; }
        public string IdNSX { get; set; }
        public string IdTLSP { get; set; }
    }
}
