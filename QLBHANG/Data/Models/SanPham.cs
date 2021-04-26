using System.Collections.Generic;

namespace Data.Models
{
    public class SanPham
    {
        public string IdSP { get; set; }
        public string TenSP { get; set; }
        public double Gia { get; set; }
        public string Anh { get; set; }
        public string TrangThai { get; set; }
        public string ChiTietSP { get; set; }
        public string SoLuong { get; set; }
        public string IdNSX { get; set; }
        public string IdTLSP { get; set; }
        public NhaSanXuat NhaSanXuat { get; set; }
        public TheLoaiSP TheLoaiSP { get; set; }
        public ICollection<ChiTietDatHang> ChiTietDatHang { get; set; }
    }
}
